using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1_Parfonov_RE_21mp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "Hlieb" && textBox_password.Text == "123")
            {
                label_OK.BackColor = Color.Green;
                MessageBox.Show("Hello, Hlieb");
            }
            else
            {
                label_OK.BackColor = Color.Red;
                MessageBox.Show("error login or password");
            }
        }
    }
}
