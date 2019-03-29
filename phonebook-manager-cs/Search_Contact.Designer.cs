namespace phonebook_manager_cs
{
    partial class Search_Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Contact));
            this.SearchHeader_label1 = new System.Windows.Forms.Label();
            this.Exit_button1 = new System.Windows.Forms.Button();
            this.Search_button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CreateName_label1 = new System.Windows.Forms.Label();
            this.Exit_button2 = new System.Windows.Forms.Button();
            this.SourceCode_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // SearchHeader_label1
            // 
            this.SearchHeader_label1.AutoSize = true;
            this.SearchHeader_label1.BackColor = System.Drawing.Color.Transparent;
            this.SearchHeader_label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F);
            this.SearchHeader_label1.Location = new System.Drawing.Point(164, 9);
            this.SearchHeader_label1.Name = "SearchHeader_label1";
            this.SearchHeader_label1.Size = new System.Drawing.Size(342, 36);
            this.SearchHeader_label1.TabIndex = 1;
            this.SearchHeader_label1.Text = "Search and update a contact";
            this.SearchHeader_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit_button1
            // 
            this.Exit_button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Exit_button1.Location = new System.Drawing.Point(250, 184);
            this.Exit_button1.Name = "Exit_button1";
            this.Exit_button1.Size = new System.Drawing.Size(149, 33);
            this.Exit_button1.TabIndex = 15;
            this.Exit_button1.Text = "Search and update";
            this.Exit_button1.UseVisualStyleBackColor = true;
            // 
            // Search_button1
            // 
            this.Search_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Search_button1.Location = new System.Drawing.Point(92, 184);
            this.Search_button1.Name = "Search_button1";
            this.Search_button1.Size = new System.Drawing.Size(129, 33);
            this.Search_button1.TabIndex = 12;
            this.Search_button1.Text = "Search";
            this.Search_button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.textBox1.Location = new System.Drawing.Point(250, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 26);
            this.textBox1.TabIndex = 11;
            // 
            // CreateName_label1
            // 
            this.CreateName_label1.AutoSize = true;
            this.CreateName_label1.BackColor = System.Drawing.Color.Transparent;
            this.CreateName_label1.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.CreateName_label1.Location = new System.Drawing.Point(87, 76);
            this.CreateName_label1.Name = "CreateName_label1";
            this.CreateName_label1.Size = new System.Drawing.Size(66, 26);
            this.CreateName_label1.TabIndex = 10;
            this.CreateName_label1.Text = "Name";
            // 
            // Exit_button2
            // 
            this.Exit_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Exit_button2.Location = new System.Drawing.Point(416, 184);
            this.Exit_button2.Name = "Exit_button2";
            this.Exit_button2.Size = new System.Drawing.Size(90, 33);
            this.Exit_button2.TabIndex = 13;
            this.Exit_button2.Text = "Exit";
            this.Exit_button2.UseVisualStyleBackColor = true;
            // 
            // SourceCode_linkLabel1
            // 
            this.SourceCode_linkLabel1.AutoSize = true;
            this.SourceCode_linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.SourceCode_linkLabel1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.SourceCode_linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.SourceCode_linkLabel1.Location = new System.Drawing.Point(527, 306);
            this.SourceCode_linkLabel1.Name = "SourceCode_linkLabel1";
            this.SourceCode_linkLabel1.Size = new System.Drawing.Size(84, 15);
            this.SourceCode_linkLabel1.TabIndex = 24;
            this.SourceCode_linkLabel1.TabStop = true;
            this.SourceCode_linkLabel1.Text = "Source code";
            // 
            // Search_Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 342);
            this.Controls.Add(this.SourceCode_linkLabel1);
            this.Controls.Add(this.Exit_button2);
            this.Controls.Add(this.Exit_button1);
            this.Controls.Add(this.Search_button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CreateName_label1);
            this.Controls.Add(this.SearchHeader_label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search_Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchHeader_label1;
        private System.Windows.Forms.Button Exit_button1;
        private System.Windows.Forms.Button Search_button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CreateName_label1;
        private System.Windows.Forms.Button Exit_button2;
        private System.Windows.Forms.LinkLabel SourceCode_linkLabel1;
    }
}