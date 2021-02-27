using EOF_Compress_Hider.classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EOF_Compress_Hider
{
    public partial class Option : Form
    {
        public Main _main;

        public Option()
        {
            InitializeComponent();
        }

        public Option(Main srcMain)
        {
            InitializeComponent();
            _main = srcMain; //옵션 데이터를 위해 메인 폼 참조

            this.Font = new Font(FontLibrary.Families[0], 8);

            /*** 콤보박스 데이터 초기화 ***/
            this.compressLevel_comboBox.Items.AddRange(Predef.CompressLevelData); 
            foreach(object item in Enum.GetValues(typeof(Predef.EncryptionMethod)))
            {
                this.encryptionMethod_comboBox.Items.Add(item);
            }
        }

        private void Option_Load(object sender, EventArgs e) //폼 로드 시 수행
        {
            /*** 메인 폼의 기존 데이터로부터 불러오기 ***/
            this.overwrite_checkBox.Checked = _main._optionValues.OverwriteCurrentImage;

            switch (_main._optionValues.CompressLevel)
            {
                case Predef.CompressLevel.LOW:
                    this.compressLevel_comboBox.SelectedIndex = 0;
                    break;

                case Predef.CompressLevel.MID:
                    this.compressLevel_comboBox.SelectedIndex = 1;
                    break;

                case Predef.CompressLevel.HIGH:
                    this.compressLevel_comboBox.SelectedIndex = 2;
                    break;
            }

            this.encryptionMethod_comboBox.SelectedIndex = (int)_main._optionValues.EncryptionMethod;

            this.password_textBox.Text = this.password_confirm_textBox.Text = _main._optionValues.Password;
        }

        private void btnInit_Click(object sender, EventArgs e) //초기화 버튼 클릭
        {
            _main._optionValues.Init();
            this.Option_Load(sender, e);
        }

        private void btnOk_Click(object sender, EventArgs e) //확인 버튼 클릭
        {
            /*** 옵션 값들 저장 후 종료 ***/
            _main._optionValues.OverwriteCurrentImage = this.overwrite_checkBox.Checked;

            switch (this.compressLevel_comboBox.SelectedIndex)
            {
                case 0:
                    _main._optionValues.CompressLevel = Predef.CompressLevel.LOW;
                    break;

                case 1:
                    _main._optionValues.CompressLevel = Predef.CompressLevel.MID;
                    break;

                case 2:
                    _main._optionValues.CompressLevel = Predef.CompressLevel.HIGH;
                    break;
            }

            if (this.password_textBox.Text != this.password_confirm_textBox.Text)
                MessageBox.Show("압축 암호와 재입력 암축 암호가 다릅니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _main._optionValues.Password = this.password_textBox.Text;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) //취소 버튼 클릭
        {
            this.Close();
        }

        private void showPassword_checkBox_CheckedChanged(object sender, EventArgs e) //압축 암호 보이기/숨기기 체크박스 변경
        {
            switch(showPassword_checkBox.Checked)
            {
                case true:
                    password_textBox.PasswordChar = password_confirm_textBox.PasswordChar = (char)0;
                    break;

                case false:
                    password_textBox.PasswordChar = password_confirm_textBox.PasswordChar = '*';
                    break;
            }
           
        }

        private void Option_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void usePassword_TextChanged(object sender, EventArgs e)
        {
            if(this.password_textBox.Text != string.Empty &&
                this.password_confirm_textBox.Text != string.Empty)
            {
                if (this.password_textBox.Text == this.password_confirm_textBox.Text)
                    this.encryptionMethod_comboBox.Enabled = true;
            }
        }
    }
}