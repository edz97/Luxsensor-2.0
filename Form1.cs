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

namespace Luxsensor
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM3", 9600);
            try
            {
                bool portOpen = serialPort.IsOpen;
                if (portOpen)
                {
                    serialPort.Close();
                }
                
                //serialPort.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("serial port did not open");
                throw;
            }
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void R()
        {
            textBox1.Text = serialPort.ReadLine();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = serialPort.ReadLine();
        }
    }
}

//void setup()
//{
//    // put your setup code here, to run once:
//    pinMode(LED_BUILTIN, OUTPUT);
//    Serial.begin(9600);

//}

//void loop()
//{
//    // put your main code here, to run repeatedly:
//    if (Serial.available() > 0)
//    {
//        char input = Serial.read();


//        if (input == 'a')
//        {
//            digitalWrite(LED_BUILTIN, HIGH);
//        }
//        if (input == 'b')
//        {
//            digitalWrite(LED_BUILTIN, LOW);
//        }
//        delay(1000);
//    }

