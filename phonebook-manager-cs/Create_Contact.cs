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
    public partial class Create_Contact : Form
    {
        public Create_Contact()
        {
            InitializeComponent();
        }

        public string ConnectionString = "DATA SOURCE=LAPTOP-UIK7JGOD:1522/XE;PASSWORD=password123;USER ID=PHONEBOOK";
        
        private void Exit_button1_Click(object sender, EventArgs e)
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


        private void Create_Contact_FormClosing(object sender, FormClosingEventArgs e)
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
                if(!((textBox1.Text == "") && (textBox2.Text == "")))
                {
                    string name = textBox1.Text;
                    string number = textBox2.Text;
                    string email = textBox3.Text;

                    string sql = "INSERT INTO Contacts(Name, Contact_Number, Email) VALUES('" + name + "', '" + number + "' , '" + email + "') ";
                    //Oracle connection
                    OracleConnection con = new OracleConnection(ConnectionString);
                    con.Open();
                    OracleCommand cmd = new OracleCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added contact '" + name + "'");
                }
                else
                {
                    MessageBox.Show("Please add valid inputs");
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
