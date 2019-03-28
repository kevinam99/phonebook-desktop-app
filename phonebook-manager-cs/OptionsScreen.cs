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
    public partial class OptionsScreen : Form
    {
        public OptionsScreen()
        {
            
            InitializeComponent();
        }

        private void OptionsScreen_Load(object sender, EventArgs e)
        {

        }

        private void OptionsScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void OptionsScreen_FormClosing_1(object sender, FormClosingEventArgs e)
        {

        }

        private void Exit_button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Attention: The program will exit.", "Confirm exit", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.Cancel)
            {
                this.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Create_Contact().Show();
        }
    }
}
