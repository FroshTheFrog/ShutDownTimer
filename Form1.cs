using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDownTimer
{
    public partial class Form1 : Form
    {


        decimal ShutDownTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Run ShutDown Timer
        private void button1_Click(object sender, EventArgs e)
        {
            ShutDownTime += numericUpDown1.Value;

            ShutDownTime += numericUpDown2.Value * 60;

            ShutDownTime += numericUpDown3.Value * 3600;

            string cmdCommand = "shutdown -s -t " + ShutDownTime;

            System.Diagnostics.Process.Start("CMD.exe", "/C " + cmdCommand);


            Application.Exit();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Hours
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        //Munutes
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        //Seconds
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
