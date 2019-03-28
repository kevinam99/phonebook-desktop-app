using System;
using System.Windows.Forms;

namespace phonebook_manager_cs
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
//KeyEventArgs

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Close();
                timer1.Enabled = false;
                new OptionsScreen().Show();
            }
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {             
                timer1.Enabled = false;
                // Close current form while keeping the other form open
                this.Hide();
                new OptionsScreen().ShowDialog(); // Runs until this form is closed.
                this.Close();
                
          //      new OptionsScreen().Show();
            //    this.Hide();
                
            }
        }

        
    }
}
