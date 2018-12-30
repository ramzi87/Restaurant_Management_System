using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rest_Ad_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RMS FRM1 = new RMS(); 
            if (textBox1.Text == "ramzi" && textBox2.Text == "1987")
            {
                this.Hide();
                FRM1.ShowDialog();
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Invalid username or password ! Please Fill up the necessary boxes");
            }
            else
            {
                textBox2.Clear();
                MessageBox.Show("Error ! Username or Password incorrect ! Please try again");
            }
        }
    }
}
