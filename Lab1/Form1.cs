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
        public Form1()
        {
            InitializeComponent();

            b_psk_btn.Checked = true;
            dl_btn.Checked = true;
            comboBox1.Items.Clear();
            String[] porty = SerialPort.GetPortNames();
            
            foreach (String x in porty)           
                comboBox1.Items.AddRange(porty);

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

        
 

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void polaczenie_box_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nadaj_hex.Clear();
            nadaj_asci.Clear();
            odbior.Clear();
        }

        private void fec_btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nadaj_asci_TextChanged(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(nadaj_asci.Text);
            byte [] ramka = makeFrame(tryb(),bytes).ToArray();
            nadaj_hex.Text = BitConverter.ToString(ramka);

            //usunięcie myślników (.Replace("-","");
        }

        private void otworzCom_Click(object sender, EventArgs e)
        {

        }

        private void wyslij_btn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
