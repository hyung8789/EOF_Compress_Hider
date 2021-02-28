using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Text.RegularExpressions;
using ICSharpCode.SharpZipLib.Core;
using System.Linq;

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

            byte[] buffer = new byte[4096]; //파일 스트림 처리를 위한 버퍼

            FileStream coverImgFileStream; //커버 이미지 파일 스트림
            FileStream targetFileStream; //압축 완료 된 숨기기 위한 파일 스트림
            FileStream outputFileStream; //출력 파일 스트림

            FileInfo tmpCompressedInfo; //임시 파일 제거 위한 파일 정보

            switch (srcOptionValues.OverwriteCurrentImage)
            {
                case true: //기존 커버 이미지에 덮어쓰기
                    coverImgFileStream = new FileStream(this._coverImgPath, FileMode.Append, FileAccess.Write); //커버 이미지 파일 스트림
                    targetFileStream = new FileStream(this._tmpCompressPath, FileMode.Open, FileAccess.Read); //압축 완료 된 숨기기 위한 파일 스트림
                    tmpCompressedInfo = new FileInfo(this._tmpCompressPath);

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
                    targetFileStream = new FileStream(this._tmpCompressPath, FileMode.Open, FileAccess.Read); //압축 완료 된 숨기기 위한 파일 스트림
                    outputFileStream = new FileStream(this._outputPath, FileMode.Create, FileAccess.Write); //출력 파일 스트림
                    tmpCompressedInfo = new FileInfo(this._tmpCompressPath);

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
            this._uptoFileCount = this._totalFileCount = 0;
            this._coverImgPath = this._targetPath = this._outputPath = this._tmpCompressPath = string.Empty;
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
            _main._logManager.UpdateLog("Compress...", Predef.LogMode.APPEND);

            this._tmpCompressPath = Path.GetTempFileName();

            FastZipEvents events = new FastZipEvents();
            events.ProcessFile = this.ProcessFileMethod;
            FastZip fZip = new FastZip(events);

            fZip.CreateEmptyDirectories = true;
            fZip.CompressionLevel = (ICSharpCode.SharpZipLib.Zip.Compression.Deflater.CompressionLevel)_main._optionValues.CompressLevel;

            if (_main._optionValues.Password != string.Empty)
            {
                fZip.Password = _main._optionValues.Password;
                fZip.EntryEncryptionMethod = (ICSharpCode.SharpZipLib.Zip.ZipEncryptionMethod)_main._optionValues.EncryptionMethod;
            }

            fZip.UseZip64 = UseZip64.Dynamic;

            /*** 다중 파일 선택 할 경우 처리를 위해 _targetPath에서 줄 바꿈 문자 개수로 파일 개수 판별 ***/
            MatchCollection matches = Regex.Matches(this._targetPath, Environment.NewLine);
            switch (matches.Count)
            {
                case 0: //폴더 지정 시 줄 바꿈 문자를 삽입하지 않으므로 한 개의 폴더로 처리 
                case 1: //한 개의 파일 혹은 폴더
                    try
                    {
                        fZip.CreateZip(this._tmpCompressPath, this._targetPath, true, "", "");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    break;

                default: //두 개 이상의 파일
                    /***
                        타겟 파일에 대해 사용자가 선택을 성공적으로 수행 할 경우 기존에 선택 된 파일 목록은 초기화된다.
                        따라서, 사용자가 서로 다른 부모 디렉터리에 있는 파일을 선택하는 경우는 발생하지 않는다.
                        ---
                        => 다중 파일 선택 시 해당 디렉터리 내에서 파일 필터로 추가
                        해당 디렉터리 내의 자식 디렉터리에 사용자가 타켓 파일로 선택하지 않았지만
                        동일한 파일 이름이 존재 할 수 있으므로, 재귀적 탐색은 수행하지 않는다.
                        ---
                        1) _targetPath를 줄 바꿈 문자 기준으로 각각 분리
                        2) 각 분리 된 문자열을 파일명으로 변환 및 파일 필터로 사용
                        3) 소스 디렉터리는 타켓 파일의 부모 디렉터리로 지정
                    ***/

                    string[] fileList = Regex.Split(_targetPath, Environment.NewLine);
                    this._totalFileCount = fileList.Length - 1; //마지막 줄 바꿈 문자 이후 공백 데이터에 대하여 접근하지 않기 위해 -1

                    string fileFilter = string.Empty;
                    string targetParentDir = (Directory.GetParent(fileList[0])).ToString();

                    for (int i = 0; i < this._totalFileCount; i++)
                    {
                        /***
                            세미콜론 문자로 구분
                            ex)
                            모든 .txt 파일 포함 => @"\\.txt$"
                            test1.txt, test2.bin 파일 포함 => @"\\test1.txt$;\\test2.bin$"
                        ***/
                        fileFilter += @"\\" + Path.GetFileName(fileList[i]) + "$;";
                    }
                    MessageBox.Show(fileFilter);

                    /***
                        파일 이름에 공백이 들어 갈 경우 압축 시 해당 파일을 인식을 못하는 문제
                    ***/

                    try
                    {
                        fZip.CreateZip(this._tmpCompressPath, targetParentDir, false, fileFilter, "");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    break;
            }

            _main._logManager.UpdateLog("done", Predef.LogMode.APPEND);
        }

        private void ProcessFileMethod(object sender, ScanEventArgs args) //작업 진행 상황 처리
        {
            this._uptoFileCount++;
            double percent = this._uptoFileCount * 100 / this._totalFileCount;

            _main._logManager.UpdateLog("Compressing..." + Path.GetFileName(args.Name) + " (" + this._uptoFileCount.ToString() + "/" + this._totalFileCount + ")", Predef.LogMode.OVERWRITE);
            
            if (_uptoFileCount - 1 == _totalFileCount) //작업 완료 된 파일 수는 1부터 시작이므로 작업 완료 판별을 위하여 -1 한 값과 비교
                args.ContinueRunning = false;
        }

        private int _uptoFileCount; //현재 작업 완료 된 파일 수
        private int _totalFileCount; //전체 파일 수

        private string _coverImgPath; //커버 이미지 파일 경로
        private string _targetPath; //숨기기 위한 파일 경로
        private string _outputPath; //출력 파일 경로
        private string _tmpCompressPath; //작업용 임시 압축 파일 경로

        private Predef.FileIOState _currentFileIOState; //현재 파일 작업 상태
        #endregion
    }
}