using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoCsharp
{
    public partial class Form1 : Form
    {
        private Point _mousePosition;
        bool estaConetada;
        String[] portas;
        SerialPort porta;


        public Form1()
        {
            InitializeComponent();
            BuscarAvaliarPortas();

            foreach (string porta in portas)
            {
                cmbPortas.Items.Add(porta);
                if (portas[0] != null)
                {
                    cmbPortas.SelectedItem = portas[0];
                }
            }
            ;
        }
        private void btnConetar_Click(object sender, EventArgs e)
        {
            if (!estaConetada)
            {
                conetarParaArduino();
            }
            else
            {
                desconetarParaArduino();
            }
        }

        private void BuscarAvaliarPortas()
        {
            portas = SerialPort.GetPortNames();
        }

        private void conetarParaArduino()
        {
            estaConetada = true;
            string selecionaPorta = cmbPortas.Texts;
            porta = new SerialPort(selecionaPorta, 9600, Parity.None, 8, StopBits.One);
            porta.Open();
            btnConetar.Text = "Desconectar";
            btnLigar.Enabled = true;
            btnDesligar.Enabled = true;
            panel.BackColor = Color.FromArgb(128, 255, 128);
            btnConetar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
        }

        private void desconetarParaArduino()
        {
            estaConetada = false;
            btnLigar.Enabled = false;
            btnDesligar.Enabled = false;
            btnConetar.Text = "Ligar";
            panel.BackColor = Color.FromArgb(255, 128, 128);
            btnConetar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            porta.Close();
        }
        private void btnLigar_Click(object sender, EventArgs e)
        {
            try
            {
                //PortaSerial.Open();
                //if (PortaSerial.IsOpen)
                //{
                //    PortaSerial.WriteLine("1");
                //}
                //PortaSerial.Close();

                porta.WriteLine("1");
                btnLigar.BackColor = Color.MediumSpringGreen;
                btnDesligar.BackColor = Color.FromArgb(80, 138, 186);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            try
            {
                //PortaSerial.Open();
                //if (PortaSerial.IsOpen)
                //{
                //    PortaSerial.WriteLine("0");
                //}
                //PortaSerial.Close()

                porta.WriteLine("0");
                btnDesligar.BackColor = Color.Crimson;
                btnLigar.BackColor = Color.FromArgb(80, 138, 186);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            _mousePosition = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - _mousePosition.X;
                this.Top = e.Y + this.Top - _mousePosition.Y;
            }
        }


    }
}
