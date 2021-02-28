using EOF_Compress_Hider.classes;
using Microsoft.WindowsAPICodePack.Dialogs; //CommonOpenFileDialog
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace EOF_Compress_Hider
{
    public partial class Main : Form
    {
        #region
        /***
            EOFCompressHider는 작업 수행 중 로그 기록을 위한 LogManager 접근 위해 메인 폼을 참조
            LogManager는 직접적인 로그 기록을 위한 메인 폼의 컨트롤 접근 위해 메인 폼을 참조
            OptionValues는 메인 폼과 옵션 폼간의 데이터 공유를 위해 옵션 폼에서 메인 폼을 참조
        ***/
        public EOFCompressHider _compHider;
        public OptionValues _optionValues;
        public LogManager _logManager;
        #endregion

        #region 메인 폼 이벤트 처리 위한 변수
        private bool _titleBarMouseClicked = false; //타이틀바 마우스 클릭 여부
        private Point _mainFormCurrentPos; //메인 폼 현재 위치
        #endregion

        public Main()
        {
            InitializeComponent();
            this.Font = new Font(FontLibrary.Families[0], 8);

            /*** Init ***/
            this._logManager = new LogManager(this);
            this._compHider = new EOFCompressHider(this);
            this._optionValues = new OptionValues();
            
            this._logManager.UpdateLog("Ready", Predef.LogMode.APPEND);
        }

        #region 타이틀바 이벤트 처리
        private void help_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("작업 완료 된 출력 파일은 확장자를 .zip으로 변경 후 상용 압축 해제 프로그램을 사용하여 열 수 있습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void titleBar_panel_MouseDown(object sender, MouseEventArgs e) //타이틀바 마우스 단추 클릭
        {
            _titleBarMouseClicked = true;
            _mainFormCurrentPos = new Point(e.X, e.Y); //마우스 단추 클릭 시 메인 폼의 현재 위치 저장 
        }

        private void titleBar_panel_MouseMove(object sender, MouseEventArgs e) //타이틀바 위에서 마우스 이동
        {
            if (_titleBarMouseClicked && (e.Button == MouseButtons.Left)) //마우스 왼쪽 단추 클릭시에만 이동
            {
                this.Location = new Point(this.Left - (_mainFormCurrentPos.X - e.X), this.Top - (_mainFormCurrentPos.Y - e.Y));
            }
        }

        private void titleBar_panel_MouseUp(object sender, MouseEventArgs e) //타이틀바 마우스 단추 클릭 해제
        {
            _titleBarMouseClicked = false; //클릭 해제 시 이동하지 않음
        }
        #endregion

        #region 메인 폼 중간 버튼들 이벤트 처리
        private void select_coverImg_button_Click(object sender, EventArgs e) //커버 이미지 지정 버튼 클릭
        {
            if (coverImg_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                /*** 기존 데이터 모두 초기화 ***/
                coverImg_textBox.Clear();
                coverImg_textBox.Text = coverImg_openFileDialog.FileName;
            }
        }

        private void select_srcFile_button_Click(object sender, EventArgs e) //숨기기 위한 파일 지정 버튼 클릭
        {
            CommonOpenFileDialog fileDlg = new CommonOpenFileDialog();
            fileDlg.Multiselect = true;
            fileDlg.IsFolderPicker = false;

            if (fileDlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                /*** Append 위하여 기존 데이터 모두 초기화 ***/
                this.target_textBox.ResetText();
                
                foreach(string fileName in fileDlg.FileNames)
                {
                    this.target_textBox.Text += fileName + Environment.NewLine;
                }
            }
        }
        private void select_srcFolder_button_Click(object sender, EventArgs e) //숨기기 위한 폴더 지정 버튼 클릭
        {
            CommonOpenFileDialog fileDlg = new CommonOpenFileDialog();
            fileDlg.IsFolderPicker = true;

            if (fileDlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                this.target_textBox.Text = fileDlg.FileName;
            }
        }

        private void select_dst_button_Click(object sender, EventArgs e) //출력 파일 선택 버튼 클릭
        {
            if (this.target_saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.output_textBox.Text = target_saveFileDialog.FileName;
            }
        }
        #endregion

        #region 메인 폼 하단 버튼들 이벤트 처리
        private void gen_button_Click(object sender, EventArgs e) //생성 버튼 클릭
        {
            this._compHider.Init();
            /*
            if (this.coverImg_textBox.Text == string.Empty || this.target_textBox.Text == string.Empty || this.output_textBox.Text == string.Empty) //모든 데이터가 입력되었는지 확인
            {
                MessageBox.Show("미 입력된 데이터가 존재합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Path.GetExtension(this.coverImg_textBox.Text) !=
                Path.GetExtension(this.output_textBox.Text)) //원본 확장자와 출력 확장자가 다를 경우
            {
                DialogResult result = MessageBox.Show("커버로 사용 할 이미지 파일과 출력 파일의 확장자가 다릅니다. 계속 하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("yes");
                        break;

                    case DialogResult.No:
                        MessageBox.Show("no");
                        break;
                }
            }
            */

            /*** 이미 파일 처리 작업 중일 시 생성 버튼 중복 클릭 차단 ***/
            switch (_compHider.CurrentFileIOState)
            {
                case Predef.FileIOState.WORKING:
                    MessageBox.Show("처리 중 입니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                default:
                    break;
            }
           
            /***
                전달 위한 다수의 파라미터를 개체로 다시 묶지 않으면서 전달을 위해 
                ParameterizedThreadStart를 사용하지 않고
                메서드 안에서 다른 메서드를 호출하여 수행
            ***/
            Thread worker = new Thread(() => this._compHider.Generate(this._optionValues, this.coverImg_textBox.Text, this.target_textBox.Text, this.output_textBox.Text));
            worker.IsBackground = true;
            worker.Start(); //Background 작업 스레드 시작

            //스레드 예외 caft
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

            /*** 기존 커버 이미지에 덮어쓰기 시 출력 파일 지정 텍스트박스와 선택 버튼 비활성화 ***/
            switch (this._optionValues.OverwriteCurrentImage)
            {
                case true:
                    if (this.output_textBox.Visible)
                        this.output_textBox.Visible = false;

                    if (this.select_output_button.Visible)
                        this.select_output_button.Visible = false;

                    break;

                case false:
                    if (!this.output_textBox.Visible)
                        this.output_textBox.Visible = true;

                    if (!this.select_output_button.Visible)
                        this.select_output_button.Visible = true;

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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}
