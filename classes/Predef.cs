namespace EOF_Compress_Hider.classes
{
    public static class Predef
    {
        public static string[] textBoxData =
        {
            "커버로 사용 할 이미지 지정",
            "숨기기 위한 파일들 혹은 폴더 지정",
            "출력 파일 지정"
        };

        public enum LogMode
        {
            APPEND,
            OVERWRITE
        }

        public enum FileIOState //파일 입출력 처리 상태
        {
            IDLE,
            WORKING
        }

        public enum CompressLevel : int //압축 레벨
        {
            LOW = 1,
            MID = -1, //default
            HIGH = 9
        }

        public static string[] CompressLevelData =
        {
           "빠르게 - 최저 압축", //LOW
           "중간 - Default", //MID
           "느리게 - 최고 압축" //HIGH
        };

        public enum EncryptionMethod : int //암호화 방식
        {
            None = 0,
            ZipCrypto = 1, //default
            AES128 = 2,
            AES256 = 3 
        }
    }
}