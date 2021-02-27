
namespace EOF_Compress_Hider
{
    partial class Option
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.outerOption_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.innerOptionButton_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.init_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.innerOption_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.password_groupBox = new System.Windows.Forms.GroupBox();
            this.showPassword_checkBox = new System.Windows.Forms.CheckBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.password_confirm_textBox = new System.Windows.Forms.TextBox();
            this.compressLevel_groupBox = new System.Windows.Forms.GroupBox();
            this.compressLevel_comboBox = new System.Windows.Forms.ComboBox();
            this.overwrite_groupBox = new System.Windows.Forms.GroupBox();
            this.warning_label = new System.Windows.Forms.Label();
            this.overwrite_checkBox = new System.Windows.Forms.CheckBox();
            this.encryptionMethod_groupBox = new System.Windows.Forms.GroupBox();
            this.encryptionMethod_comboBox = new System.Windows.Forms.ComboBox();
            this.outerOption_tableLayoutPanel.SuspendLayout();
            this.innerOptionButton_tableLayoutPanel.SuspendLayout();
            this.innerOption_tableLayoutPanel.SuspendLayout();
            this.password_groupBox.SuspendLayout();
            this.compressLevel_groupBox.SuspendLayout();
            this.overwrite_groupBox.SuspendLayout();
            this.encryptionMethod_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // outerOption_tableLayoutPanel
            // 
            this.outerOption_tableLayoutPanel.ColumnCount = 1;
            this.outerOption_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outerOption_tableLayoutPanel.Controls.Add(this.innerOptionButton_tableLayoutPanel, 0, 1);
            this.outerOption_tableLayoutPanel.Controls.Add(this.innerOption_tableLayoutPanel, 0, 0);
            this.outerOption_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerOption_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.outerOption_tableLayoutPanel.Name = "outerOption_tableLayoutPanel";
            this.outerOption_tableLayoutPanel.RowCount = 2;
            this.outerOption_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.outerOption_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.outerOption_tableLayoutPanel.Size = new System.Drawing.Size(541, 424);
            this.outerOption_tableLayoutPanel.TabIndex = 0;
            // 
            // innerOptionButton_tableLayoutPanel
            // 
            this.innerOptionButton_tableLayoutPanel.ColumnCount = 4;
            this.innerOptionButton_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.innerOptionButton_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.innerOptionButton_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.innerOptionButton_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.innerOptionButton_tableLayoutPanel.Controls.Add(this.init_button, 1, 0);
            this.innerOptionButton_tableLayoutPanel.Controls.Add(this.ok_button, 2, 0);
            this.innerOptionButton_tableLayoutPanel.Controls.Add(this.cancel_button, 3, 0);
            this.innerOptionButton_tableLayoutPanel.Controls.Add(this.version, 0, 0);
            this.innerOptionButton_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerOptionButton_tableLayoutPanel.Location = new System.Drawing.Point(3, 384);
            this.innerOptionButton_tableLayoutPanel.Name = "innerOptionButton_tableLayoutPanel";
            this.innerOptionButton_tableLayoutPanel.RowCount = 1;
            this.innerOptionButton_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.innerOptionButton_tableLayoutPanel.Size = new System.Drawing.Size(535, 37);
            this.innerOptionButton_tableLayoutPanel.TabIndex = 1;
            // 
            // init_button
            // 
            this.init_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.init_button.Location = new System.Drawing.Point(217, 3);
            this.init_button.Name = "init_button";
            this.init_button.Size = new System.Drawing.Size(101, 31);
            this.init_button.TabIndex = 6;
            this.init_button.Text = "초기화";
            this.init_button.UseVisualStyleBackColor = true;
            this.init_button.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // ok_button
            // 
            this.ok_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ok_button.Location = new System.Drawing.Point(324, 3);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(101, 31);
            this.ok_button.TabIndex = 7;
            this.ok_button.Text = "확인";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancel_button.Location = new System.Drawing.Point(431, 3);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(101, 31);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "취소";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.version.Location = new System.Drawing.Point(3, 25);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(208, 12);
            this.version.TabIndex = 12;
            this.version.Text = "ver.1";
            // 
            // innerOption_tableLayoutPanel
            // 
            this.innerOption_tableLayoutPanel.ColumnCount = 3;
            this.innerOption_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.innerOption_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.innerOption_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.innerOption_tableLayoutPanel.Controls.Add(this.password_groupBox, 1, 2);
            this.innerOption_tableLayoutPanel.Controls.Add(this.compressLevel_groupBox, 1, 1);
            this.innerOption_tableLayoutPanel.Controls.Add(this.overwrite_groupBox, 1, 0);
            this.innerOption_tableLayoutPanel.Controls.Add(this.encryptionMethod_groupBox, 1, 3);
            this.innerOption_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerOption_tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.innerOption_tableLayoutPanel.Name = "innerOption_tableLayoutPanel";
            this.innerOption_tableLayoutPanel.RowCount = 4;
            this.innerOption_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.innerOption_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.innerOption_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.innerOption_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.innerOption_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.innerOption_tableLayoutPanel.Size = new System.Drawing.Size(535, 375);
            this.innerOption_tableLayoutPanel.TabIndex = 0;
            // 
            // password_groupBox
            // 
            this.password_groupBox.Controls.Add(this.showPassword_checkBox);
            this.password_groupBox.Controls.Add(this.password_textBox);
            this.password_groupBox.Controls.Add(this.password_confirm_textBox);
            this.password_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_groupBox.Location = new System.Drawing.Point(29, 190);
            this.password_groupBox.Name = "password_groupBox";
            this.password_groupBox.Size = new System.Drawing.Size(475, 111);
            this.password_groupBox.TabIndex = 2;
            this.password_groupBox.TabStop = false;
            this.password_groupBox.Text = "압축 암호 입력/재입력";
            // 
            // showPassword_checkBox
            // 
            this.showPassword_checkBox.AutoSize = true;
            this.showPassword_checkBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.showPassword_checkBox.Location = new System.Drawing.Point(384, 17);
            this.showPassword_checkBox.Name = "showPassword_checkBox";
            this.showPassword_checkBox.Size = new System.Drawing.Size(88, 49);
            this.showPassword_checkBox.TabIndex = 4;
            this.showPassword_checkBox.Text = "암호 보이기";
            this.showPassword_checkBox.UseVisualStyleBackColor = true;
            this.showPassword_checkBox.CheckedChanged += new System.EventHandler(this.showPassword_checkBox_CheckedChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.password_textBox.Location = new System.Drawing.Point(3, 66);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(469, 21);
            this.password_textBox.TabIndex = 2;
            // 
            // password_confirm_textBox
            // 
            this.password_confirm_textBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.password_confirm_textBox.Location = new System.Drawing.Point(3, 87);
            this.password_confirm_textBox.Name = "password_confirm_textBox";
            this.password_confirm_textBox.PasswordChar = '*';
            this.password_confirm_textBox.Size = new System.Drawing.Size(469, 21);
            this.password_confirm_textBox.TabIndex = 3;
            this.password_confirm_textBox.TextChanged += new System.EventHandler(this.usePassword_TextChanged);
            // 
            // compressLevel_groupBox
            // 
            this.compressLevel_groupBox.Controls.Add(this.compressLevel_comboBox);
            this.compressLevel_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compressLevel_groupBox.Location = new System.Drawing.Point(29, 120);
            this.compressLevel_groupBox.Name = "compressLevel_groupBox";
            this.compressLevel_groupBox.Size = new System.Drawing.Size(475, 64);
            this.compressLevel_groupBox.TabIndex = 1;
            this.compressLevel_groupBox.TabStop = false;
            this.compressLevel_groupBox.Text = "압축 레벨";
            // 
            // compressLevel_comboBox
            // 
            this.compressLevel_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compressLevel_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compressLevel_comboBox.FormattingEnabled = true;
            this.compressLevel_comboBox.Location = new System.Drawing.Point(3, 17);
            this.compressLevel_comboBox.Name = "compressLevel_comboBox";
            this.compressLevel_comboBox.Size = new System.Drawing.Size(469, 20);
            this.compressLevel_comboBox.TabIndex = 1;
            // 
            // overwrite_groupBox
            // 
            this.overwrite_groupBox.Controls.Add(this.warning_label);
            this.overwrite_groupBox.Controls.Add(this.overwrite_checkBox);
            this.overwrite_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overwrite_groupBox.Location = new System.Drawing.Point(29, 3);
            this.overwrite_groupBox.Name = "overwrite_groupBox";
            this.overwrite_groupBox.Size = new System.Drawing.Size(475, 111);
            this.overwrite_groupBox.TabIndex = 0;
            this.overwrite_groupBox.TabStop = false;
            // 
            // warning_label
            // 
            this.warning_label.AutoSize = true;
            this.warning_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.warning_label.Location = new System.Drawing.Point(3, 33);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(281, 12);
            this.warning_label.TabIndex = 3;
            this.warning_label.Text = "주의 : 기존 커버 이미지 파일이 손상될 수 있습니다";
            // 
            // overwrite_checkBox
            // 
            this.overwrite_checkBox.AutoSize = true;
            this.overwrite_checkBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.overwrite_checkBox.Location = new System.Drawing.Point(3, 17);
            this.overwrite_checkBox.Name = "overwrite_checkBox";
            this.overwrite_checkBox.Size = new System.Drawing.Size(469, 16);
            this.overwrite_checkBox.TabIndex = 0;
            this.overwrite_checkBox.Text = "생성 시 기존 커버 이미지 파일에 덮어쓰기";
            this.overwrite_checkBox.UseVisualStyleBackColor = true;
            // 
            // encryptionMethod_groupBox
            // 
            this.encryptionMethod_groupBox.Controls.Add(this.encryptionMethod_comboBox);
            this.encryptionMethod_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptionMethod_groupBox.Location = new System.Drawing.Point(29, 307);
            this.encryptionMethod_groupBox.Name = "encryptionMethod_groupBox";
            this.encryptionMethod_groupBox.Size = new System.Drawing.Size(475, 65);
            this.encryptionMethod_groupBox.TabIndex = 3;
            this.encryptionMethod_groupBox.TabStop = false;
            this.encryptionMethod_groupBox.Text = "압축 암호화 방식";
            // 
            // encryptionMethod_comboBox
            // 
            this.encryptionMethod_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptionMethod_comboBox.Enabled = false;
            this.encryptionMethod_comboBox.FormattingEnabled = true;
            this.encryptionMethod_comboBox.Location = new System.Drawing.Point(3, 17);
            this.encryptionMethod_comboBox.Name = "encryptionMethod_comboBox";
            this.encryptionMethod_comboBox.Size = new System.Drawing.Size(469, 20);
            this.encryptionMethod_comboBox.TabIndex = 5;
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 424);
            this.Controls.Add(this.outerOption_tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "옵션";
            this.Load += new System.EventHandler(this.Option_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Option_KeyDown);
            this.outerOption_tableLayoutPanel.ResumeLayout(false);
            this.innerOptionButton_tableLayoutPanel.ResumeLayout(false);
            this.innerOptionButton_tableLayoutPanel.PerformLayout();
            this.innerOption_tableLayoutPanel.ResumeLayout(false);
            this.password_groupBox.ResumeLayout(false);
            this.password_groupBox.PerformLayout();
            this.compressLevel_groupBox.ResumeLayout(false);
            this.overwrite_groupBox.ResumeLayout(false);
            this.overwrite_groupBox.PerformLayout();
            this.encryptionMethod_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel outerOption_tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel innerOptionButton_tableLayoutPanel;
        private System.Windows.Forms.Button init_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TableLayoutPanel innerOption_tableLayoutPanel;
        private System.Windows.Forms.CheckBox overwrite_checkBox;
        private System.Windows.Forms.ComboBox compressLevel_comboBox;
        private System.Windows.Forms.GroupBox compressLevel_groupBox;
        private System.Windows.Forms.GroupBox overwrite_groupBox;
        private System.Windows.Forms.Label warning_label;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.GroupBox password_groupBox;
        private System.Windows.Forms.CheckBox showPassword_checkBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox password_confirm_textBox;
        private System.Windows.Forms.GroupBox encryptionMethod_groupBox;
        private System.Windows.Forms.ComboBox encryptionMethod_comboBox;
    }
}