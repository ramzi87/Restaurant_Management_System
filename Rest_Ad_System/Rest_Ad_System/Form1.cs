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
    public partial class RMS : Form
    {
        public RMS()
        {
            InitializeComponent();
        }
        string c;
        double x;
        int time = 8;
       

        private void startBtn()
        {
            textBox1.Text = "00";
            textBox2.Text = "00";
            textBox3.Text = "00";
            textBox4.Text = "00";
            textBox5.Text = "00";
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "00";
            textBox9.Text = "00";
            textBox10.Text = "00";
            textBox11.Text = "00";
            textBox12.Text = "00";
            textBox13.Text = "00";
            textBox14.Text = "00";
            textBox15.Text = "00";
            textBox16.Text = "00";
            textBox17.Text = "00";
            textBox18.Text = "00";
            cost_of_meal.Text = "00 D.A";
            cost_of_drinks.Text = "00 D.A";
            Total.Text = "00 D.A";
            Total2.Text = "00 D.A";
            Total3.Text = "00 D.A";
            label26.Text = "Welcome To Our Restaurant";
        }
        private void ResetButton()
        {
            textBox1.Text = "00";
            textBox2.Text = "00";
            textBox3.Text = "00";
            textBox4.Text = "00";
            textBox5.Text = "00";
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "00";
            textBox9.Text = "00";
            textBox10.Text = "00";
            textBox11.Text = "00";
            textBox12.Text = "00";
            textBox13.Text = "00";
            textBox14.Text = "00";
            textBox15.Text = "00";
            textBox16.Text = "00";
            textBox17.Text = "00";
            textBox18.Text = "00";
            cost_of_meal.Text = "00 D.A";
            cost_of_drinks.Text = "00 D.A";
            Total.Text = "00 D.A";
            Total2.Text = "00 D.A";
            Total3.Text = "00 D.A";
            label26.Text = "Set New Calculation Account";
        }
        private void disablebutn()
        {
            button2.Show();
            button3.Hide();
            button1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            Calculat_Result.Enabled = false;
        }
        private void Enablebutn()
        {
            button2.Hide();
            button3.Show();
            button1.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            Calculat_Result.Enabled = true;
        }

        
      
        private void button1_Click(object sender, EventArgs e)
        {
            Calculat_Result.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Calculat_Result.Text = Calculat_Result.Text + b.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Calculat_Result.Text != "" && label23.Text != "")
                button18.PerformClick();
            c = b.Text;
            x = Convert.ToDouble(Calculat_Result.Text);
            label23.Text = Calculat_Result.Text + " " + c;
            Calculat_Result.Clear();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case "+":
                    {
                        double y = Convert.ToDouble(Calculat_Result.Text);
                        Calculat_Result.Text = (x + y).ToString();
                        label23.Text = "";
                    }
                    break;
                case "-":
                    {
                        double y = Convert.ToDouble(Calculat_Result.Text);
                        Calculat_Result.Text = (x - y).ToString();
                        label23.Text = "";
                    }
                    break;
                case "*":
                    {
                        double y = Convert.ToDouble(Calculat_Result.Text);
                        Calculat_Result.Text = (x * y).ToString();
                        label23.Text = "";
                    }
                    break;
                case "/":
                    {
                        double y = Convert.ToDouble(Calculat_Result.Text);
                        Calculat_Result.Text = (x / y).ToString();
                        label23.Text = "";
                    }
                    break;
            }
        }

        private void Calculat_Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    {
                        e.Handled = true;
                        button7.PerformClick();
                    }
                    break;
                case '-':
                    {
                        e.Handled = true;
                        button11.PerformClick();
                    }
                    break;
                case '*':
                    {
                        e.Handled = true;
                        button15.PerformClick();
                    }
                    break;
                case '/':
                    {
                        e.Handled = true;
                        button19.PerformClick();
                    }
                    break;
                case (char)Keys.Enter:
                    {
                        button18.PerformClick();
                    }break;
                case (char)Keys.Back:
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Enter numbers only");
                    break;
            }           
        }
        private void button22_Click(object sender, EventArgs e)
        {
            int frit = int.Parse(textBox1.Text);
            int frit_Result = (frit * 150);
            double X_frit = Convert.ToDouble(frit_Result);

            int sand_poulet = int.Parse(textBox2.Text);
            int sand_poulet_Result = (sand_poulet * 200);
            double X_poulet = Convert.ToDouble(sand_poulet_Result);

            int Chawarma = int.Parse(textBox3.Text);
            int Chawarma_Res = (Chawarma * 250);
            double X_chawarma = Convert.ToDouble(Chawarma_Res);

            int Melange = int.Parse(textBox4.Text);
            int melange_Res = (Melange * 400);
            double X_Melange = Convert.ToDouble(melange_Res);

            int merguez = int.Parse(textBox5.Text);
            int merguez_Res = (merguez * 200);
            double X_merguez = Convert.ToDouble(merguez_Res);

            int frit_salade = int.Parse(textBox6.Text);
            int frit_salade_Res = (frit_salade * 250);
            double X_fsalade = Convert.ToDouble(frit_salade_Res);

            int Gratin_poulet = int.Parse(textBox7.Text);
            int Gratin_poulet_Res = (Gratin_poulet * 300);
            double X_gratin = Convert.ToDouble(Gratin_poulet_Res);

            int escalope = int.Parse(textBox8.Text);
            int escalope_Res = (escalope * 150);
            double X_escalope = Convert.ToDouble(escalope_Res);

            int puree = int.Parse(textBox9.Text);
            int puree_Res = (puree * 250);
            double X_puree = Convert.ToDouble(puree_Res);
 
            // Total Cost of Meal

            double Cost_Meal = Convert.ToDouble(X_frit + X_poulet + X_chawarma + X_Melange + X_merguez + X_fsalade
                                            + X_gratin + X_escalope + X_puree);
            cost_of_meal.Text = ((Cost_Meal).ToString() + " " + "D.A");

            // Drinks

            int orange_jus = int.Parse(textBox18.Text);
            int orange_jus_Res = (orange_jus * 150);
            double X_orange_jus = Convert.ToDouble(orange_jus_Res);

            int cock_jus = int.Parse(textBox17.Text);
            int cock_jus_Res = (cock_jus * 200);
            double X_cock_jus = Convert.ToDouble(cock_jus_Res);

            int coca = int.Parse(textBox16.Text);
            int coca_Res = (coca * 200);
            double X_coca = Convert.ToDouble(coca_Res);

            int coca_canet = int.Parse(textBox15.Text);
            int coca_canet_Res = (coca_canet * 100);
            double X_coca_canet = Convert.ToDouble(coca_canet_Res);

            int pepsi_canet = int.Parse(textBox14.Text);
            int pepsi_canet_Res = (pepsi_canet * 100);
            double X_pepsi_canet = Convert.ToDouble(pepsi_canet_Res);

            int boissons_gaz = int.Parse(textBox13.Text);
            int boissons_gaz_Res = (boissons_gaz * 80);
            double X_boissons_gaz = Convert.ToDouble(boissons_gaz_Res);

            int hamoud = int.Parse(textBox12.Text);
            int hamoud_Res = (hamoud * 120);
            double X_hamoud = Convert.ToDouble(hamoud_Res);

            int fraise_jus = int.Parse(textBox11.Text);
            int fraise_jus_Res = (fraise_jus * 200);
            double X_fraise_jus = Convert.ToDouble(fraise_jus_Res);

            int ananas_jus = int.Parse(textBox10.Text);
            int ananas_jus_Res = (ananas_jus * 250);
            double X_ananas_jus = Convert.ToDouble(ananas_jus_Res);

            // Total Cost of Drinks

            double Cost_drinks = Convert.ToDouble(X_orange_jus + X_cock_jus + X_coca + X_coca_canet + X_pepsi_canet
                              + X_boissons_gaz + X_hamoud + X_fraise_jus + X_ananas_jus);
            cost_of_drinks.Text = ((Cost_drinks).ToString() + " " + "D.A");

            // Total Cost

            double Total_Cost = (Cost_Meal + Cost_drinks);
            Total.Text = ((Total_Cost).ToString() + " " + "D.A");
            Total2.Text = ((Total_Cost).ToString() + " " + "D.A");
            Total3.Text = ((Total_Cost).ToString() + " " + "D.A");

            if (textBox1.Text == "00" && textBox2.Text == "00" && textBox3.Text == "00" && textBox4.Text == "00" && textBox5.Text == "00"
                && textBox6.Text == "00" && textBox7.Text == "00" && textBox8.Text == "00" && textBox9.Text == "00" && textBox10.Text == "00"
                && textBox11.Text == "00" && textBox12.Text == "00" && textBox13.Text == "00" && textBox14.Text == "00" && textBox15.Text == "00"
                && textBox16.Text == "00" && textBox17.Text == "00" && textBox18.Text == "00")
            {
                cost_of_meal.Text = "00 D.A";
                cost_of_drinks.Text = "00 D.A";
                Total.Text = "00 D.A";
                MessageBox.Show("Please Fill Up one Box at least !!");
            }
            else
            {
                Total.Text = ((Total_Cost).ToString() + " " + "D.A");
            }
        }
       
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetButton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int lenght = Calculat_Result.TextLength - 1;
            string text = Calculat_Result.Text;
            Calculat_Result.Clear();
            for (int i = 0; i < lenght; i++)
                Calculat_Result.Text = Calculat_Result.Text + text[i];
        }      
        private void RMS_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label24.Text = DateTime.Now.ToLongTimeString();
            label45.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label24.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Enablebutn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            disablebutn();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            startBtn();
        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text != "")
            {
                textBox1.Text = (num + 1).ToString();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox2.Text);
            if (textBox2.Text != "")
            {
                textBox2.Text = (num + 1).ToString();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox3.Text);
            if (textBox3.Text != "")
            {
                textBox3.Text = (num + 1).ToString();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox4.Text);
            if (textBox4.Text != "")
            {
                textBox4.Text = (num + 1).ToString();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox5.Text);
            if (textBox5.Text != "")
            {
                textBox5.Text = (num + 1).ToString();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox6.Text);
            if (textBox6.Text != "")
            {
                textBox6.Text = (num + 1).ToString();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox7.Text);
            if (textBox7.Text != "")
            {
                textBox7.Text = (num + 1).ToString();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox8.Text);
            if (textBox8.Text != "")
            {
                textBox8.Text = (num + 1).ToString();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox9.Text);
            if (textBox9.Text != "")
            {
                textBox9.Text = (num + 1).ToString();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox18.Text);
            if (textBox18.Text != "")
            {
                textBox18.Text = (num + 1).ToString();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox17.Text);
            if (textBox17.Text != "")
            {
                textBox17.Text = (num + 1).ToString();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox16.Text);
            if (textBox16.Text != "")
            {
                textBox16.Text = (num + 1).ToString();
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox15.Text);
            if (textBox15.Text != "")
            {
                textBox15.Text = (num + 1).ToString();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox14.Text);
            if (textBox14.Text != "")
            {
                textBox14.Text = (num + 1).ToString();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox13.Text);
            if (textBox13.Text != "")
            {
                textBox13.Text = (num + 1).ToString();
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox12.Text);
            if (textBox12.Text != "")
            {
                textBox12.Text = (num + 1).ToString();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox11.Text);
            if (textBox11.Text != "")
            {
                textBox11.Text = (num + 1).ToString();
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox10.Text);
            if (textBox10.Text != "")
            {
                textBox10.Text = (num + 1).ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button25.Hide(); button38.Hide();
            button26.Hide(); button39.Hide();
            button27.Hide(); button40.Hide();
            button28.Hide(); button41.Hide();
            button29.Hide(); button42.Hide();
            button30.Hide();
            button31.Hide();
            button32.Hide();
            button33.Hide();
            button34.Hide();
            button35.Hide();
            button36.Hide();
            button37.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button25.Show(); button38.Show();
            button26.Show(); button39.Show();
            button27.Show(); button40.Show();
            button28.Show(); button41.Show();
            button29.Show(); button42.Show();
            button30.Show();
            button31.Show();
            button32.Show();
            button33.Show();
            button34.Show();
            button35.Show();
            button36.Show();
            button37.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();

        }

        private void button46_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            // Print Invoice 00 D.A
            Print Prt = new Print();

            string dat = DateTime.Now.ToString("dd/MM/yyyy");
            string tim = DateTime.Now.ToLongTimeString();
            string welcome = "Thank you and welcome to our restaurant";

            Prt.richTextBox1.Text = ("                          " + label1.Text +
                "\r\n         ________________________________________________" +
                "\r\n         ________________________________________________" +
                "\r\n" + "\r\n               " + "              " + dat + "                      " + tim + 
                "\r\n         ________________________________________________" +
                "\r\n\r\n         Frites Omelette" + " ................................................................ " + textBox1.Text + "\r\n         Sandwich Poulet" + " .............................................................. " + textBox2.Text +
                "\r\n         Sand Chawarma" + " ............................................................... " + textBox3.Text + "\r\n         Repas Melange" + " ................................................................. " + textBox4.Text +
                "\r\n         Sand Merguez" + " .................................................................. " + textBox5.Text + "\r\n         Frites Salade" + " ..................................................................... " + textBox6.Text +
                "\r\n         Gratin Poulet" + " .................................................................... " + textBox7.Text + "\r\n         Escalope Bro" + " .................................................................... " + textBox8.Text +
                "\r\n         Repas Purée" + " ...................................................................... " + textBox9.Text + "\r\n         Jus Orange" + " ........................................................................ " + textBox18.Text +
                "\r\n         Jus Cocktail" + " ...................................................................... " + textBox17.Text + "\r\n         CocaCola 1 L" + " .................................................................... " + textBox16.Text +
                "\r\n         Coca Canette" + " .................................................................... " + textBox15.Text + "\r\n         Pepsi Canette" + " .................................................................... " + textBox14.Text +
                "\r\n         Boissons Gaz" + " .................................................................... " + textBox13.Text + "\r\n         HamoudB 1 L" + " ................................................................... " + textBox12.Text +
                "\r\n         Jus Fraise" + " .......................................................................... " + textBox11.Text + "\r\n         jus Ananas" + " ........................................................................ " + textBox10.Text +
                "\r\n         ________________________________________________" +
                "\r\n\r\n         Cost of Meal" + " ............................................................ " + cost_of_meal.Text + "\r\n         Cost of Drinks" + " .......................................................... " + cost_of_drinks.Text +
                "\r\n         ________________________________________________" +
                "\r\n    " + "\r\n         Total Cost" + " ................................................................. " + Total.Text +
                "\r\n         ________________________________________________" +
                "\r\n    " + "\r\n                         " + welcome);

            if (Total.Text == "")
            {
                MessageBox.Show("Please Fill Up one Box at least !!");
            }
            else if (Total.Text == "00 D.A")
            {
                MessageBox.Show("Please Fill Up one Box at least !!");
            }
            else
            {
                Prt.ShowDialog();
            }

            ////////////////////////////////////////
        }
        Login FRMLogin = new Login();
        private void button46_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FRMLogin.ShowDialog();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Login FRMLogin = new Login();
            this.Hide();
            FRMLogin.ShowDialog();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            panel12.Hide();
            panel13.Hide();
        }

        private void button43_Click_1(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text != "")
            {
                textBox1.Text = (num + 1).ToString();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox2.Text);
            if (textBox2.Text != "")
            {
                textBox2.Text = (num + 1).ToString();
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox3.Text);
            if (textBox3.Text != "")
            {
                textBox3.Text = (num + 1).ToString();
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox4.Text);
            if (textBox4.Text != "")
            {
                textBox4.Text = (num + 1).ToString();
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox5.Text);
            if (textBox5.Text != "")
            {
                textBox5.Text = (num + 1).ToString();
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox6.Text);
            if (textBox6.Text != "")
            {
                textBox6.Text = (num + 1).ToString();
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox7.Text);
            if (textBox7.Text != "")
            {
                textBox7.Text = (num + 1).ToString();
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox8.Text);
            if (textBox8.Text != "")
            {
                textBox8.Text = (num + 1).ToString();
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox9.Text);
            if (textBox9.Text != "")
            {
                textBox9.Text = (num + 1).ToString();
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox18.Text);
            if (textBox18.Text != "")
            {
                textBox18.Text = (num + 1).ToString();
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox17.Text);
            if (textBox17.Text != "")
            {
                textBox17.Text = (num + 1).ToString();
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox16.Text);
            if (textBox16.Text != "")
            {
                textBox16.Text = (num + 1).ToString();
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox15.Text);
            if (textBox15.Text != "")
            {
                textBox15.Text = (num + 1).ToString();
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox14.Text);
            if (textBox14.Text != "")
            {
                textBox14.Text = (num + 1).ToString();
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox13.Text);
            if (textBox13.Text != "")
            {
                textBox13.Text = (num + 1).ToString();
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox12.Text);
            if (textBox12.Text != "")
            {
                textBox12.Text = (num + 1).ToString();
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox11.Text);
            if (textBox11.Text != "")
            {
                textBox11.Text = (num + 1).ToString();
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox10.Text);
            if (textBox10.Text != "")
            {
                textBox10.Text = (num + 1).ToString();
            }
        }
        private void button65_Click(object sender, EventArgs e)
        {
            panel12.Show();
            panel13.Show();
        }
    }
}
