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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
        private void Print_Load(object sender, EventArgs e)
        {
            button1.Text = "Print";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font f = new Font("times", 18, FontStyle.Regular);
            e.Graphics.DrawString(richTextBox1.Text, f, Brushes.Black, 60, 60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

       
    }
}
