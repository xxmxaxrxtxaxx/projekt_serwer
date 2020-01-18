using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;


namespace Lab1
{
    public partial class Form1 : Form
    {
        private SerialPort _port;

        public event EventHandler<string> OdczytanoDane;

        public Form1()
        {
            InitializeComponent();


            b_psk_btn.Checked = true;
            dl_btn.Checked = true;
            portyCOM.Items.Clear();
            String[] porty = SerialPort.GetPortNames();
            portyCOM.Items.AddRange(porty);

            OdczytanoDane += OdczytanoDane_handler;
        }

        private void OdczytanoDane_handler(object sender, string text)
        {
            var forma = (Form1)sender;
            forma.ZapiszOdcztyanyTekst(text);
        }
        public void ZapiszOdcztyanyTekst(string text)
        {
            odbior.Text += text;
        }

        private byte modulacja()
        {
            int numerModulacji = 0;
            if (b_psk_btn.Checked)
            {
                numerModulacji = 0;
            }
            else if (q_psk_btn.Checked)
            {
                numerModulacji = 1;
            }
            else if (psk_8_btn.Checked)
            {
                numerModulacji = 2;
            }
            
            numerModulacji = numerModulacji << 4;

            if (fec_btn.Checked)
            {
                numerModulacji = numerModulacji | 8;
            }           
           
            return (byte)numerModulacji;
        }
        private void odswiez_hex()
        {
            List<byte> bytes = new List<byte>();
            bytes.Add(modulacja());
            bytes.AddRange(Encoding.ASCII.GetBytes(nadaj_asci.Text));
   
            byte[] ramka = makeFrame(tryb(), bytes.ToArray()).ToArray();
            nadaj_hex.Text = BitConverter.ToString(ramka);
        }
  //     strona w dokumentacji 26 
        private byte tryb()
        {
            byte tryb = 0x50;
            if (dl_btn.Checked)
            {
                tryb = 0x50;
            }
            else if (phy_btn.Checked)
            {
                tryb = 0x24;
            }
            return tryb;
        }

        private List<byte> makeFrame(byte tryb, byte[] dane)
        {
            List<byte> listaDanych = new List<byte>();
            listaDanych.Add(0x02);
            listaDanych.Add((byte)dane.Length);
            listaDanych.Add(tryb);
            foreach (var d in dane)
            {
                listaDanych.Add(d);
            }
            uint sumaKontrolna = 0;
            foreach(var l in listaDanych)
            {
                sumaKontrolna += l;
            }
            byte suma = (byte)sumaKontrolna;
            listaDanych.Add(suma);
           
        
            return listaDanych;
        }


    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  
 
        private void fec_btn_CheckedChanged(object sender, EventArgs e)
        {
            odswiez_hex();
        }

        private void nadaj_asci_TextChanged(object sender, EventArgs e)
        {
            odswiez_hex();

        }

        private void otworzCom_Click(object sender, EventArgs e)
        {
            if (_port != null)
            {
                return;
            }

            string wybranyPort = portyCOM.Text;


            if (!string.IsNullOrWhiteSpace(wybranyPort))
            {
                _port = new SerialPort(wybranyPort);
                _port.Open();
                _port.DataReceived += _port_DataReceived;
            }
      
        }

        private void _port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var comPort = (SerialPort)sender;
            while (comPort.BytesToRead > 0)
            {
                 string text = comPort.ReadExisting();
                if(OdczytanoDane != null)
                {
                    OdczytanoDane(this, text);
                }
            }          
           
        }

        private void wyslij_btn_Click(object sender, EventArgs e)
        {
            string wyslany_tekst = nadaj_hex.Text;
            if (_port != null)
            {
                if (!string.IsNullOrWhiteSpace(wyslany_tekst))
                {
                    string[] bajty_do_wyslania= wyslany_tekst.Split('-');
                    List<byte> lista = new List<byte>();
                    foreach ( var bajt in bajty_do_wyslania)
                    {
                        lista.Add(byte.Parse(bajt, System.Globalization.NumberStyles.HexNumber));
                    }
                    _port.Write(lista.ToArray(), 0, lista.Count);
                        


                }
            }
        }

        private void zamknijCOM_btn_Click(object sender, EventArgs e)
        {
            if (_port != null)
            {
                _port.Close();
                _port.DataReceived -= _port_DataReceived;
                _port = null;
            }
        }

        private void wyczysc_btn_Click(object sender, EventArgs e)
        {
            nadaj_asci.Text = "";
            nadaj_hex.Text = "";
            odbior.Text = "";
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {

        }

        private void phy_btn_CheckedChanged(object sender, EventArgs e)
        {
            odswiez_hex();
        }

        private void dl_btn_CheckedChanged(object sender, EventArgs e)
        {
            odswiez_hex();
        }

        private void b_psk_btn_CheckedChanged(object sender, EventArgs e)
        {
            odswiez_hex();
        }

        private void q_psk_btn_CheckedChanged(object sender, EventArgs e)
        {
            odswiez_hex();
        }

        private void psk_8_btn_CheckedChanged(object sender, EventArgs e)
        {
            odswiez_hex();
        }
    }
}
