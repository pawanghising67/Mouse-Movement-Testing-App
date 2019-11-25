using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMovementCalculator
{
    public partial class WelcomeMenu : Form
    {
        public WelcomeMenu()
        {
            InitializeComponent();
            label7.MaximumSize = new Size(500, 0);
            label7.AutoSize = true;
            label7.Text ="Participation in this usability study is voluntary.All information will remain strictly" +
                  "confidential.The descriptions and findings may be used to help improve the Kinect" +
                   "application.However, at no time will your name or any other identification be used. You" +
                   "can withdraw your consent to the experiment and stop participation at any time." +

                   "                                                " +
                    "If you have any questions after today, please contact Pawan Ghising at  " +
                     "pawan.ghising@mnsu.edu" +

                     "                                                                                " +
                     "I have read and understood the information on this form and had all of my questions answered. ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MouseMove newform = new MouseMove();
            newform.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
