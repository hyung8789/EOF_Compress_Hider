using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace EOF_Compress_Hider.classes
{
    class FontLibrary
    {
        #region public:
        public PrivateFontCollection _privateFont = new PrivateFontCollection();
        public static FontFamily[] Families
        {
            get
            {
                return _inst._privateFont.Families;
            }
        }

        public FontLibrary()
        {
            AddFontFromMemory();
        }
        #endregion

        #region private:
        private void AddFontFromMemory()
        {
            List<byte[]> fonts = new List<byte[]>();
            fonts.Add(Properties.Resources.D2Coding_Ver1_3_2_20180524_all1);

            foreach (byte[] font in fonts)
            {
                IntPtr fontBuffer = Marshal.AllocCoTaskMem(font.Length);
                Marshal.Copy(font, 0, fontBuffer, font.Length);
                _privateFont.AddMemoryFont(fontBuffer, font.Length);
            }
        }

        private static FontLibrary _inst = new FontLibrary();
        #endregion
    }
}
