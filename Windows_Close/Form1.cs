using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Close
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_tick);
            timer1.Interval = 100;
            timer1.Start();
        }
            public void timer1_tick(object sender, EventArgs e)
            {
                DateTime time = DateTime.Now;
                string time_string;
                time_string = time.ToString();
                label1.Text = time_string;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                if (radioButton1.Checked)
                {
                    if (textBox1.Text != "")
                    {
                        string shut_time;
                        shut_time = (Convert.ToInt32(textBox1.Text) * 60).ToString();
                        System.Diagnostics.Process exit = new System.Diagnostics.Process();
                        exit.StartInfo.FileName = "cmd.exe";
                        exit.StartInfo.Arguments = "/c shutdown -s -t  " + shut_time;
                        exit.Start();
                    }
                    else
                    {
                        System.Diagnostics.Process exit = new System.Diagnostics.Process();
                        exit.StartInfo.FileName = "cmd.exe";
                        exit.StartInfo.Arguments = "/c shutdown -s";
                        exit.Start();
                    }
                }

                if (radioButton2.Checked)
                {
                    if (textBox1.Text != "")
                    {
                        string shut_time;
                        shut_time = (Convert.ToInt32(textBox1.Text) * 60).ToString();
                        System.Diagnostics.Process exit = new System.Diagnostics.Process();
                        exit.StartInfo.FileName = "cmd.exe";
                        exit.StartInfo.Arguments = "/c shutdown -r -t " + shut_time;
                        exit.Start();
                    }
                    else
                    {
                        System.Diagnostics.Process exit = new System.Diagnostics.Process();
                        exit.StartInfo.FileName = "cmd.exe";
                        exit.StartInfo.Arguments = "/c shutdown -r";
                        exit.Start();
                    }
                }
                if(radioButton3.Checked)
                {
                    this.textBox1.Enabled = false;
                        System.Diagnostics.Process exit = new System.Diagnostics.Process();
                        exit.StartInfo.FileName = "cmd.exe";
                        exit.StartInfo.Arguments = "/c shutdown -h";
                        exit.Start();
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process exit = new System.Diagnostics.Process();
                exit.StartInfo.FileName = "cmd.exe";
                exit.StartInfo.Arguments = "/c shutdown -a";
                exit.Start();
            }

            private void radio_Button3(object sender, EventArgs e)
            {
                textBox1.Enabled = false;
            }

            private void radio_Button2(object sender, EventArgs e)
            {
                textBox1.Enabled = true;
            }

            private void radio_Button1(object sender, EventArgs e)
            {
                textBox1.Enabled = true;
            }
            
        }
}

