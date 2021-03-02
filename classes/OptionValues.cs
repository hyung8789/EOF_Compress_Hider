namespace EOF_Compress_Hider.classes
{
    public class OptionValues
    {
        #region public:
        public OptionValues()
        {
            this.Init();
        }

        public void Init() //초기화
        {
            this._OverwriteCurrentCoverImage = false;
            this._compressLevel = Predef.CompressLevel.MID;
            this._password = string.Empty;
        }
        public bool OverwriteCurrentCoverImage
        {
            get 
            { 
                return this._OverwriteCurrentCoverImage; 
            }
            set 
            { 
                this._OverwriteCurrentCoverImage = value; 
            }
        }
        public Predef.CompressLevel CompressLevel
        {
            get 
            { 
                return this._compressLevel; 
            }
            set 
            { 
                this._compressLevel = value; 
            }
        }
        public string Password
        {
            get 
            { 
                return this._password; 
            }
            set 
            { 
                this._password = value; 
            }
        }
        #endregion

        #region private:
        private bool _OverwriteCurrentCoverImage; //기존 커버 이미지 파일에 덮어쓰기
        private Predef.CompressLevel _compressLevel; //압축 레벨
        private string _password; //압축 암호
        #endregion
    }
}
