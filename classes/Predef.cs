namespace EOF_Compress_Hider.classes
{
    public static class Predef
    {
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

        public enum TargetType
        {
            NONE,
            FILE,
            DIRECTORY
        }

        public enum CompressLevel : int //압축 레벨
        {
            LOW = 1,
            MID = 5, //default
            HIGH = 9
        }

        public static string[] CompressLevelData =
        {
           "빠르게 - 최저 압축", //LOW
           "중간 - Default", //MID
           "느리게 - 최고 압축" //HIGH
        };
    }
}