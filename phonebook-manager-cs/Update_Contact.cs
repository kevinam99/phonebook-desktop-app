using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phonebook_manager_cs
{
    public partial class Update_Contact : Form
    {
        public Update_Contact()
        {
            InitializeComponent();
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
    }
}
