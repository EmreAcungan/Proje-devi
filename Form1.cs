using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                textBox2.Text = "-----------\r\n";
                textBox2.Text += textBox1.Text + "\r\n";
                textBox2.Text += textBox4.Text + "\r\n";
                textBox2.Text += textBox3.Text + "\r\n";
                textBox2.Text = "-----------\r\n";

                decimal hesap = 0;
                if (numericUpDown1.Value > 0)
                {
                    hesap += numericUpDown1.Value * 30;
                    textBox2.Text += string.Format("ÇORBA"+"           " + comboBox1.Text+" \t \t {0:C} \t 30.00", numericUpDown1.Value * 30) + "\r\n";
                }

                if (numericUpDown2.Value > 0)
                {
                    hesap += numericUpDown2.Value * 20;
                    textBox2.Text += string.Format("SALATA" +"          "+ comboBox2.Text+"\t \t {0:C}\t 20.00", numericUpDown2.Value * 20) + "\r\n";
                }


                if (numericUpDown3.Value > 0)
                {
                    hesap += numericUpDown3.Value * 50;
                    textBox2.Text += string.Format("ANA YEMEK"+"   " + comboBox3.Text+ "\t \t {0:C}\t 50.00", numericUpDown3.Value * 50) + "\r\n";
                }


                if (numericUpDown4.Value > 0)
                {
                    hesap += numericUpDown4.Value * 100;
                    textBox2.Text += string.Format("TATLI" +"              "+ comboBox4.Text+"\t \t {0:C}\t 100.00", numericUpDown4.Value * 100) + "\r\n";
                }
                if (numericUpDown5.Value > 0)
                {
                    hesap += numericUpDown5.Value * 10;
                    textBox2.Text += string.Format("İÇECEK"+"           " + comboBox5.Text + "\t \t {0:C}\t 100.00", numericUpDown5.Value * 10) + "\r\n";
                }
                if (numericUpDown6.Value > 0)
                {
                    hesap += numericUpDown6.Value * 70;
                    textBox2.Text += string.Format("PİLAV"+"              " + comboBox6.Text + " \t \t {0:C}\t 100.00", numericUpDown6.Value * 70) + "\r\n";
                }
                if (numericUpDown7.Value > 0)
                {
                    hesap += numericUpDown5.Value * 150;
                    textBox2.Text += string.Format("IZGARA"+"           "+ comboBox7.Text + "\t \t {0:C}\t 100.00", numericUpDown7.Value * 150) + "\r\n";
                }


                textBox2.Text += "-----------------\r\n";
                textBox2.Text += string.Format("Toplam {0:C}", hesap);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

