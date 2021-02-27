using System;

namespace EOF_Compress_Hider.classes
{
    public class Utils
    {
        public static string ConvertFileSize(long bytes) //파일 사이즈 변환
        {
            string size = "0bytes";

            if (bytes >= 1073741824.0)
                size = String.Format("{0:##.##}", bytes / 1073741824.0) + "gb";
            else if (bytes >= 1048576.0)
                size = String.Format("{0:##.##}", bytes / 1048576.0) + "mb";
            else if (bytes >= 1024.0)
                size = String.Format("{0:##.##}", bytes / 1024.0) + "kb";
            else if (bytes > 0 && bytes < 1024.0)
                size = bytes.ToString() + "bytes";

            return size;
        }
    }
}
