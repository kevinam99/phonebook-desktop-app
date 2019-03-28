namespace phonebook_manager_cs
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Subtitle = new System.Windows.Forms.Label();
            this.Ssubtitle = new System.Windows.Forms.Label();
            this.AvailableOn = new System.Windows.Forms.Label();
            this.GitHub = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Font = new System.Drawing.Font("Century Gothic", 27.75F);
            this.Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Welcome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Welcome.Location = new System.Drawing.Point(56, 234);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(703, 44);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome to The Phonebook Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.BackColor = System.Drawing.Color.Transparent;
            this.Subtitle.Location = new System.Drawing.Point(430, 321);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(35, 13);
            this.Subtitle.TabIndex = 3;
            this.Subtitle.Text = "label3";
            // 
            // Ssubtitle
            // 
            this.Ssubtitle.AutoSize = true;
            this.Ssubtitle.BackColor = System.Drawing.Color.Transparent;
            this.Ssubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Ssubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Ssubtitle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ssubtitle.Location = new System.Drawing.Point(394, 312);
            this.Ssubtitle.Name = "Ssubtitle";
            this.Ssubtitle.Size = new System.Drawing.Size(365, 25);
            this.Ssubtitle.TabIndex = 1;
            this.Ssubtitle.Text = "- A FOSS Project by Kevin A Mathew";
            this.Ssubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Ssubtitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // AvailableOn
            // 
            this.AvailableOn.AutoSize = true;
            this.AvailableOn.BackColor = System.Drawing.Color.Transparent;
            this.AvailableOn.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.AvailableOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AvailableOn.Location = new System.Drawing.Point(548, 354);
            this.AvailableOn.Name = "AvailableOn";
            this.AvailableOn.Size = new System.Drawing.Size(131, 28);
            this.AvailableOn.TabIndex = 3;
            this.AvailableOn.Text = "Available on";
            // 
            // GitHub
            // 
            this.GitHub.ActiveLinkColor = System.Drawing.Color.Black;
            this.GitHub.AutoSize = true;
            this.GitHub.BackColor = System.Drawing.Color.Transparent;
            this.GitHub.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic);
            this.GitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GitHub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GitHub.Location = new System.Drawing.Point(680, 354);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(79, 28);
            this.GitHub.TabIndex = 2;
            this.GitHub.TabStop = true;
            this.GitHub.Text = "GitHub";
            this.GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHub_LinkClicked);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.Location = new System.Drawing.Point(192, 430);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(458, 10);
            this.progressBar1.Step = 7;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.GitHub);
            this.Controls.Add(this.AvailableOn);
            this.Controls.Add(this.Ssubtitle);
            this.Controls.Add(this.Subtitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook Manager";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.Label Ssubtitle;
        private System.Windows.Forms.Label AvailableOn;
        private System.Windows.Forms.LinkLabel GitHub;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Timer timer1;
    }
}

