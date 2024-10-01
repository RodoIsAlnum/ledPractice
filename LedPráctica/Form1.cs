using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LedPráctica
{
    public partial class Form1 : Form
    {
        SerialPort ard { get; }

        public Form1()
        {
            InitializeComponent();
            ard = new SerialPort();
            ard.PortName = "COM3";
            ard.BaudRate = 9600;
            ard.Open();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            ard.Write("b");
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if (ard.IsOpen)
            {
                ard.Close();
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            ard.Write("a");
        }
    }
}
