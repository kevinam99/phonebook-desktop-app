using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace phonebook_manager_cs
{
    public partial class Search_Contact : Form
    {
        public string ConnectionString;
        public Search_Contact()
        {
            InitializeComponent();
            ConnectionString = Create_Contact.ConnectionString;

        }

        private void Exit_button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You will be directed to the main menu.", "Confirm exit", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                // Application.ExitThread();
                this.Dispose();
                new OptionsScreen().ShowDialog();
                // this.Dispose();
            }
            else if (dialog == DialogResult.Cancel)
            {

            }
        }

        private void Search_Contact_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You will be directed to the main menu.", "Confirm exit", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                // Application.ExitThread();
                this.Dispose();
                new OptionsScreen().ShowDialog();
                //   this.Dispose();
            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void SourceCode_linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/kevinam99/phonebook-manager-csharp");

        }

        private void Update_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Update_Contact().ShowDialog();
        }

        private void Search_Contact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CONTACTS' table. You can move, or remove it, as needed.
            //this.cONTACTSTableAdapter.Fill(this.dataSet1.CONTACTS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Delete_Contact().ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(textBox1.Text))
                {
                    string sql = "SELECT * FROM Contacts WHERE Name='" + textBox1.Text + "'";
                    OracleConnection con = new OracleConnection(ConnectionString);
                    con.Open();
                    OracleDataAdapter oda = new OracleDataAdapter(sql, con);
                    DataTable dataTable = new DataTable();

                    oda.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No Entries found", " Try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dataGridView1.DataSource = dataTable;
                    }
                    con.Close();








                    //OracleDataAdapter oda = new OracleDataAdapter("Select * from Contacts", con);
                    //DataTable dt = new DataTable();
                    //oda.Fill(dt);
                    //con.Open();
                    //OracleCommand cmd = new OracleCommand(sql, con);
                    //cmd.CommandType = CommandType.Text;
                    //cmd.ExecuteNonQuery();
                    //dataGridView1.DataSource = sql.ToList();
                    //dataGridView1.Refresh();

                    //  MessageBox.Show("Successfully updated contact '" + name + "'");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }
    }
}
