using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Macao
{
    public partial class Form3 : Form
    {
        int ok;
        public Form3(int ResX, int ResY, int Fullscr)
        {
            InitializeComponent();
            checkBox1.Checked = Convert.ToBoolean(Fullscr);
            comboBox1.SelectedIndex = 3;
            textBox1.Text = Convert.ToString(ResX);
            textBox2.Text = Convert.ToString(ResY);
            ok = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ok == 0)
            {
                DialogResult valRes = MessageBox.Show("WARNING: Any unsaved changes will be ignored", "Exit confirmation", MessageBoxButtons.YesNo);
                if (valRes == DialogResult.Yes)
                {
                    this.Owner.Show();
                    this.Close();
                }
            }
            else
            {
                this.Owner.Show();
                this.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string[] lines = { Convert.ToString(textBox1.Text), Convert.ToString(textBox2.Text), "temp" };
            if (checkBox1.Checked)
                lines[2] = "1";
            else
                lines[2] = "0";
            File.WriteAllLines("Options.txt", lines);
            ok = 1;
            MessageBox.Show("Saved!");



            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ok = 0;
            if (comboBox1.SelectedIndex != 3)
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
            }
            else
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = "1920";
                textBox2.Text = "1080";
            }
            else
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = "1280";
                textBox2.Text = "720";
            }
            else
            if(comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = "1280";
                textBox2.Text = "960";
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ok = 0;
            if (checkBox1.Checked)
            {
                comboBox1.SelectedIndex = 3;

                textBox1.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
                textBox2.Text = Screen.PrimaryScreen.Bounds.Height.ToString();
                comboBox1.Enabled = false;
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
            }
            else
            {
                comboBox1.Enabled = true;
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ok = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ok = 0;
        }

        private void checkBox1_EnabledChanged(object sender, EventArgs e)
        {
            


        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
