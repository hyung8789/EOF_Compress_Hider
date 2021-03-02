﻿
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
            this.innerMain_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.log_groupBox = new System.Windows.Forms.GroupBox();
            this.log_ListBox = new System.Windows.Forms.ListBox();
            this.innerMainControl_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.coverImg_textBox = new System.Windows.Forms.TextBox();
            this.output_textBox = new System.Windows.Forms.TextBox();
            this.output_button = new System.Windows.Forms.Button();
            this.target_button = new System.Windows.Forms.Button();
            this.target_textBox = new System.Windows.Forms.TextBox();
            this.coverImg_button = new System.Windows.Forms.Button();
            this.innerMainButton_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.exit_button = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.LinkLabel();
            this.option_button = new System.Windows.Forms.Button();
            this.gen_button = new System.Windows.Forms.Button();
            this.titleBar_panel = new System.Windows.Forms.Panel();
            this.help_button = new System.Windows.Forms.Button();
            this.minimize_button = new System.Windows.Forms.Button();
            this.coverImg_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.target_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.logo = new System.Windows.Forms.PictureBox();
            this.outerMain_LayoutPanel.SuspendLayout();
            this.innerMain_tableLayoutPanel.SuspendLayout();
            this.log_groupBox.SuspendLayout();
            this.innerMainControl_tableLayoutPanel.SuspendLayout();
            this.innerMainButton_tableLayoutPanel.SuspendLayout();
            this.titleBar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // outerMain_LayoutPanel
            // 
            this.outerMain_LayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.outerMain_LayoutPanel.ColumnCount = 1;
            this.outerMain_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outerMain_LayoutPanel.Controls.Add(this.innerMain_tableLayoutPanel, 0, 2);
            this.outerMain_LayoutPanel.Controls.Add(this.logo, 0, 1);
            this.outerMain_LayoutPanel.Controls.Add(this.innerMainButton_tableLayoutPanel, 0, 3);
            this.outerMain_LayoutPanel.Controls.Add(this.titleBar_panel, 0, 0);
            this.outerMain_LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerMain_LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.outerMain_LayoutPanel.Name = "outerMain_LayoutPanel";
            this.outerMain_LayoutPanel.RowCount = 4;
            this.outerMain_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.outerMain_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.outerMain_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.outerMain_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.outerMain_LayoutPanel.Size = new System.Drawing.Size(511, 458);
            this.outerMain_LayoutPanel.TabIndex = 0;
            // 
            // innerMain_tableLayoutPanel
            // 
            this.innerMain_tableLayoutPanel.ColumnCount = 1;
            this.innerMain_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.innerMain_tableLayoutPanel.Controls.Add(this.log_groupBox, 0, 1);
            this.innerMain_tableLayoutPanel.Controls.Add(this.innerMainControl_tableLayoutPanel, 0, 0);
            this.innerMain_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerMain_tableLayoutPanel.Location = new System.Drawing.Point(4, 95);
            this.innerMain_tableLayoutPanel.Name = "innerMain_tableLayoutPanel";
            this.innerMain_tableLayoutPanel.RowCount = 2;
            this.innerMain_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.innerMain_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.innerMain_tableLayoutPanel.Size = new System.Drawing.Size(503, 250);
            this.innerMain_tableLayoutPanel.TabIndex = 2;
            // 
            // log_groupBox
            // 
            this.log_groupBox.Controls.Add(this.log_ListBox);
            this.log_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_groupBox.ForeColor = System.Drawing.Color.White;
            this.log_groupBox.Location = new System.Drawing.Point(3, 153);
            this.log_groupBox.Name = "log_groupBox";
            this.log_groupBox.Size = new System.Drawing.Size(497, 94);
            this.log_groupBox.TabIndex = 2;
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
            this.log_ListBox.ItemHeight = 12;
            this.log_ListBox.Location = new System.Drawing.Point(3, 17);
            this.log_ListBox.Name = "log_ListBox";
            this.log_ListBox.ScrollAlwaysVisible = true;
            this.log_ListBox.Size = new System.Drawing.Size(491, 74);
            this.log_ListBox.TabIndex = 0;
            this.log_ListBox.TabStop = false;
            // 
            // innerMainControl_tableLayoutPanel
            // 
            this.innerMainControl_tableLayoutPanel.ColumnCount = 2;
            this.innerMainControl_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.innerMainControl_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.innerMainControl_tableLayoutPanel.Controls.Add(this.coverImg_textBox, 0, 0);
            this.innerMainControl_tableLayoutPanel.Controls.Add(this.output_textBox, 0, 2);
            this.innerMainControl_tableLayoutPanel.Controls.Add(this.output_button, 1, 2);
            this.innerMainControl_tableLayoutPanel.Controls.Add(this.target_button, 1, 1);
            this.innerMainControl_tableLayoutPanel.Controls.Add(this.target_textBox, 0, 1);
            this.innerMainControl_tableLayoutPanel.Controls.Add(this.coverImg_button, 1, 0);
            this.innerMainControl_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerMainControl_tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.innerMainControl_tableLayoutPanel.Name = "innerMainControl_tableLayoutPanel";
            this.innerMainControl_tableLayoutPanel.RowCount = 3;
            this.innerMainControl_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.innerMainControl_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.innerMainControl_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.innerMainControl_tableLayoutPanel.Size = new System.Drawing.Size(497, 144);
            this.innerMainControl_tableLayoutPanel.TabIndex = 0;
            // 
            // coverImg_textBox
            // 
            this.coverImg_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coverImg_textBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.coverImg_textBox.Location = new System.Drawing.Point(5, 5);
            this.coverImg_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.coverImg_textBox.Name = "coverImg_textBox";
            this.coverImg_textBox.ReadOnly = true;
            this.coverImg_textBox.Size = new System.Drawing.Size(437, 21);
            this.coverImg_textBox.TabIndex = 7;
            this.coverImg_textBox.TabStop = false;
            this.coverImg_textBox.Text = "커버로 사용 할 이미지 지정";
            // 
            // output_textBox
            // 
            this.output_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_textBox.Location = new System.Drawing.Point(5, 113);
            this.output_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.output_textBox.Name = "output_textBox";
            this.output_textBox.ReadOnly = true;
            this.output_textBox.Size = new System.Drawing.Size(437, 21);
            this.output_textBox.TabIndex = 8;
            this.output_textBox.TabStop = false;
            this.output_textBox.Text = "출력 파일 지정";
            // 
            // output_button
            // 
            this.output_button.BackColor = System.Drawing.Color.Black;
            this.output_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.output_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.output_button.ForeColor = System.Drawing.Color.White;
            this.output_button.Location = new System.Drawing.Point(452, 113);
            this.output_button.Margin = new System.Windows.Forms.Padding(5);
            this.output_button.Name = "output_button";
            this.output_button.Size = new System.Drawing.Size(40, 26);
            this.output_button.TabIndex = 4;
            this.output_button.TabStop = false;
            this.output_button.Text = "...";
            this.output_button.UseVisualStyleBackColor = false;
            this.output_button.Click += new System.EventHandler(this.output_button_Click);
            // 
            // target_button
            // 
            this.target_button.BackColor = System.Drawing.Color.Black;
            this.target_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.target_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.target_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.target_button.ForeColor = System.Drawing.Color.White;
            this.target_button.Location = new System.Drawing.Point(452, 41);
            this.target_button.Margin = new System.Windows.Forms.Padding(5);
            this.target_button.Name = "target_button";
            this.target_button.Size = new System.Drawing.Size(40, 62);
            this.target_button.TabIndex = 3;
            this.target_button.TabStop = false;
            this.target_button.Text = "...";
            this.target_button.UseVisualStyleBackColor = false;
            this.target_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.target_button_MouseClick);
            // 
            // target_textBox
            // 
            this.target_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.target_textBox.Location = new System.Drawing.Point(5, 41);
            this.target_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.target_textBox.Multiline = true;
            this.target_textBox.Name = "target_textBox";
            this.target_textBox.ReadOnly = true;
            this.target_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.target_textBox.Size = new System.Drawing.Size(437, 62);
            this.target_textBox.TabIndex = 9;
            this.target_textBox.TabStop = false;
            this.target_textBox.Text = "숨기기 위한 파일들 혹은 폴더 지정";
            this.target_textBox.WordWrap = false;
            // 
            // coverImg_button
            // 
            this.coverImg_button.BackColor = System.Drawing.Color.Black;
            this.coverImg_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.coverImg_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coverImg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coverImg_button.ForeColor = System.Drawing.Color.White;
            this.coverImg_button.Location = new System.Drawing.Point(452, 5);
            this.coverImg_button.Margin = new System.Windows.Forms.Padding(5);
            this.coverImg_button.Name = "coverImg_button";
            this.coverImg_button.Size = new System.Drawing.Size(40, 26);
            this.coverImg_button.TabIndex = 2;
            this.coverImg_button.TabStop = false;
            this.coverImg_button.Text = "...";
            this.coverImg_button.UseVisualStyleBackColor = false;
            this.coverImg_button.Click += new System.EventHandler(this.coverImg_button_Click);
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
            this.innerMainButton_tableLayoutPanel.Location = new System.Drawing.Point(4, 352);
            this.innerMainButton_tableLayoutPanel.Name = "innerMainButton_tableLayoutPanel";
            this.innerMainButton_tableLayoutPanel.RowCount = 4;
            this.innerMainButton_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.innerMainButton_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.innerMainButton_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.innerMainButton_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.innerMainButton_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.innerMainButton_tableLayoutPanel.Size = new System.Drawing.Size(503, 102);
            this.innerMainButton_tableLayoutPanel.TabIndex = 2;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Black;
            this.exit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(3, 63);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(497, 24);
            this.exit_button.TabIndex = 7;
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
            this.about.Location = new System.Drawing.Point(324, 90);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(176, 12);
            this.about.TabIndex = 8;
            this.about.TabStop = true;
            this.about.Tag = "";
            this.about.Text = "https://github.com/hyung8789";
            this.about.VisitedLinkColor = System.Drawing.Color.White;
            this.about.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.about_LinkClicked);
            // 
            // option_button
            // 
            this.option_button.BackColor = System.Drawing.Color.Black;
            this.option_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.option_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option_button.ForeColor = System.Drawing.Color.White;
            this.option_button.Location = new System.Drawing.Point(3, 33);
            this.option_button.Name = "option_button";
            this.option_button.Size = new System.Drawing.Size(497, 24);
            this.option_button.TabIndex = 6;
            this.option_button.Text = "옵션";
            this.option_button.UseVisualStyleBackColor = false;
            this.option_button.Click += new System.EventHandler(this.option_button_Click);
            // 
            // gen_button
            // 
            this.gen_button.BackColor = System.Drawing.Color.Black;
            this.gen_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gen_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen_button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen_button.ForeColor = System.Drawing.Color.White;
            this.gen_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gen_button.Location = new System.Drawing.Point(3, 3);
            this.gen_button.Name = "gen_button";
            this.gen_button.Size = new System.Drawing.Size(497, 24);
            this.gen_button.TabIndex = 5;
            this.gen_button.Text = "Zip and Hide";
            this.gen_button.UseVisualStyleBackColor = false;
            this.gen_button.Click += new System.EventHandler(this.gen_button_Click);
            // 
            // titleBar_panel
            // 
            this.titleBar_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titleBar_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBar_panel.Controls.Add(this.help_button);
            this.titleBar_panel.Controls.Add(this.minimize_button);
            this.titleBar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBar_panel.Location = new System.Drawing.Point(4, 4);
            this.titleBar_panel.Name = "titleBar_panel";
            this.titleBar_panel.Size = new System.Drawing.Size(503, 19);
            this.titleBar_panel.TabIndex = 0;
            this.titleBar_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_panel_MouseDown);
            this.titleBar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_panel_MouseMove);
            this.titleBar_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_panel_MouseUp);
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.Black;
            this.help_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.help_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.help_button.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_button.Location = new System.Drawing.Point(461, 0);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(20, 17);
            this.help_button.TabIndex = 0;
            this.help_button.Text = "?";
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // minimize_button
            // 
            this.minimize_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.minimize_button.Location = new System.Drawing.Point(481, 0);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(20, 17);
            this.minimize_button.TabIndex = 1;
            this.minimize_button.Text = "-";
            this.minimize_button.UseVisualStyleBackColor = true;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // coverImg_openFileDialog
            // 
            this.coverImg_openFileDialog.Filter = resources.GetString("coverImg_openFileDialog.Filter");
            this.coverImg_openFileDialog.Title = "커버로 사용할 이미지 파일 지정";
            // 
            // target_saveFileDialog
            // 
            this.target_saveFileDialog.Filter = resources.GetString("target_saveFileDialog.Filter");
            this.target_saveFileDialog.Title = "출력 파일 지정";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Black;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::EOF_Compress_Hider.Properties.Resources.logo;
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(11, 37);
            this.logo.Margin = new System.Windows.Forms.Padding(10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(489, 44);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(511, 458);
            this.ControlBox = false;
            this.Controls.Add(this.outerMain_LayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EOF Compress Hider";
            this.outerMain_LayoutPanel.ResumeLayout(false);
            this.innerMain_tableLayoutPanel.ResumeLayout(false);
            this.log_groupBox.ResumeLayout(false);
            this.innerMainControl_tableLayoutPanel.ResumeLayout(false);
            this.innerMainControl_tableLayoutPanel.PerformLayout();
            this.innerMainButton_tableLayoutPanel.ResumeLayout(false);
            this.innerMainButton_tableLayoutPanel.PerformLayout();
            this.titleBar_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel outerMain_LayoutPanel;
        private System.Windows.Forms.OpenFileDialog coverImg_openFileDialog;
        private System.Windows.Forms.SaveFileDialog target_saveFileDialog;
        private System.Windows.Forms.TableLayoutPanel innerMainButton_tableLayoutPanel;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.LinkLabel about;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel titleBar_panel;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Button option_button;
        private System.Windows.Forms.Button gen_button;
        private System.Windows.Forms.TableLayoutPanel innerMain_tableLayoutPanel;
        private System.Windows.Forms.GroupBox log_groupBox;
        public System.Windows.Forms.ListBox log_ListBox;
        private System.Windows.Forms.TableLayoutPanel innerMainControl_tableLayoutPanel;
        private System.Windows.Forms.TextBox coverImg_textBox;
        private System.Windows.Forms.Button coverImg_button;
        private System.Windows.Forms.TextBox target_textBox;
        private System.Windows.Forms.TextBox output_textBox;
        private System.Windows.Forms.Button output_button;
        private System.Windows.Forms.Button target_button;
    }
}

