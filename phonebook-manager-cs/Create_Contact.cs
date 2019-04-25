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
        public static string ConnectionString = "DATA SOURCE=LAPTOP-UIK7JGOD:1522/XE;PASSWORD=password123;USER ID=PHONEBOOK";

        public Create_Contact()
        {
            InitializeComponent();
        }

        
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

                    OracleConnection con = new OracleConnection(ConnectionString);
                    OracleDataAdapter usersCount = new OracleDataAdapter("Select UserId from Contacts", con);
                    DataTable dt = new DataTable();
                    usersCount.Fill(dt);
                    int userid = dt.Rows.Count;
                    userid++;
                    //con.Close();

                    string sql = "INSERT INTO Contacts(Name, Contact_Number, Email, UserId) VALUES('" + name + "', '" + number + "' , '" + email + "' ,'"+userid+"') ";
                    //Oracle connection
                    
                    con.Open();

                    

                    OracleCommand cmd = new OracleCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added contact '" + name + "'");
                   // con.Close();
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
