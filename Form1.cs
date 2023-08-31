using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        private double peso;
        private double altura;
        private double calculoimc;

        public Form1()
        {
            InitializeComponent();
        }

        private void leiaValores()
        {
            try
            {
                peso = Double.Parse(tbPeso.Text);
                altura = Double.Parse(tbAltura.Text);

            }
            catch (Exception)
            {
                MessageBox.Show(this, "Digite números!");
                tbPeso.Text = "";
                tbAltura.Text = "";
                peso = 0;
                altura = 0;
            }
        }

        private void btCalcula_Click(object sender, EventArgs e)
        {
            leiaValores();

            altura = altura / 100.0;
            calculoimc = peso / (altura * altura);
            lblImc.Text = calculoimc.ToString();

            rd1.Checked = false;
            rd2.Checked = false;
            rd3.Checked = false;
            rd4.Checked = false;
            rd5.Checked = false;
            rd6.Checked = false;
            rd7.Checked = false;

            if (calculoimc < 17)
            {
                rd1.Checked = true;
            }
            else if (calculoimc >= 17 && calculoimc <= 18.49)
            {
                rd2.Checked = true;
            }
            else if (calculoimc >= 18.5 && calculoimc <= 24.99)
            {
                rd3.Checked = true;
            }
            else if (calculoimc >= 25 && calculoimc <= 29.99)
            {
                rd4.Checked = true;
            }
            else if (calculoimc >= 30 && calculoimc <= 34.99)
            {
                rd5.Checked = true;
            }
            else if (calculoimc >= 35 && calculoimc <= 39.99)
            {
                rd6.Checked = true;
            }
            else if (calculoimc >= 40)
            {
                rd7.Checked = true;
            }
        }
    }
}