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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Contact));
            this.DeleteContactHeader_label1 = new System.Windows.Forms.Label();
            this.SourceCode_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextboxUserID = new System.Windows.Forms.Label();
            this.Delete_button2 = new System.Windows.Forms.Button();
            this.Exit_button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new phonebook_manager_cs.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONTACTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONTACTSTableAdapter = new phonebook_manager_cs.DataSet1TableAdapters.CONTACTSTableAdapter();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTACTSBindingSource)).BeginInit();
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
            this.textBox1.Location = new System.Drawing.Point(199, 198);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 26);
            this.textBox1.TabIndex = 18;
            // 
            // TextboxUserID
            // 
            this.TextboxUserID.AutoSize = true;
            this.TextboxUserID.BackColor = System.Drawing.Color.Transparent;
            this.TextboxUserID.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.TextboxUserID.Location = new System.Drawing.Point(36, 198);
            this.TextboxUserID.Name = "TextboxUserID";
            this.TextboxUserID.Size = new System.Drawing.Size(82, 26);
            this.TextboxUserID.TabIndex = 34;
            this.TextboxUserID.Text = "User ID";
            // 
            // Delete_button2
            // 
            this.Delete_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Delete_button2.Location = new System.Drawing.Point(160, 255);
            this.Delete_button2.Name = "Delete_button2";
            this.Delete_button2.Size = new System.Drawing.Size(149, 33);
            this.Delete_button2.TabIndex = 22;
            this.Delete_button2.Text = "Delete contact";
            this.Delete_button2.UseVisualStyleBackColor = true;
            this.Delete_button2.Click += new System.EventHandler(this.Delete_button2_Click);
            // 
            // Exit_button3
            // 
            this.Exit_button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Exit_button3.Location = new System.Drawing.Point(336, 255);
            this.Exit_button3.Name = "Exit_button3";
            this.Exit_button3.Size = new System.Drawing.Size(90, 33);
            this.Exit_button3.TabIndex = 20;
            this.Exit_button3.Text = "Exit";
            this.Exit_button3.UseVisualStyleBackColor = true;
            this.Exit_button3.Click += new System.EventHandler(this.Exit_button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.cONTACTNUMBERDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cONTACTSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 150);
            this.dataGridView1.TabIndex = 37;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // cONTACTSBindingSource
            // 
            this.cONTACTSBindingSource.DataMember = "CONTACTS";
            this.cONTACTSBindingSource.DataSource = this.dataSet1;
            // 
            // cONTACTSTableAdapter
            // 
            this.cONTACTSTableAdapter.ClearBeforeFill = true;
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // cONTACTNUMBERDataGridViewTextBoxColumn
            // 
            this.cONTACTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "CONTACT_NUMBER";
            this.cONTACTNUMBERDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.cONTACTNUMBERDataGridViewTextBoxColumn.Name = "cONTACTNUMBERDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // Delete_Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 296);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit_button3);
            this.Controls.Add(this.Delete_button2);
            this.Controls.Add(this.SourceCode_linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextboxUserID);
            this.Controls.Add(this.DeleteContactHeader_label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Delete_Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Delete_Contact_FormClosing);
            this.Load += new System.EventHandler(this.Delete_Contact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTACTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteContactHeader_label1;
        private System.Windows.Forms.LinkLabel SourceCode_linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TextboxUserID;
        private System.Windows.Forms.Button Delete_button2;
        private System.Windows.Forms.Button Exit_button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cONTACTSBindingSource;
        private DataSet1TableAdapters.CONTACTSTableAdapter cONTACTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
    }
}