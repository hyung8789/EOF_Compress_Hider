using System;

namespace EOF_Compress_Hider.classes
{
    public class LogManager
    {
        #region public:
        public Main _main;
        public LogManager(Main srcMain)
        {
            this._main = srcMain; //직접적인 로그 작업 수행 위해 메인 폼 참조
        }
       
        public void UpdateLog(string srcData, Predef.LogMode srcLogMode) //로그 업데이트
        {
            switch (srcLogMode)
            {
                case Predef.LogMode.APPEND: //새로 추가
                    if (_main.log_ListBox.InvokeRequired) //호출한 스레드가 작업 스레드인 경우 비동기식으로 수행
                    {
                        _main.log_ListBox.BeginInvoke(new Action(() => _main.log_ListBox.Items.Add(srcData)));
                        _main.log_ListBox.BeginInvoke(new Action(() => _main.log_ListBox.SetSelected(_main.log_ListBox.Items.Count - 1, true))); //새로 추가 된 항목으로 스크롤 다운
                    }
                    else //UI 스레드인 경우
                    {
                        _main.log_ListBox.Items.Add(srcData);
                        _main.log_ListBox.SetSelected(_main.log_ListBox.Items.Count - 1, true); //새로 추가 된 항목으로 스크롤 다운
                    }

                    break;

                case Predef.LogMode.OVERWRITE: //마지막으로 추가 된 항목 수정
                    if (_main.log_ListBox.InvokeRequired) //호출한 스레드가 작업 스레드인 경우 비동기식으로 수행
                    {
                        _main.log_ListBox.BeginInvoke(new Action(() => _main.log_ListBox.Items[_main.log_ListBox.Items.Count - 1] = srcData));
                    }
                    else //UI 스레드인 경우
                    {
                        _main.log_ListBox.Items[_main.log_ListBox.Items.Count - 1] = srcData;
                    }

                    break;
            }
        }
        #endregion
    }
}