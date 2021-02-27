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
            this._overwriteCurrentImage = false;
            this._compressLevel = Predef.CompressLevel.MID;

            this._password = string.Empty;
            this._encryptionMethod = Predef.EncryptionMethod.AES256;
        }
        public bool OverwriteCurrentImage
        {
            get 
            { 
                return this._overwriteCurrentImage; 
            }
            set 
            { 
                this._overwriteCurrentImage = value; 
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
        public Predef.EncryptionMethod EncryptionMethod
        {
            get
            {
                return this._encryptionMethod;
            }
            set
            {
                this._encryptionMethod = value;
            }
        }
        #endregion

        #region private:
        private bool _overwriteCurrentImage; //기존 이미지 파일에 덮어쓰기
        private Predef.CompressLevel _compressLevel; //압축 레벨
        private string _password; //압축 암호
        private Predef.EncryptionMethod _encryptionMethod; //압축 암호화 방식
        #endregion
    }
}
