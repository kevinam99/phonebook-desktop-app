namespace phonebook_manager_cs
{
    partial class OptionsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SourceCode_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Exit_button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F);
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an option";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.button1.Location = new System.Drawing.Point(116, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create a new contact";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.button2.Location = new System.Drawing.Point(116, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search and update a contact";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.button3.Location = new System.Drawing.Point(116, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete a contact";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SourceCode_linkLabel1
            // 
            this.SourceCode_linkLabel1.AutoSize = true;
            this.SourceCode_linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.SourceCode_linkLabel1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.SourceCode_linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.SourceCode_linkLabel1.Location = new System.Drawing.Point(407, 264);
            this.SourceCode_linkLabel1.Name = "SourceCode_linkLabel1";
            this.SourceCode_linkLabel1.Size = new System.Drawing.Size(84, 15);
            this.SourceCode_linkLabel1.TabIndex = 22;
            this.SourceCode_linkLabel1.TabStop = true;
            this.SourceCode_linkLabel1.Text = "Source code";
            this.SourceCode_linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceCode_linkLabel1_LinkClicked);
            // 
            // Exit_button4
            // 
            this.Exit_button4.BackColor = System.Drawing.Color.Transparent;
            this.Exit_button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit_button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Exit_button4.Location = new System.Drawing.Point(302, 260);
            this.Exit_button4.Name = "Exit_button4";
            this.Exit_button4.Size = new System.Drawing.Size(77, 28);
            this.Exit_button4.TabIndex = 14;
            this.Exit_button4.Text = "Exit";
            this.Exit_button4.UseVisualStyleBackColor = false;
            this.Exit_button4.Click += new System.EventHandler(this.Exit_button4_Click);
            // 
            // OptionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 298);
            this.Controls.Add(this.Exit_button4);
            this.Controls.Add(this.SourceCode_linkLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsScreen_FormClosing);
            this.Load += new System.EventHandler(this.OptionsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel SourceCode_linkLabel1;
        private System.Windows.Forms.Button Exit_button4;
    }
}