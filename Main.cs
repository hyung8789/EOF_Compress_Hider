using EOF_Compress_Hider.classes;
using Microsoft.WindowsAPICodePack.Dialogs; //CommonOpenFileDialog
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EOF_Compress_Hider
{
    public partial class Main : Form
    {
        #region 주 개체
        /***
            EOFCompressHider는 OptionValues와 작업 수행 중 로그 기록을 위한 LogManager 접근 위해 메인 폼을 참조
            LogManager는 직접적인 로그 기록을 위한 메인 폼의 컨트롤 접근 위해 메인 폼을 참조
            OptionValues는 메인 폼과 옵션 폼간의 데이터 공유를 위해 옵션 폼에서 메인 폼을 참조
        ***/
        public EOFCompressHider _compHider;
        public OptionValues _optionValues;
        public LogManager _logManager;
        #endregion

        #region 메인 폼 이벤트 처리 위한 변수
        /***
            메인 폼의 커버 이미지 텍스트 박스, 타켓 텍스트 박스, 출력 텍스트 박스에 대하여
            초기 비어있지 않고, 설명을 위한 텍스트가 존재하므로, string.Empty로 데이터가 미 입력되었는지 판별하지 않고,
            아래 bool값으로 판별한다.
            ---
            만약, 사용자가 옵션에서 기존 커버 이미지에 덮어쓰기를 체크 할 시 기존 출력 텍스트 박스의 내용은 모두 string.Empty로 초기화하고,
            해당 bool값은 true로 초기화 한다.
        ***/
        public bool _coverImgInitValue;
        public bool _targetInitValue;
        public bool _outputInitValue;

        private bool _titleBarMouseClicked = false; //타이틀바 마우스 클릭 여부
        private Point _mainFormCurrentPos; //메인 폼 현재 위치
        #endregion

        public Main()
        {
            InitializeComponent();
            this.Font = new Font(FontLibrary.Families[0], 9);

            /*** Init ***/
            this._coverImgInitValue = this._targetInitValue = this._outputInitValue = true;

            this._logManager = new LogManager(this);
            this._compHider = new EOFCompressHider(this);
            this._optionValues = new OptionValues();

            this._logManager.UpdateLog("Ready", Predef.LogMode.APPEND);
            this.log_ListBox.SetSelected(0, false);
        }

        #region 타이틀바 이벤트 처리
        private void help_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- 커버 이미지 : 정상적인 이미지 파일로 위장하기 위해 겉으로 보여지는 이미지 파일을 지정한다." + Environment.NewLine + Environment.NewLine +
                "- 숨기기 위한 파일들 혹은 폴더 (이하, Target) : 커버 이미지 내부에 숨기기 위한 파일들 혹은 폴더를 지정한다." + Environment.NewLine + Environment.NewLine +
                "- 출력 파일 : 커버 이미지와 Target으로부터 생성 된 출력 파일로서, 일반적인 이미지 파일처럼 보이지만, " +
                "출력 파일 확장자를 .zip으로 변경하고 상용 압축 해제 유틸리티에서 오픈 시 Target 파일들에 접근 할 수 있다. ", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void titleBar_panel_MouseDown(object sender, MouseEventArgs e) //타이틀바 마우스 단추 클릭
        {
            this._titleBarMouseClicked = true;
            this._mainFormCurrentPos = new Point(e.X, e.Y); //마우스 단추 클릭 시 메인 폼의 현재 위치 저장 
        }

        private void titleBar_panel_MouseMove(object sender, MouseEventArgs e) //타이틀바 위에서 마우스 이동
        {
            if (this._titleBarMouseClicked && (e.Button == MouseButtons.Left)) //마우스 왼쪽 단추 클릭시에만 이동
            {
                this.Location = new Point(this.Left - (this._mainFormCurrentPos.X - e.X), this.Top - (this._mainFormCurrentPos.Y - e.Y));
            }
        }

        private void titleBar_panel_MouseUp(object sender, MouseEventArgs e) //타이틀바 마우스 단추 클릭 해제
        {
            this._titleBarMouseClicked = false; //클릭 해제 시 이동하지 않음
        }
        #endregion

        #region 메인 폼 중간 버튼들 이벤트 처리
        private void coverImg_button_Click(object sender, EventArgs e) //커버 이미지 버튼 클릭
        {
            /*** 이미 파일 처리 작업 중일 시 클릭 차단 ***/
            switch (this._compHider.CurrentFileIOState)
            {
                case Predef.FileIOState.WORKING:
                    MessageBox.Show("처리 중 입니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                default:
                    break;
            }

            if (this.coverImg_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                /*** 기존 데이터 모두 초기화 ***/
                this.coverImg_textBox.Clear();
                this.coverImg_textBox.Text = this.coverImg_openFileDialog.FileName;

                this._coverImgInitValue = false; //데이터가 할당 되었음을 알림
            }
        }

        private void target_button_MouseClick(object sender, MouseEventArgs e) //타겟 버튼 클릭
        {
            if (e.Button == MouseButtons.Left)
            {
                target_button.ContextMenu = new ContextMenu();
                target_button.ContextMenu.MenuItems.Add("파일 선택", targetFile_button_onClick);
                target_button.ContextMenu.MenuItems.Add("폴더 선택", targetDirectory_button_onClick);
                target_button.ContextMenu.Show(target_button, new Point(e.X, e.Y));
            }
        }

        private void targetFile_button_onClick(object sender, EventArgs e) //타겟 파일 선택 버튼 클릭
        {
            /*** 이미 파일 처리 작업 중일 시 클릭 차단 ***/
            switch (_compHider.CurrentFileIOState)
            {
                case Predef.FileIOState.WORKING:
                    MessageBox.Show("처리 중 입니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                default:
                    break;
            }

            CommonOpenFileDialog fileDlg = new CommonOpenFileDialog();
            fileDlg.Multiselect = true;
            fileDlg.IsFolderPicker = false;

            if (fileDlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                /*** Append 위하여 기존 데이터 모두 초기화 ***/
                this.target_textBox.ResetText();

                _compHider._totalFileCount = Enumerable.Count(fileDlg.FileNames);
                int currentFileIndex = 0;
                foreach (string fileName in fileDlg.FileNames)
                {
                    currentFileIndex++;

                    if (currentFileIndex < _compHider._totalFileCount)
                        this.target_textBox.Text += fileName + Environment.NewLine;
                    else
                        this.target_textBox.Text += fileName;
                }

                _compHider._targetType = Predef.TargetType.FILE;
                this._targetInitValue = false; //데이터가 할당 되었음을 알림
            }
        }
        private void targetDirectory_button_onClick(object sender, EventArgs e) //타겟 폴더 선택 버튼 클릭
        {
            /*** 이미 파일 처리 작업 중일 시 클릭 차단 ***/
            switch (_compHider.CurrentFileIOState)
            {
                case Predef.FileIOState.WORKING:
                    MessageBox.Show("처리 중 입니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                default:
                    break;
            }

            CommonOpenFileDialog fileDlg = new CommonOpenFileDialog();
            fileDlg.IsFolderPicker = true;

            if (fileDlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(fileDlg.FileName);
                _compHider._totalFileCount = dirInfo.GetFiles("*.*", SearchOption.AllDirectories).Length;

                this.target_textBox.Text = fileDlg.FileName;

                _compHider._targetType = Predef.TargetType.DIRECTORY;
                this._targetInitValue = false; //데이터가 할당 되었음을 알림
            }
        }

        private void output_button_Click(object sender, EventArgs e) //출력 파일 버튼 클릭
        {
            /*** 이미 파일 처리 작업 중일 시 클릭 차단 ***/
            switch (_compHider.CurrentFileIOState)
            {
                case Predef.FileIOState.WORKING:
                    MessageBox.Show("처리 중 입니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                default:
                    break;
            }

            if (this.target_saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.output_textBox.Text = target_saveFileDialog.FileName;

                this._outputInitValue = false; //데이터가 할당 되었음을 알림
            }
        }
        #endregion

        #region 메인 폼 하단 버튼들 이벤트 처리
        private void gen_button_Click(object sender, EventArgs e) //생성 버튼 클릭
        {
            /*** this._compHider.Generate(string, string, string) 내부에서도 받은 파라미터 데이터에 대하여 자체적으로 검사하지만, 만약을 대비하여 모든 데이터가 입력되었는지 검사 ***/
            bool PathEntered = true;
            if (this._coverImgInitValue || this._targetInitValue || this._outputInitValue)
                PathEntered = false;
            if (!this._optionValues.OverwriteCurrentCoverImage && this._outputInitValue) //기존 커버 이미지에 덮어쓰기 옵션이 활성화 되어 있을 경우, 출력 경로는 무시
                PathEntered = false;
            if (!PathEntered)
            {
                MessageBox.Show("미 입력된 데이터가 존재합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*** 이미 파일 처리 작업 중일 시 클릭 차단 ***/
            switch (_compHider.CurrentFileIOState)
            {
                case Predef.FileIOState.WORKING:
                    MessageBox.Show("처리 중 입니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                default:
                    break;
            }

            if (!this._optionValues.OverwriteCurrentCoverImage) //기존 커버 이미지에 덮어쓰기 옵션이 비활성화 되어 있을 경우에만 확장자 검사
            {
                if (Path.GetExtension(this.coverImg_textBox.Text) != Path.GetExtension(this.output_textBox.Text)) //원본 확장자와 출력 확장자가 다를 경우
                {
                    DialogResult result = MessageBox.Show("커버로 사용 할 이미지 파일과 출력 파일의 확장자가 다릅니다. 계속 하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            break;

                        case DialogResult.No:
                            return;
                    }
                }
            }

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork); //실제 수행 할 작업
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted); //작업 완료 시 발생
            worker.RunWorkerAsync();

            /* 삭제 : 백그라운드 스레드에 대한 예외 처리를 위하여 BackgroundWorker로 변경
            전달 위한 다수의 파라미터를 개체로 다시 묶지 않으면서 전달을 위해 
            ParameterizedThreadStart를 사용하지 않고
            메서드 안에서 다른 메서드를 호출하여 수행
            Thread worker = new Thread(() => this._compHider.Generate(this.coverImg_textBox.Text, this.target_textBox.Text, this.output_textBox.Text));
            worker.IsBackground = true;
            worker.Start();
            //worker.Join();
            */
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            this._compHider.Generate(this.coverImg_textBox.Text, this.target_textBox.Text, this.output_textBox.Text);
        }
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) //비동기 작업 중 발생한 오류가 존재 시
            {
                MessageBox.Show(e.Error.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._compHider.Init();
        }
        private void option_button_Click(object sender, EventArgs e) //옵션 버튼 클릭
        {
            /*** 파일 처리 작업 중 옵션 메뉴 진입 차단 ***/
            switch (_compHider.CurrentFileIOState)
            {
                case Predef.FileIOState.WORKING:
                    MessageBox.Show("작업 중 옵션 진입 불가", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                default:
                    break;
            }

            Option optionForm = new Option(this);
            optionForm.ShowDialog();

            /*** 기존 커버 이미지에 덮어쓰기 시 출력 파일 지정 텍스트 박스와 선택 버튼 활성화 여부 및 데이터 조정 ***/
            switch (this._optionValues.OverwriteCurrentCoverImage)
            {
                case true: //기존 커버 이미지에 덮어쓰므로, 출력 파일 관련 컨트롤 비활성화 및 기존 데이터 초기화
                    if (this.output_textBox.Visible)
                        this.output_textBox.Visible = false;

                    if (this.output_button.Visible)
                        this.output_button.Visible = false;

                    this._outputInitValue = true;
                    this.output_textBox.Text = string.Empty;

                    break;

                case false:
                    if (!this.output_textBox.Visible)
                        this.output_textBox.Visible = true;

                    if (!this.output_button.Visible)
                        this.output_button.Visible = true;

                    break;
            }
        }

        private void exit_button_Click(object sender, EventArgs e) //종료 버튼 클릭
        {
            switch (this._compHider.CurrentFileIOState)
            {
                case Predef.FileIOState.WORKING:
                    DialogResult result = MessageBox.Show("데이터가 손상 될 수 있습니다. 작업을 취소하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                        break;
                    return;

                default:
                    break;
            }

            this.Close();
        }

        private void about_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/hyung8789");
        }
        #endregion
    }
}
