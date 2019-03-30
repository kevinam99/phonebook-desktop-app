namespace phonebook_manager_cs
{
    partial class Delete_Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Contact));
            this.DeleteContactHeader_label1 = new System.Windows.Forms.Label();
            this.SourceCode_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CreateName_label1 = new System.Windows.Forms.Label();
            this.Search_button1 = new System.Windows.Forms.Button();
            this.Delete_button2 = new System.Windows.Forms.Button();
            this.Exit_button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteContactHeader_label1
            // 
            this.DeleteContactHeader_label1.AutoSize = true;
            this.DeleteContactHeader_label1.BackColor = System.Drawing.Color.Transparent;
            this.DeleteContactHeader_label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F);
            this.DeleteContactHeader_label1.Location = new System.Drawing.Point(193, 9);
            this.DeleteContactHeader_label1.Name = "DeleteContactHeader_label1";
            this.DeleteContactHeader_label1.Size = new System.Drawing.Size(200, 36);
            this.DeleteContactHeader_label1.TabIndex = 16;
            this.DeleteContactHeader_label1.Text = "Delete a contact";
            this.DeleteContactHeader_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SourceCode_linkLabel1
            // 
            this.SourceCode_linkLabel1.AutoSize = true;
            this.SourceCode_linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.SourceCode_linkLabel1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.SourceCode_linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.SourceCode_linkLabel1.Location = new System.Drawing.Point(469, 265);
            this.SourceCode_linkLabel1.Name = "SourceCode_linkLabel1";
            this.SourceCode_linkLabel1.Size = new System.Drawing.Size(84, 15);
            this.SourceCode_linkLabel1.TabIndex = 36;
            this.SourceCode_linkLabel1.TabStop = true;
            this.SourceCode_linkLabel1.Text = "Source code";
            this.SourceCode_linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceCode_linkLabel1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.textBox1.Location = new System.Drawing.Point(199, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 26);
            this.textBox1.TabIndex = 18;
            // 
            // CreateName_label1
            // 
            this.CreateName_label1.AutoSize = true;
            this.CreateName_label1.BackColor = System.Drawing.Color.Transparent;
            this.CreateName_label1.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.CreateName_label1.Location = new System.Drawing.Point(36, 76);
            this.CreateName_label1.Name = "CreateName_label1";
            this.CreateName_label1.Size = new System.Drawing.Size(66, 26);
            this.CreateName_label1.TabIndex = 34;
            this.CreateName_label1.Text = "Name";
            // 
            // Search_button1
            // 
            this.Search_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Search_button1.Location = new System.Drawing.Point(257, 108);
            this.Search_button1.Name = "Search_button1";
            this.Search_button1.Size = new System.Drawing.Size(129, 25);
            this.Search_button1.TabIndex = 37;
            this.Search_button1.Text = "Search";
            this.Search_button1.UseVisualStyleBackColor = true;
            // 
            // Delete_button2
            // 
            this.Delete_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Delete_button2.Location = new System.Drawing.Point(189, 184);
            this.Delete_button2.Name = "Delete_button2";
            this.Delete_button2.Size = new System.Drawing.Size(149, 33);
            this.Delete_button2.TabIndex = 22;
            this.Delete_button2.Text = "Delete contact";
            this.Delete_button2.UseVisualStyleBackColor = true;
            // 
            // Exit_button3
            // 
            this.Exit_button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Exit_button3.Location = new System.Drawing.Point(365, 184);
            this.Exit_button3.Name = "Exit_button3";
            this.Exit_button3.Size = new System.Drawing.Size(90, 33);
            this.Exit_button3.TabIndex = 20;
            this.Exit_button3.Text = "Exit";
            this.Exit_button3.UseVisualStyleBackColor = true;
            this.Exit_button3.Click += new System.EventHandler(this.Exit_button3_Click);
            // 
            // Delete_Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 296);
            this.Controls.Add(this.Exit_button3);
            this.Controls.Add(this.Delete_button2);
            this.Controls.Add(this.Search_button1);
            this.Controls.Add(this.SourceCode_linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CreateName_label1);
            this.Controls.Add(this.DeleteContactHeader_label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Delete_Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Delete_Contact_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteContactHeader_label1;
        private System.Windows.Forms.LinkLabel SourceCode_linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CreateName_label1;
        private System.Windows.Forms.Button Search_button1;
        private System.Windows.Forms.Button Delete_button2;
        private System.Windows.Forms.Button Exit_button3;
    }
}