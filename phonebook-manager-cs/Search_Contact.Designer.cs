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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Contact));
            this.SearchHeader_label1 = new System.Windows.Forms.Label();
            this.Update_button1 = new System.Windows.Forms.Button();
            this.Exit_button2 = new System.Windows.Forms.Button();
            this.SourceCode_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.USERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new phonebook_manager_cs.DataSet1();
            this.cONTACTSTableAdapter = new phonebook_manager_cs.DataSet1TableAdapters.CONTACTSTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTACTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            // Update_button1
            // 
            this.Update_button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Update_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Update_button1.Location = new System.Drawing.Point(272, 339);
            this.Update_button1.Name = "Update_button1";
            this.Update_button1.Size = new System.Drawing.Size(149, 33);
            this.Update_button1.TabIndex = 15;
            this.Update_button1.Text = "Update contact";
            this.Update_button1.UseVisualStyleBackColor = true;
            this.Update_button1.Click += new System.EventHandler(this.Update_button1_Click);
            // 
            // Exit_button2
            // 
            this.Exit_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Exit_button2.Location = new System.Drawing.Point(438, 339);
            this.Exit_button2.Name = "Exit_button2";
            this.Exit_button2.Size = new System.Drawing.Size(90, 33);
            this.Exit_button2.TabIndex = 13;
            this.Exit_button2.Text = "Exit";
            this.Exit_button2.UseVisualStyleBackColor = true;
            this.Exit_button2.Click += new System.EventHandler(this.Exit_button2_Click);
            // 
            // SourceCode_linkLabel1
            // 
            this.SourceCode_linkLabel1.AutoSize = true;
            this.SourceCode_linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.SourceCode_linkLabel1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.SourceCode_linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.SourceCode_linkLabel1.Location = new System.Drawing.Point(521, 384);
            this.SourceCode_linkLabel1.Name = "SourceCode_linkLabel1";
            this.SourceCode_linkLabel1.Size = new System.Drawing.Size(84, 15);
            this.SourceCode_linkLabel1.TabIndex = 24;
            this.SourceCode_linkLabel1.TabStop = true;
            this.SourceCode_linkLabel1.Text = "Source code";
            this.SourceCode_linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceCode_linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USERID,
            this.Column2,
            this.Column1,
            this.EMAIL,
            this.nAMEDataGridViewTextBoxColumn,
            this.cONTACTNUMBERDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.uSERIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cONTACTSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(109, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 200);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // USERID
            // 
            this.USERID.DataPropertyName = "USERID";
            this.USERID.HeaderText = "USERID";
            this.USERID.Name = "USERID";
            this.USERID.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NAME";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CONTACT_NUMBER";
            this.Column1.HeaderText = "Contact Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "E-mail";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // cONTACTNUMBERDataGridViewTextBoxColumn
            // 
            this.cONTACTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "CONTACT_NUMBER";
            this.cONTACTNUMBERDataGridViewTextBoxColumn.HeaderText = "CONTACT_NUMBER";
            this.cONTACTNUMBERDataGridViewTextBoxColumn.Name = "cONTACTNUMBERDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            // 
            // cONTACTSBindingSource
            // 
            this.cONTACTSBindingSource.DataMember = "CONTACTS";
            this.cONTACTSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONTACTSTableAdapter
            // 
            this.cONTACTSTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(114, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 33);
            this.button2.TabIndex = 29;
            this.button2.Text = "Delete contact";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search_Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SourceCode_linkLabel1);
            this.Controls.Add(this.Exit_button2);
            this.Controls.Add(this.Update_button1);
            this.Controls.Add(this.SearchHeader_label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search_Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_Contact_FormClosing);
            this.Load += new System.EventHandler(this.Search_Contact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTACTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchHeader_label1;
        private System.Windows.Forms.Button Update_button1;
        private System.Windows.Forms.Button Exit_button2;
        private System.Windows.Forms.LinkLabel SourceCode_linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cONTACTSBindingSource;
        private DataSet1TableAdapters.CONTACTSTableAdapter cONTACTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}