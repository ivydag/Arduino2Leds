using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arduino2Leds.Properties;
using System.IO.Ports;


namespace Arduino2Leds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM5";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void ButtonL1On_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            textBox1.Text = "El led 1 se ha encendido";
            pictureBox1.Image = Resources.bulb_yellow;
        }

        private void ButtonL1Off_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            textBox1.Text = "El led 1 se ha Apagado";
            pictureBox1.Image = Resources.bulb;
        }

        private void ButtonL2On_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2");
            textBox1.Text = "El led 2 se ha encendido";
            pictureBox2.Image = Resources.bulb_green;
        }

        private void ButtonL2Off_Click(object sender, EventArgs e)
        {
            serialPort1.Write("3");
            textBox1.Text = "El led 2 se ha Apagado";
            pictureBox2.Image = Resources.bulb;
          
        }

       

       
    }
}
