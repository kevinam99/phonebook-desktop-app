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

namespace phonebook_manager_cs
{
    public partial class OptionsScreen : Form
    {
        public OptionsScreen()
        {
            
            InitializeComponent();
        }

        private void OptionsScreen_Load(object sender, EventArgs e)
        {

        }

        private void Exit_button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Attention: The program will exit.", "Confirm exit", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                Application.ExitThread();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Create_Contact().ShowDialog();
        }

        private void SourceCode_linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/kevinam99/phonebook-desktop-app");
        }

        private void OptionsScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Attention: The program will exit.", "Confirm exit", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                // Application.ExitThread();
                this.Dispose();
            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Search_Contact().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Delete_Contact().ShowDialog();
        }
    }
}
