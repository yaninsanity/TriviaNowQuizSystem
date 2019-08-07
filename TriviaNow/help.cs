//Zeren Yan CIS 345 9am
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //help me text
        private void help_Load(object sender, EventArgs e)
        {
            readMeLabel.Text = ("Read ME!!!!\n\nThis program has a data.dat file \n\nOpen from menu, and it has ten questions inside of the file\n\nYou can play quiz game by clicking play button\n\nThe system will pull out three random question from the quiz pool");
        }

        private void understandButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
