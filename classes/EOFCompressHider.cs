using ICSharpCode.SharpZipLib.Zip;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;

namespace EOF_Compress_Hider.classes
{
    public class EOFCompressHider
    {
        #region public:
        public int _totalFileCount; //전체 파일 수
        public Predef.TargetType _targetType; //Target의 타입 (파일 혹은 폴더)

        public Main _main;

        public EOFCompressHider(Main srcMain)
        {
            this._targetType = Predef.TargetType.NONE;
            this._main = srcMain; //OptionValues 및 LogManager 접근 위해 메인 폼 참조

            this._totalFileCount = 0; //해당 데이터는 최초 한 번만 초기화, 이 후 메인 폼에서 Target 선택 시 매 번 할당
            this.Init();
        }
        public void Generate(string srcCoverImgPath, string srcTargetPath, string srcOutputPath) //생성 작업 수행
        {
            bool srcPathEntered = true; //파라미터로 받은 경로 데이터들 입력 여부

            if (srcCoverImgPath == string.Empty || srcTargetPath == string.Empty) //커버 이미지, 타겟이 할당되지 않았을 경우
                srcPathEntered = false;
            if (srcOutputPath == string.Empty && !this._main._optionValues.OverwriteCurrentCoverImage) //기존 커버 이미지에 덮어쓰기 옵션이 비활성화 되어 있을 경우, 출력 경로 요구
                srcPathEntered = false;
            else //기존 커버 이미지에 덮어쓰기 옵션이 활성화 되어 있을 경우, 출력 경로는 무시
                srcPathEntered = true;

            if (!srcPathEntered)
                throw new Exception("미 입력된 데이터가 존재합니다.");

            /*** 작업 수행 위한 데이터 할당 ***/
            this._coverImgPath = srcCoverImgPath;
            this._targetPath = srcTargetPath;
            this._outputPath = srcOutputPath;

            this._currentFileIOState = Predef.FileIOState.WORKING; //작업 중임을 알림

            try
            {
                this.Compress();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            byte[] buffer = new byte[1024 * 1024]; //파일 스트림 처리를 위한 버퍼

            FileStream coverImgFileStream; //커버 이미지 파일 스트림
            FileStream targetFileStream; //압축 완료 된 숨기기 위한 파일 스트림
            FileStream outputFileStream; //출력 파일 스트림
            FileInfo tmpCompressedInfo; //임시 파일 제거 위한 파일 정보

            _main._logManager.UpdateLog("Target -> Output " + "(0bytes / 0bytes)", Predef.LogMode.APPEND);
            switch (_main._optionValues.OverwriteCurrentCoverImage)
            {
                case true: //기존 커버 이미지에 덮어쓰기
                    coverImgFileStream = new FileStream(this._coverImgPath, FileMode.Append, FileAccess.Write); //커버 이미지 파일 스트림
                    targetFileStream = new FileStream(this._tmpCompressPath, FileMode.Open, FileAccess.Read); //압축 완료 된 숨기기 위한 파일 스트림
                    tmpCompressedInfo = new FileInfo(this._tmpCompressPath);

                    try //커버 이미지에 덮어쓰기
                    {
                        while (targetFileStream.Position < targetFileStream.Length)
                        {
                            int length = targetFileStream.Read(buffer, 0, buffer.Length);
                            coverImgFileStream.Write(buffer, 0, length);

                            _main._logManager.UpdateLog("Target -> Cover Image " + "(" + coverImgFileStream.Position.ToString() + "bytes / " + coverImgFileStream.Length.ToString() + "bytes)", Predef.LogMode.OVERWRITE);
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

                            _main._logManager.UpdateLog("Cover Image -> Output " + "(" + coverImgFileStream.Position.ToString() + "bytes / " + coverImgFileStream.Length.ToString() + "bytes)", Predef.LogMode.OVERWRITE);
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

                    _main._logManager.UpdateLog("Target -> Output " + "(0bytes / 0bytes)", Predef.LogMode.APPEND);

                    try //압축 완료 된 Target 파일 처리
                    {
                        while (targetFileStream.Position < targetFileStream.Length)
                        {
                            int length = targetFileStream.Read(buffer, 0, buffer.Length);
                            outputFileStream.Write(buffer, 0, length);

                            _main._logManager.UpdateLog("Target -> Output " + "(" + targetFileStream.Position.ToString() + "bytes / " + targetFileStream.Length.ToString() + "bytes)", Predef.LogMode.OVERWRITE);
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

            _main._logManager.UpdateLog("Generate Done", Predef.LogMode.APPEND);
            this.Init();
        }
        public void Init() //초기화
        {
            this._currentWorkingFileIndex = 0;
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
        private int _currentWorkingFileIndex; //현재 작업 중인 파일 번호

        private string _coverImgPath; //커버 이미지 파일 경로
        private string _targetPath; //숨기기 위한 파일 혹은 폴더 경로
        private string _outputPath; //출력 파일 경로
        private string _tmpCompressPath; //작업용 임시 압축 파일 경로

        private Predef.FileIOState _currentFileIOState; //현재 파일 작업 상태

        private void Compress() //압축 수행
        {
            this._tmpCompressPath = Path.GetTempFileName();

            FileStream outputFileStream = new FileStream(this._tmpCompressPath, FileMode.Create);
            ZipOutputStream zip = new ZipOutputStream(outputFileStream);
            zip.SetLevel((int)_main._optionValues.CompressLevel);
            if (_main._optionValues.Password != string.Empty)
            {
                zip.Password = _main._optionValues.Password;

            }
            zip.UseZip64 = UseZip64.Dynamic;

            string[] fileList = { string.Empty };
            switch (this._targetType)
            {
                case Predef.TargetType.FILE:
                    fileList = Regex.Split(this._targetPath, Environment.NewLine);
                    foreach (string fileName in fileList)
                    {
                        /***
                            각 타켓 파일에 대하여 zip 아카이브에 추가 후 기록
                        ***/
                        string entryPath = Path.GetFileName(fileName);

                        FileStream fs = File.OpenRead(fileName);
                        ZipEntry zipEntry = new ZipEntry(entryPath);

                        zipEntry.DateTime = DateTime.Now;
                        zip.PutNextEntry(zipEntry);

                        this._currentWorkingFileIndex++;
                        _main._logManager.UpdateLog("Compressing..." + "(" + this._currentWorkingFileIndex.ToString() + "/" + this._totalFileCount + ")", Predef.LogMode.APPEND);
                        _main._logManager.UpdateLog(entryPath + "(0bytes / 0bytes)", Predef.LogMode.APPEND);

                        while (fs.Position < fs.Length)
                        {
                            byte[] buffer = new byte[1024 * 1024]; //파일 스트림 처리를 위한 버퍼
                            int length = fs.Read(buffer, 0, buffer.Length);
                            zip.Write(buffer, 0, length);

                            _main._logManager.UpdateLog(entryPath + " (" + fs.Position.ToString() + "bytes / " + fs.Length.ToString() + "bytes)", Predef.LogMode.OVERWRITE);
                        }

                        fs.Close();
                    }
                    break;

                case Predef.TargetType.DIRECTORY:
                    //해당 디렉터리 내의 파일 및 모든 하위 디렉터리, 하위 파일 포함
                    RecursiveCompress(this._targetPath, zip, true);
                    break;

                default:
                    throw new Exception("잘못 된 TargetType");
            }

            zip.Finish();
            zip.Close();
            outputFileStream.Close();

            _main._logManager.UpdateLog("Compress Done", Predef.LogMode.APPEND);
        }

        private void RecursiveCompress(string srcPath, ZipOutputStream srcZipOutputStream, bool srcExcludeCurrentDir) //파일 및 디렉터리를 모두 포함하기 위해 재귀적 탐색하여 압축 수행 
        {
            string[] fileList = Directory.GetFileSystemEntries(srcPath); //원본 디렉터리의 모든 파일과 하위 디렉터리 탐색
            bool excludeCurrentDir = srcExcludeCurrentDir; //현재 디렉터리 제외 판별 (true : 현재 디렉터리 제외, false : 현재 디렉터리 포함)

            foreach (string fileName in fileList)
            {
                if (Directory.Exists(fileName)) //하위 디렉터리가 존재하면 해당 디렉터리에서 재 탐색
                {
                    RecursiveCompress(fileName, srcZipOutputStream, false);
                }
                else
                {
                    /***
                        각 타켓 파일에 대하여 zip 아카이브에 추가 후 기록
                    ***/
                    FileStream fs = File.OpenRead(fileName);

                    /***
                        압축 엔트리에 할당 된 경로명 그대로 압축되므로,
                        dir/file.txt 형식으로 압축 엔트리 추가 위해 전체 디렉터리 경로에서 현재 파일까지의 경로를 제외한다.
                    ***/
                    string parentDirName = Directory.GetParent(fileName).Name;
                    string entryPath = string.Empty;
                    switch (excludeCurrentDir) //현재 위치가 사용자가 선택한 디렉터리인 경우 현재 디렉터리 이름을 zipEntry에 추가하지 않는다.
                    {
                        case true: //현재 디렉터리 이름 제외
                            entryPath = @"\" + Path.GetFileName(fileName);
                            break;

                        case false: //현재 디렉터리 이름 포함
                            entryPath = parentDirName + @"\" + Path.GetFileName(fileName);
                            break;
                    }

                    ZipEntry zipEntry = new ZipEntry(entryPath);

                    zipEntry.DateTime = DateTime.Now;
                    srcZipOutputStream.PutNextEntry(zipEntry);

                    this._currentWorkingFileIndex++;
                    _main._logManager.UpdateLog("Compressing..." + "(" + this._currentWorkingFileIndex.ToString() + "/" + this._totalFileCount + ")", Predef.LogMode.APPEND);
                    _main._logManager.UpdateLog(entryPath + "(0bytes / 0bytes)", Predef.LogMode.APPEND);

                    while (fs.Position < fs.Length)
                    {
                        byte[] buffer = new byte[1024 * 1024]; //파일 스트림 처리를 위한 버퍼
                        int length = fs.Read(buffer, 0, buffer.Length);
                        srcZipOutputStream.Write(buffer, 0, length);

                        _main._logManager.UpdateLog(entryPath + " (" + fs.Position.ToString() + "bytes / " + fs.Length.ToString() + "bytes)", Predef.LogMode.OVERWRITE);
                    }

                    fs.Close();
                }
            }
        }
        #endregion
    }
}