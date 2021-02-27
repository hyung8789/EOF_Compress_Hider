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
        public void Update_Log(string srcData, Predef.LogMode srcLogMode) //로그 업데이트
        {
            int latestItemIndex = 0; //마지막으로 추가된 항목의 인덱스

            switch (srcLogMode)
            {
                case Predef.LogMode.APPEND:
                    if (_main.log_ListBox.InvokeRequired) //호출한 스레드가 작업 스레드인 경우
                    {
                        _main.log_ListBox.BeginInvoke(new Action(() => _main.log_ListBox.Items.Add(srcData))); //비동기식으로 수행
                    }
                    else //UI 스레드인 경우
                    {
                        _main.log_ListBox.Items.Add(srcData);
                    }

                    //새로 추가 된 항목에 따라 인덱스 계산 후 스크롤 다운
                    //latestItemIndex = logger.Items.Count - 1;
                    // logger.SetSelected(latestItemIndex, true);

                    break;

                case Predef.LogMode.OVERWRITE:
                    //마지막으로 추가 된 항목을 제거하고 새로 추가
                    latestItemIndex = _main.log_ListBox.Items.Count - 1;

                    if (_main.log_ListBox.InvokeRequired) //호출한 스레드가 작업 스레드인 경우
                    {
                        _main.log_ListBox.BeginInvoke(new Action(() => _main.log_ListBox.Items.RemoveAt(latestItemIndex)));
                        _main.log_ListBox.BeginInvoke(new Action(() => _main.log_ListBox.Text = srcData)); //비동기식으로 logger 텍스트 변경
                    }
                    else //UI 스레드인 경우
                    {
                        _main.log_ListBox.Items.RemoveAt(latestItemIndex);
                        _main.log_ListBox.Items.Add(srcData);
                    }

                    break;
            }
        }
        #endregion
    }
}
