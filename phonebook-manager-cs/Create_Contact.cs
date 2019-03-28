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
    public partial class Create_Contact : Form
    {
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
            
        }

        private void Create_Contact_FormClosing_Click(object sender, FormClosingEventArgs e)
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
    }
}
