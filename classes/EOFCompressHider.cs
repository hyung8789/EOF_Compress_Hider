using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace EOF_Compress_Hider.classes
{
    public class EOFCompressHider
    {
        #region public:
        public Main _main;

        public EOFCompressHider(Main srcMain)
        {
            this.Init();
            this._main = srcMain; //LogManager 접근 위해 메인 폼 참조
        }
        public void Generate(OptionValues srcOptionValues, string srcCoverImgPath, string srcTargetPath, string srcOutputPath) //생성 작업 수행
        {
            if (srcCoverImgPath == string.Empty || srcTargetPath == string.Empty || srcOutputPath == string.Empty)
                throw new Exception("미 입력된 데이터가 존재합니다.");

            /*** 작업 수행 위한 데이터 할당 ***/
            this._coverImgPath = srcCoverImgPath;
            this._targetPath = srcTargetPath;
            this._outputPath = srcOutputPath;

            try
            {
                this.Compress();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            this._currentFileIOState = Predef.FileIOState.WORKING; //작업 중임을 알림

            byte[] buffer = new byte[1024 * 1024 * 10]; //파일 스트림 처리를 위한 10mb크기의 버퍼

            FileStream coverImgFileStream; //커버 이미지 파일 스트림
            FileStream targetFileStream; //압축 완료 된 숨기기 위한 파일 스트림
            FileStream outputFileStream; //출력 파일 스트림

            FileInfo tmpCompressedInfo; //임시 파일 제거 위한 파일 정보

            switch (srcOptionValues.OverwriteCurrentImage)
            {
                case true: //기존 커버 이미지에 덮어쓰기
                    coverImgFileStream = new FileStream(this._coverImgPath, FileMode.Append, FileAccess.Write); //커버 이미지 파일 스트림
                    targetFileStream = new FileStream(this._tmpCompressedPath, FileMode.Open, FileAccess.Read); //압축 완료 된 숨기기 위한 파일 스트림
                    tmpCompressedInfo = new FileInfo(this._tmpCompressedPath);

                    try //커버 이미지에 덮어쓰기
                    {
                        while (coverImgFileStream.Position < coverImgFileStream.Length)
                        {
                            int length = targetFileStream.Read(buffer, 0, buffer.Length);
                            coverImgFileStream.Write(buffer, 0, length);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        coverImgFileStream.Flush();
                        coverImgFileStream.Close();

                        targetFileStream.Close();
                        
                        tmpCompressedInfo.Delete(); //임시 파일 제거

                        this._currentFileIOState = Predef.FileIOState.IDLE; //작업 종료를 알림
                    }  
                   
                    break;

                case false: //새로운 파일에 작성
                    coverImgFileStream = new FileStream(this._coverImgPath, FileMode.Open, FileAccess.Read); //커버 이미지 파일 스트림
                    targetFileStream = new FileStream(this._tmpCompressedPath, FileMode.Open, FileAccess.Read); //압축 완료 된 숨기기 위한 파일 스트림
                    outputFileStream = new FileStream(this._outputPath, FileMode.Create, FileAccess.Write); //출력 파일 스트림
                    tmpCompressedInfo = new FileInfo(this._tmpCompressedPath);
                    
                    try //커버 이미지 처리
                    {
                        while (coverImgFileStream.Position < coverImgFileStream.Length)
                        {
                            int length = coverImgFileStream.Read(buffer, 0, buffer.Length);
                            outputFileStream.Write(buffer, 0, length);
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        coverImgFileStream.Close();

                        outputFileStream.Flush();
                    }

                    try //압축 완료 된 숨기기 위한 파일 처리
                    {
                        while (targetFileStream.Position < targetFileStream.Length)
                        {
                            int length = targetFileStream.Read(buffer, 0, buffer.Length);
                            outputFileStream.Write(buffer, 0, length);
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        targetFileStream.Close();
                        
                        outputFileStream.Flush();
                        outputFileStream.Close();

                        tmpCompressedInfo.Delete(); //임시 파일 제거

                        this._currentFileIOState = Predef.FileIOState.IDLE; //작업 종료를 알림
                    }

                    break;
            } 
        }
        public void Init() //초기화
        {
            this._coverImgPath = this._targetPath = this._outputPath = this._tmpCompressedPath = string.Empty;
            this._currentFileIOState = Predef.FileIOState.IDLE;
        }
        public Predef.FileIOState CurrentFileIOState
        {
            get 
            { 
                return this._currentFileIOState; 
            }
        }
        #endregion

        #region private:
        private void Compress() //압축 수행
        {
            _main._logManager.Update_Log(Environment.NewLine + "Compress...", Predef.LogMode.APPEND);

            this._tmpCompressedPath = Path.GetTempFileName();

            FastZip zip = new FastZip();

            string targetName = Path.GetFileName(this._targetPath);
            string targetParentPath = Path.GetFullPath(Path.Combine(this._targetPath, @"..\")); //타켓의 부모 디렉토리 경로
  
            zip.CreateEmptyDirectories = true;
            zip.CompressionLevel = (ICSharpCode.SharpZipLib.Zip.Compression.Deflater.CompressionLevel)_main._optionValues.CompressLevel;

            if (_main._optionValues.Password != string.Empty)
            {
                zip.Password = _main._optionValues.Password;
                zip.EntryEncryptionMethod = (ICSharpCode.SharpZipLib.Zip.ZipEncryptionMethod)_main._optionValues.EncryptionMethod;
            }

            zip.UseZip64 = UseZip64.Dynamic;
            try
            {
                //특정 폴더 압축을 위해서 부모 디렉토리에서 해당 폴더를 필터로 걸어준다.
                //왜 폴더 추가가 안되지?
                string directoryFilter = @"fold$";
                zip.CreateZip(this._tmpCompressedPath, targetParentPath, true, "", directoryFilter);

                //zip.CreateZip(this._tmpCompressedPath, this._targetPath, true, "", "");
            }
            catch(Exception ex)
            {
                throw ex;
            }

            _main._logManager.Update_Log(Environment.NewLine + "done", Predef.LogMode.APPEND);
        }

        private string _coverImgPath; //커버 이미지 파일 경로
        private string _targetPath; //숨기기 위한 파일 경로
        private string _outputPath; //출력 파일 경로
        private string _tmpCompressedPath; //작업용 임시 압축 파일 경로

        private Predef.FileIOState _currentFileIOState; //현재 파일 작업 상태
        #endregion
    }
}