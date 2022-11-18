namespace Music_Player
{
    partial class HomePage
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.profileButton = new Guna.UI2.WinForms.Guna2Button();
            this.timeText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.likedSongsClicked = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.newMusicClicked = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.hotHitsClicked = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.HomePanelSlider = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneImageButton1 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.siticoneProgressBar1 = new Siticone.Desktop.UI.WinForms.SiticoneProgressBar();
            this.siticoneImageButton2 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.siticoneImageButton3 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.siticoneImageButton4 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.HomePanelSlider.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileButton
            // 
            this.profileButton.Animated = true;
            this.profileButton.AnimatedGIF = true;
            this.profileButton.BorderRadius = 20;
            this.profileButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.profileButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.profileButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.profileButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.profileButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.profileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileButton.ForeColor = System.Drawing.Color.White;
            this.profileButton.Location = new System.Drawing.Point(780, 29);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(180, 45);
            this.profileButton.TabIndex = 17;
            this.profileButton.Text = "Profile";
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeText.ForeColor = System.Drawing.Color.White;
            this.timeText.Location = new System.Drawing.Point(18, 37);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(205, 37);
            this.timeText.TabIndex = 14;
            this.timeText.Text = "Good Morning";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(119, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 30);
            this.label5.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(3, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 1);
            this.panel2.TabIndex = 19;
            // 
            // likedSongsClicked
            // 
            this.likedSongsClicked.Animated = true;
            this.likedSongsClicked.BackColor = System.Drawing.Color.Transparent;
            this.likedSongsClicked.BorderRadius = 20;
            this.likedSongsClicked.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.likedSongsClicked.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.likedSongsClicked.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.likedSongsClicked.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.likedSongsClicked.FillColor = System.Drawing.Color.Bisque;
            this.likedSongsClicked.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.likedSongsClicked.ForeColor = System.Drawing.Color.Black;
            this.likedSongsClicked.Image = ((System.Drawing.Image)(resources.GetObject("likedSongsClicked.Image")));
            this.likedSongsClicked.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.likedSongsClicked.ImageSize = new System.Drawing.Size(70, 70);
            this.likedSongsClicked.Location = new System.Drawing.Point(18, 106);
            this.likedSongsClicked.Name = "likedSongsClicked";
            this.likedSongsClicked.Size = new System.Drawing.Size(300, 100);
            this.likedSongsClicked.TabIndex = 20;
            this.likedSongsClicked.Text = "Liked Songs";
            this.likedSongsClicked.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.likedSongsClicked.TextOffset = new System.Drawing.Point(-10, 0);
            this.likedSongsClicked.UseTransparentBackground = true;
            this.likedSongsClicked.Click += new System.EventHandler(this.likedSongsClicked_Click);
            // 
            // newMusicClicked
            // 
            this.newMusicClicked.Animated = true;
            this.newMusicClicked.BackColor = System.Drawing.Color.Transparent;
            this.newMusicClicked.BorderRadius = 20;
            this.newMusicClicked.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.newMusicClicked.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.newMusicClicked.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.newMusicClicked.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.newMusicClicked.FillColor = System.Drawing.Color.Orange;
            this.newMusicClicked.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newMusicClicked.ForeColor = System.Drawing.Color.Black;
            this.newMusicClicked.Image = ((System.Drawing.Image)(resources.GetObject("newMusicClicked.Image")));
            this.newMusicClicked.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.newMusicClicked.ImageSize = new System.Drawing.Size(70, 70);
            this.newMusicClicked.Location = new System.Drawing.Point(338, 106);
            this.newMusicClicked.Name = "newMusicClicked";
            this.newMusicClicked.Size = new System.Drawing.Size(300, 100);
            this.newMusicClicked.TabIndex = 21;
            this.newMusicClicked.Text = "New Musics";
            this.newMusicClicked.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.newMusicClicked.TextOffset = new System.Drawing.Point(-10, 0);
            this.newMusicClicked.UseTransparentBackground = true;
            this.newMusicClicked.Click += new System.EventHandler(this.newMusicClicked_Click);
            // 
            // hotHitsClicked
            // 
            this.hotHitsClicked.Animated = true;
            this.hotHitsClicked.BackColor = System.Drawing.Color.Transparent;
            this.hotHitsClicked.BorderRadius = 20;
            this.hotHitsClicked.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hotHitsClicked.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hotHitsClicked.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hotHitsClicked.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hotHitsClicked.FillColor = System.Drawing.Color.GreenYellow;
            this.hotHitsClicked.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hotHitsClicked.ForeColor = System.Drawing.Color.Black;
            this.hotHitsClicked.Image = ((System.Drawing.Image)(resources.GetObject("hotHitsClicked.Image")));
            this.hotHitsClicked.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.hotHitsClicked.ImageSize = new System.Drawing.Size(70, 70);
            this.hotHitsClicked.Location = new System.Drawing.Point(660, 106);
            this.hotHitsClicked.Name = "hotHitsClicked";
            this.hotHitsClicked.Size = new System.Drawing.Size(300, 100);
            this.hotHitsClicked.TabIndex = 22;
            this.hotHitsClicked.Text = "Hot Hits Turkey";
            this.hotHitsClicked.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hotHitsClicked.TextOffset = new System.Drawing.Point(-10, 0);
            this.hotHitsClicked.UseTransparentBackground = true;
            this.hotHitsClicked.Click += new System.EventHandler(this.hotHitsClicked_Click);
            // 
            // HomePanelSlider
            // 
            this.HomePanelSlider.Controls.Add(this.siticonePanel1);
            this.HomePanelSlider.Location = new System.Drawing.Point(0, 219);
            this.HomePanelSlider.Name = "HomePanelSlider";
            this.HomePanelSlider.Size = new System.Drawing.Size(984, 542);
            this.HomePanelSlider.TabIndex = 23;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Black;
            this.siticonePanel1.Controls.Add(this.siticoneImageButton4);
            this.siticonePanel1.Controls.Add(this.siticoneImageButton3);
            this.siticonePanel1.Controls.Add(this.siticoneImageButton2);
            this.siticonePanel1.Controls.Add(this.siticoneProgressBar1);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel2);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel1);
            this.siticonePanel1.Controls.Add(this.siticoneImageButton1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 442);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(984, 100);
            this.siticonePanel1.TabIndex = 3;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(167, 56);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(94, 23);
            this.siticoneHtmlLabel2.TabIndex = 3;
            this.siticoneHtmlLabel2.Text = "Singer Name";
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(167, 15);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(90, 23);
            this.siticoneHtmlLabel1.TabIndex = 2;
            this.siticoneHtmlLabel1.Text = "Music Name";
            // 
            // siticoneImageButton1
            // 
            this.siticoneImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticoneImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneImageButton1.Image")));
            this.siticoneImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.siticoneImageButton1.ImageRotate = 0F;
            this.siticoneImageButton1.Location = new System.Drawing.Point(0, 0);
            this.siticoneImageButton1.Name = "siticoneImageButton1";
            this.siticoneImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton1.Size = new System.Drawing.Size(161, 100);
            this.siticoneImageButton1.TabIndex = 1;
            // 
            // siticoneProgressBar1
            // 
            this.siticoneProgressBar1.Location = new System.Drawing.Point(360, 69);
            this.siticoneProgressBar1.Name = "siticoneProgressBar1";
            this.siticoneProgressBar1.Size = new System.Drawing.Size(600, 10);
            this.siticoneProgressBar1.TabIndex = 4;
            this.siticoneProgressBar1.Text = "siticoneProgressBar1";
            this.siticoneProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // siticoneImageButton2
            // 
            this.siticoneImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneImageButton2.Image")));
            this.siticoneImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.siticoneImageButton2.ImageRotate = 0F;
            this.siticoneImageButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.siticoneImageButton2.Location = new System.Drawing.Point(631, 14);
            this.siticoneImageButton2.Name = "siticoneImageButton2";
            this.siticoneImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton2.Size = new System.Drawing.Size(50, 50);
            this.siticoneImageButton2.TabIndex = 5;
            // 
            // siticoneImageButton3
            // 
            this.siticoneImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton3.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("siticoneImageButton3.Image")));
            this.siticoneImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.siticoneImageButton3.ImageRotate = 0F;
            this.siticoneImageButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.siticoneImageButton3.Location = new System.Drawing.Point(587, 14);
            this.siticoneImageButton3.Name = "siticoneImageButton3";
            this.siticoneImageButton3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton3.Size = new System.Drawing.Size(50, 50);
            this.siticoneImageButton3.TabIndex = 6;
            // 
            // siticoneImageButton4
            // 
            this.siticoneImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton4.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("siticoneImageButton4.Image")));
            this.siticoneImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.siticoneImageButton4.ImageRotate = 0F;
            this.siticoneImageButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.siticoneImageButton4.Location = new System.Drawing.Point(675, 15);
            this.siticoneImageButton4.Name = "siticoneImageButton4";
            this.siticoneImageButton4.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton4.Size = new System.Drawing.Size(50, 50);
            this.siticoneImageButton4.TabIndex = 7;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.HomePanelSlider);
            this.Controls.Add(this.hotHitsClicked);
            this.Controls.Add(this.newMusicClicked);
            this.Controls.Add(this.likedSongsClicked);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeText);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(984, 761);
            this.HomePanelSlider.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button profileButton;
        private Label timeText;
        private Label label5;
        private Panel panel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton likedSongsClicked;
        private Siticone.Desktop.UI.WinForms.SiticoneButton newMusicClicked;
        private Siticone.Desktop.UI.WinForms.SiticoneButton hotHitsClicked;
        private Siticone.Desktop.UI.WinForms.SiticonePanel HomePanelSlider;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton siticoneImageButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton siticoneImageButton4;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton siticoneImageButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton siticoneImageButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneProgressBar siticoneProgressBar1;
    }
}
