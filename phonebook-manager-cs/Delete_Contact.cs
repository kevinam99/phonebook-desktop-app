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
    public partial class Delete_Contact : Form
    {
        public string ConnectionString;

       

        public Delete_Contact()
        {
            InitializeComponent();
            ConnectionString = Create_Contact.ConnectionString;
        }

        private void Exit_button3_Click(object sender, EventArgs e)
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

        private void SourceCode_linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/kevinam99/phonebook-desktop-app");

        }

        private void Delete_Contact_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Delete_Contact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CONTACTS' table. You can move, or remove it, as needed.
            this.cONTACTSTableAdapter.Fill(this.dataSet1.CONTACTS);

        }

        private void Delete_button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(textBox1.Text == ""))
                {
                    string id = textBox1.Text;
                    
                    string sql = "Delete FROM Contacts WHERE UserId = '" + id + "' ";
                    //Oracle connection
                    OracleConnection con = new OracleConnection(ConnectionString);
                    con.Open();
                    OracleCommand cmd = new OracleCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    dataGridView1.Refresh();

                    MessageBox.Show("Successfully deleted contact '");
                }
                else
                {
                    MessageBox.Show("Please add valid inputs");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }
    }
}
