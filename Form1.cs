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


namespace Serial_Catur1._0
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string dataIN;
        string Baud115200 = "AT+IPR=115200\r\n"; // Usando \r\n para enviar CR e LF
        string Baud9600 = "AT+IPR=9600\r\n"; // Usando \r\n para enviar CR e LF
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            CboxCOMPORT.Items.AddRange(ports);
        }

        private void btnOPEN_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = CboxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(CboxBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(CboxDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CboxSTOPBITS.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CboxPARITYBITS.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
            }

            catch (Exception err)

            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }



        }

        private void btnSENDDATA_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {


                serialPort1.Write(Baud115200);



                // dataOUT = tboxDATAOUT.Text;
                //serialPort1.Write(dataOUT);



                //serialPort1.WriteLine(dataOUT);
                //m_CommPort.Write(Encoding.ASCII.GetBytes("AT" & Chr(13)))
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write(Baud9600);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxDATAOUT_TextChanged(object sender, EventArgs e)
        {

        }


        private void ShowData(object sender, EventArgs e)
        {
            tBoxDataIN.AppendText(dataIN); // Append without overwriting
            dataIN = ""; // Clear buffer
        }

        private void tBoxDataIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));

        }





    }
}



