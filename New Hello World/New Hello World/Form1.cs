using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Hello_World
{
    public partial class ClickTheButton : Form
    {
        public ClickTheButton()
        {
            InitializeComponent();
        }
        // Chaz Pollino , CST 150, 5/16/2023, This is my own work
        private void button3_Click(object sender, EventArgs e)
        {
            AnswerLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnswerLabel.Text = "Hello World!";
        }
    }
}
