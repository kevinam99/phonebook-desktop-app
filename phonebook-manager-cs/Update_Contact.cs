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
    public partial class Update_Contact : Form
    {
        public string ConnectionString;
        public Update_Contact()
        {

            InitializeComponent();
            ConnectionString = Create_Contact.ConnectionString;
        }

        private void Update_Contact_Load(object sender, EventArgs e)
        {

        }

        private void Exit_button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Search_Contact().ShowDialog();
        }

        private void Update_Contact_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Save_button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!((textBox1.Text == "") && (textBox2.Text == "") &&(textBox4.Text == "")))
                {
                    string name = textBox1.Text;
                    string number = textBox2.Text;
                    string email = textBox3.Text;
                    string userid = textBox4.Text;

                    string sql = "UPDATE Contacts SET Name = '"+name+"', Contact_Number = '"+number+"', Email = '"+email+"', UserId = '"+userid+"' WHERE UserId = '"+userid+"' ";
                    //Oracle connection
                    OracleConnection con = new OracleConnection(ConnectionString);
                    con.Open();
                    OracleCommand cmd = new OracleCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated contact '" + name + "'");
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
