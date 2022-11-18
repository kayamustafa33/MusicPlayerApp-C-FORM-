namespace Music_Player
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SettingsBtnClicked = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.SearchBtnClicked = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.HomeBtnClicked = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelSlider = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.panel1.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.siticonePanel2);
            this.panel1.Controls.Add(this.siticonePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 761);
            this.panel1.TabIndex = 0;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Location = new System.Drawing.Point(196, 0);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(985, 761);
            this.siticonePanel2.TabIndex = 1;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.SettingsBtnClicked);
            this.siticonePanel1.Controls.Add(this.SearchBtnClicked);
            this.siticonePanel1.Controls.Add(this.HomeBtnClicked);
            this.siticonePanel1.Controls.Add(this.label8);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.siticonePanel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 56);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(200, 638);
            this.siticonePanel1.TabIndex = 8;
            // 
            // SettingsBtnClicked
            // 
            this.SettingsBtnClicked.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SettingsBtnClicked.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.SettingsBtnClicked.Image = ((System.Drawing.Image)(resources.GetObject("SettingsBtnClicked.Image")));
            this.SettingsBtnClicked.ImageOffset = new System.Drawing.Point(0, 0);
            this.SettingsBtnClicked.ImageRotate = 0F;
            this.SettingsBtnClicked.ImageSize = new System.Drawing.Size(30, 30);
            this.SettingsBtnClicked.Location = new System.Drawing.Point(12, 158);
            this.SettingsBtnClicked.Name = "SettingsBtnClicked";
            this.SettingsBtnClicked.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SettingsBtnClicked.Size = new System.Drawing.Size(60, 60);
            this.SettingsBtnClicked.TabIndex = 10;
            this.SettingsBtnClicked.Click += new System.EventHandler(this.SettingsBtnClicked_Click);
            // 
            // SearchBtnClicked
            // 
            this.SearchBtnClicked.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SearchBtnClicked.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.SearchBtnClicked.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtnClicked.Image")));
            this.SearchBtnClicked.ImageOffset = new System.Drawing.Point(0, 0);
            this.SearchBtnClicked.ImageRotate = 0F;
            this.SearchBtnClicked.ImageSize = new System.Drawing.Size(30, 30);
            this.SearchBtnClicked.Location = new System.Drawing.Point(12, 92);
            this.SearchBtnClicked.Name = "SearchBtnClicked";
            this.SearchBtnClicked.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SearchBtnClicked.Size = new System.Drawing.Size(60, 60);
            this.SearchBtnClicked.TabIndex = 9;
            this.SearchBtnClicked.Click += new System.EventHandler(this.SearchBtnClicked_Click);
            // 
            // HomeBtnClicked
            // 
            this.HomeBtnClicked.AnimatedGIF = true;
            this.HomeBtnClicked.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.HomeBtnClicked.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.HomeBtnClicked.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtnClicked.Image")));
            this.HomeBtnClicked.ImageOffset = new System.Drawing.Point(0, 0);
            this.HomeBtnClicked.ImageRotate = 0F;
            this.HomeBtnClicked.ImageSize = new System.Drawing.Size(30, 30);
            this.HomeBtnClicked.Location = new System.Drawing.Point(12, 26);
            this.HomeBtnClicked.Name = "HomeBtnClicked";
            this.HomeBtnClicked.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.HomeBtnClicked.Size = new System.Drawing.Size(60, 60);
            this.HomeBtnClicked.TabIndex = 8;
            this.HomeBtnClicked.Click += new System.EventHandler(this.HomeBtnClicked_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(78, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Home Page";
            // 
            // PanelSlider
            // 
            this.PanelSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.PanelSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSlider.Location = new System.Drawing.Point(200, 0);
            this.PanelSlider.Name = "PanelSlider";
            this.PanelSlider.Size = new System.Drawing.Size(984, 761);
            this.PanelSlider.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.PanelSlider);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Music Player";
            this.panel1.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Label label2;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel PanelSlider;
        private Label label8;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton HomeBtnClicked;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton SearchBtnClicked;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton SettingsBtnClicked;
    }
}