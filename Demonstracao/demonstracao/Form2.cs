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
using System.IO;

namespace demonstracao
{
    public partial class Form2 : Form
    {
        SerialPort serialPort1 = new SerialPort("COM4", 9600);
        public Form2()
        {
            InitializeComponent();
            serialPort1.PortName = "COM4";
            serialPort1.BaudRate = 9600;
            // Configurando cor de fundo dos botões
            btnLigaLED.BackColor = Color.White;
            btnDesligaLED.BackColor = Color.White;
        }

        private void btnLigaLED_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("1");
            }
            serialPort1.Close();
            btnLigaLED.BackColor = Color.Aqua;
            btnDesligaLED.BackColor = Color.White;
        }

        private void btnDesligaLED_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("0");
            }
            serialPort1.Close();
            btnDesligaLED.BackColor = Color.Aqua;
            btnLigaLED.BackColor = Color.White;
        }
    }
}
