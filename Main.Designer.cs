
namespace EOF_Compress_Hider
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.outerMain_LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.innerMainButton_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.exit_button = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.LinkLabel();
            this.option_button = new System.Windows.Forms.Button();
            this.gen_button = new System.Windows.Forms.Button();
            this.innerMain_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.coverImg_textBox = new System.Windows.Forms.TextBox();
            this.select_coverImg_button = new System.Windows.Forms.Button();
            this.target_textBox = new System.Windows.Forms.TextBox();
            this.target_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.select_targetFolder_button = new System.Windows.Forms.Button();
            this.select_targetFile_button = new System.Windows.Forms.Button();
            this.output_textBox = new System.Windows.Forms.TextBox();
            this.select_output_button = new System.Windows.Forms.Button();
            this.log_groupBox = new System.Windows.Forms.GroupBox();
            this.log_ListBox = new System.Windows.Forms.ListBox();
            this.titleBar_panel = new System.Windows.Forms.Panel();
            this.help_button = new System.Windows.Forms.Button();
            this.minimize_button = new System.Windows.Forms.Button();
            this.coverImg_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.target_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.outerMain_LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.innerMainButton_tableLayoutPanel.SuspendLayout();
            this.innerMain_flowLayoutPanel.SuspendLayout();
            this.target_tableLayoutPanel.SuspendLayout();
            this.log_groupBox.SuspendLayout();
            this.titleBar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // outerMain_LayoutPanel
            // 
            this.outerMain_LayoutPanel.AutoSize = true;
            this.outerMain_LayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.outerMain_LayoutPanel.ColumnCount = 1;
            this.outerMain_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.outerMain_LayoutPanel.Controls.Add(this.logo, 0, 1);
            this.outerMain_LayoutPanel.Controls.Add(this.innerMainButton_tableLayoutPanel, 0, 3);
            this.outerMain_LayoutPanel.Controls.Add(this.innerMain_flowLayoutPanel, 0, 2);
            this.outerMain_LayoutPanel.Controls.Add(this.titleBar_panel, 0, 0);
            this.outerMain_LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerMain_LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.outerMain_LayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outerMain_LayoutPanel.Name = "outerMain_LayoutPanel";
            this.outerMain_LayoutPanel.RowCount = 4;
            this.outerMain_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.outerMain_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.outerMain_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.outerMain_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.outerMain_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.outerMain_LayoutPanel.Size = new System.Drawing.Size(678, 518);
            this.outerMain_LayoutPanel.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Black;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::EOF_Compress_Hider.Properties.Resources.logo;
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(24, 58);
            this.logo.Margin = new System.Windows.Forms.Padding(23, 25, 23, 25);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(630, 46);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // innerMainButton_tableLayoutPanel
            // 
            this.innerMainButton_tableLayoutPanel.ColumnCount = 1;
            this.innerMainButton_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.innerMainButton_tableLayoutPanel.Controls.Add(this.exit_button, 0, 2);
            this.innerMainButton_tableLayoutPanel.Controls.Add(this.about, 0, 3);
            this.innerMainButton_tableLayoutPanel.Controls.Add(this.option_button, 0, 1);
            this.innerMainButton_tableLayoutPanel.Controls.Add(this.gen_button, 0, 0);
            this.innerMainButton_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerMainButton_tableLayoutPanel.Location = new System.Drawing.Point(4, 376);
            this.innerMainButton_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.innerMainButton_tableLayoutPanel.Name = "innerMainButton_tableLayoutPanel";
            this.innerMainButton_tableLayoutPanel.RowCount = 4;
            this.innerMainButton_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.innerMainButton_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.innerMainButton_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.innerMainButton_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.innerMainButton_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.innerMainButton_tableLayoutPanel.Size = new System.Drawing.Size(670, 137);
            this.innerMainButton_tableLayoutPanel.TabIndex = 2;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Black;
            this.exit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(3, 86);
            this.exit_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(664, 33);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "종료";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.CausesValidation = false;
            this.about.Dock = System.Windows.Forms.DockStyle.Right;
            this.about.LinkColor = System.Drawing.Color.White;
            this.about.Location = new System.Drawing.Point(461, 123);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(206, 14);
            this.about.TabIndex = 9;
            this.about.TabStop = true;
            this.about.Tag = "";
            this.about.Text = "https://github.com/hyung8789";
            this.about.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // option_button
            // 
            this.option_button.BackColor = System.Drawing.Color.Black;
            this.option_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.option_button.ForeColor = System.Drawing.Color.White;
            this.option_button.Location = new System.Drawing.Point(3, 45);
            this.option_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.option_button.Name = "option_button";
            this.option_button.Size = new System.Drawing.Size(664, 33);
            this.option_button.TabIndex = 7;
            this.option_button.Text = "옵션";
            this.option_button.UseVisualStyleBackColor = false;
            this.option_button.Click += new System.EventHandler(this.option_button_Click);
            // 
            // gen_button
            // 
            this.gen_button.BackColor = System.Drawing.Color.Black;
            this.gen_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gen_button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen_button.ForeColor = System.Drawing.Color.White;
            this.gen_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gen_button.Location = new System.Drawing.Point(3, 4);
            this.gen_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gen_button.Name = "gen_button";
            this.gen_button.Size = new System.Drawing.Size(664, 33);
            this.gen_button.TabIndex = 6;
            this.gen_button.Text = "Zip and Hide";
            this.gen_button.UseVisualStyleBackColor = false;
            this.gen_button.Click += new System.EventHandler(this.gen_button_Click);
            // 
            // innerMain_flowLayoutPanel
            // 
            this.innerMain_flowLayoutPanel.Controls.Add(this.coverImg_textBox);
            this.innerMain_flowLayoutPanel.Controls.Add(this.select_coverImg_button);
            this.innerMain_flowLayoutPanel.Controls.Add(this.target_textBox);
            this.innerMain_flowLayoutPanel.Controls.Add(this.target_tableLayoutPanel);
            this.innerMain_flowLayoutPanel.Controls.Add(this.output_textBox);
            this.innerMain_flowLayoutPanel.Controls.Add(this.select_output_button);
            this.innerMain_flowLayoutPanel.Controls.Add(this.log_groupBox);
            this.innerMain_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerMain_flowLayoutPanel.Location = new System.Drawing.Point(4, 134);
            this.innerMain_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.innerMain_flowLayoutPanel.Name = "innerMain_flowLayoutPanel";
            this.innerMain_flowLayoutPanel.Size = new System.Drawing.Size(670, 233);
            this.innerMain_flowLayoutPanel.TabIndex = 1;
            // 
            // coverImg_textBox
            // 
            this.coverImg_textBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.coverImg_textBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.coverImg_textBox.Location = new System.Drawing.Point(6, 6);
            this.coverImg_textBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.coverImg_textBox.Name = "coverImg_textBox";
            this.coverImg_textBox.ReadOnly = true;
            this.coverImg_textBox.Size = new System.Drawing.Size(473, 25);
            this.coverImg_textBox.TabIndex = 0;
            this.coverImg_textBox.TabStop = false;
            // 
            // select_coverImg_button
            // 
            this.select_coverImg_button.BackColor = System.Drawing.Color.Black;
            this.select_coverImg_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.select_coverImg_button.ForeColor = System.Drawing.Color.White;
            this.select_coverImg_button.Location = new System.Drawing.Point(491, 6);
            this.select_coverImg_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.select_coverImg_button.Name = "select_coverImg_button";
            this.select_coverImg_button.Size = new System.Drawing.Size(166, 25);
            this.select_coverImg_button.TabIndex = 2;
            this.select_coverImg_button.Text = "File";
            this.select_coverImg_button.UseVisualStyleBackColor = false;
            this.select_coverImg_button.Click += new System.EventHandler(this.select_coverImg_button_Click);
            // 
            // target_textBox
            // 
            this.target_textBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.target_textBox.Location = new System.Drawing.Point(6, 43);
            this.target_textBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.target_textBox.Multiline = true;
            this.target_textBox.Name = "target_textBox";
            this.target_textBox.ReadOnly = true;
            this.target_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.target_textBox.Size = new System.Drawing.Size(473, 34);
            this.target_textBox.TabIndex = 0;
            this.target_textBox.TabStop = false;
            // 
            // target_tableLayoutPanel
            // 
            this.target_tableLayoutPanel.ColumnCount = 2;
            this.target_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.target_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.target_tableLayoutPanel.Controls.Add(this.select_targetFolder_button, 1, 0);
            this.target_tableLayoutPanel.Controls.Add(this.select_targetFile_button, 0, 0);
            this.target_tableLayoutPanel.Location = new System.Drawing.Point(488, 41);
            this.target_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.target_tableLayoutPanel.Name = "target_tableLayoutPanel";
            this.target_tableLayoutPanel.RowCount = 1;
            this.target_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.target_tableLayoutPanel.Size = new System.Drawing.Size(171, 38);
            this.target_tableLayoutPanel.TabIndex = 1;
            // 
            // select_targetFolder_button
            // 
            this.select_targetFolder_button.BackColor = System.Drawing.Color.Black;
            this.select_targetFolder_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.select_targetFolder_button.ForeColor = System.Drawing.Color.White;
            this.select_targetFolder_button.Location = new System.Drawing.Point(91, 6);
            this.select_targetFolder_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.select_targetFolder_button.Name = "select_targetFolder_button";
            this.select_targetFolder_button.Size = new System.Drawing.Size(74, 26);
            this.select_targetFolder_button.TabIndex = 4;
            this.select_targetFolder_button.Text = "Folder";
            this.select_targetFolder_button.UseVisualStyleBackColor = false;
            this.select_targetFolder_button.Click += new System.EventHandler(this.select_srcFolder_button_Click);
            // 
            // select_targetFile_button
            // 
            this.select_targetFile_button.BackColor = System.Drawing.Color.Black;
            this.select_targetFile_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.select_targetFile_button.ForeColor = System.Drawing.Color.White;
            this.select_targetFile_button.Location = new System.Drawing.Point(6, 6);
            this.select_targetFile_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.select_targetFile_button.Name = "select_targetFile_button";
            this.select_targetFile_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.select_targetFile_button.Size = new System.Drawing.Size(73, 26);
            this.select_targetFile_button.TabIndex = 3;
            this.select_targetFile_button.Text = "File";
            this.select_targetFile_button.UseVisualStyleBackColor = false;
            this.select_targetFile_button.Click += new System.EventHandler(this.select_srcFile_button_Click);
            // 
            // output_textBox
            // 
            this.output_textBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.output_textBox.Location = new System.Drawing.Point(6, 89);
            this.output_textBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.output_textBox.Name = "output_textBox";
            this.output_textBox.ReadOnly = true;
            this.output_textBox.Size = new System.Drawing.Size(473, 25);
            this.output_textBox.TabIndex = 0;
            this.output_textBox.TabStop = false;
            // 
            // select_output_button
            // 
            this.select_output_button.BackColor = System.Drawing.Color.Black;
            this.select_output_button.ForeColor = System.Drawing.Color.White;
            this.select_output_button.Location = new System.Drawing.Point(491, 89);
            this.select_output_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.select_output_button.Name = "select_output_button";
            this.select_output_button.Size = new System.Drawing.Size(166, 25);
            this.select_output_button.TabIndex = 5;
            this.select_output_button.Text = "File";
            this.select_output_button.UseVisualStyleBackColor = false;
            this.select_output_button.Click += new System.EventHandler(this.select_dst_button_Click);
            // 
            // log_groupBox
            // 
            this.log_groupBox.Controls.Add(this.log_ListBox);
            this.log_groupBox.ForeColor = System.Drawing.Color.White;
            this.log_groupBox.Location = new System.Drawing.Point(3, 124);
            this.log_groupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_groupBox.Name = "log_groupBox";
            this.log_groupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_groupBox.Size = new System.Drawing.Size(662, 110);
            this.log_groupBox.TabIndex = 0;
            this.log_groupBox.TabStop = false;
            this.log_groupBox.Text = "로그";
            // 
            // log_ListBox
            // 
            this.log_ListBox.BackColor = System.Drawing.Color.Black;
            this.log_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log_ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_ListBox.ForeColor = System.Drawing.Color.Lime;
            this.log_ListBox.FormattingEnabled = true;
            this.log_ListBox.ItemHeight = 15;
            this.log_ListBox.Location = new System.Drawing.Point(3, 22);
            this.log_ListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_ListBox.Name = "log_ListBox";
            this.log_ListBox.ScrollAlwaysVisible = true;
            this.log_ListBox.Size = new System.Drawing.Size(656, 84);
            this.log_ListBox.TabIndex = 0;
            this.log_ListBox.TabStop = false;
            // 
            // titleBar_panel
            // 
            this.titleBar_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titleBar_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBar_panel.Controls.Add(this.help_button);
            this.titleBar_panel.Controls.Add(this.minimize_button);
            this.titleBar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBar_panel.Location = new System.Drawing.Point(4, 5);
            this.titleBar_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleBar_panel.Name = "titleBar_panel";
            this.titleBar_panel.Size = new System.Drawing.Size(670, 23);
            this.titleBar_panel.TabIndex = 0;
            this.titleBar_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_panel_MouseDown);
            this.titleBar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_panel_MouseMove);
            this.titleBar_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_panel_MouseUp);
            // 
            // help_button
            // 
            this.help_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.help_button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_button.Location = new System.Drawing.Point(622, 0);
            this.help_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(23, 21);
            this.help_button.TabIndex = 0;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = true;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // minimize_button
            // 
            this.minimize_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_button.Location = new System.Drawing.Point(645, 0);
            this.minimize_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(23, 21);
            this.minimize_button.TabIndex = 1;
            this.minimize_button.Text = "-";
            this.minimize_button.UseVisualStyleBackColor = true;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // coverImg_openFileDialog
            // 
            this.coverImg_openFileDialog.Filter = "JPEG (*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|PNG (*.png)|*.png|BMP " +
    "(*.bmp,*.dib)|*.bmp;*.dib|GIF (*.gif)|*.gif";
            this.coverImg_openFileDialog.Title = "커버로 사용할 이미지 파일 지정";
            // 
            // target_saveFileDialog
            // 
            this.target_saveFileDialog.Filter = "JPEG (*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|PNG (*.png)|*.png|BMP " +
    "(*.bmp,*.dib)|*.bmp;*.dib|GIF (*.gif)|*.gif";
            this.target_saveFileDialog.Title = "출력 경로 지정";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(678, 518);
            this.ControlBox = false;
            this.Controls.Add(this.outerMain_LayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EOF Compress Hider";
            this.outerMain_LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.innerMainButton_tableLayoutPanel.ResumeLayout(false);
            this.innerMainButton_tableLayoutPanel.PerformLayout();
            this.innerMain_flowLayoutPanel.ResumeLayout(false);
            this.innerMain_flowLayoutPanel.PerformLayout();
            this.target_tableLayoutPanel.ResumeLayout(false);
            this.log_groupBox.ResumeLayout(false);
            this.titleBar_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel outerMain_LayoutPanel;
        private System.Windows.Forms.OpenFileDialog coverImg_openFileDialog;
        private System.Windows.Forms.SaveFileDialog target_saveFileDialog;
        private System.Windows.Forms.TableLayoutPanel innerMainButton_tableLayoutPanel;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.LinkLabel about;
        private System.Windows.Forms.Button option_button;
        private System.Windows.Forms.Button gen_button;
        private System.Windows.Forms.FlowLayoutPanel innerMain_flowLayoutPanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox coverImg_textBox;
        private System.Windows.Forms.Button select_coverImg_button;
        private System.Windows.Forms.TextBox target_textBox;
        private System.Windows.Forms.TextBox output_textBox;
        private System.Windows.Forms.Button select_output_button;
        private System.Windows.Forms.GroupBox log_groupBox;
        private System.Windows.Forms.TableLayoutPanel target_tableLayoutPanel;
        private System.Windows.Forms.Button select_targetFolder_button;
        private System.Windows.Forms.Button select_targetFile_button;
        private System.Windows.Forms.Panel titleBar_panel;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Button minimize_button;
        public System.Windows.Forms.ListBox log_ListBox;
    }
}

