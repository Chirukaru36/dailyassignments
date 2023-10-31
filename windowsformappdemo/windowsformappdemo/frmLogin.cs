using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsformappdemo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your not enter the user name and the password");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("are sure to cancel");
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor= Color.YellowGreen;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor=Color.Blue;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}