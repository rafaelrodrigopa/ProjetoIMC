using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeIMC
{

    public partial class FrmIMC : Form
    {

        

        public FrmIMC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float peso, altura, imc, pesoMinimo, pesoMaximo, imcMinimo, imcMaximo;
            String situacao;


            if (!(txtPeso.Text.Equals("") && txtAltura.Text.Equals("")))
            {

                peso = Convert.ToSingle(txtPeso.Text);
                altura = Convert.ToSingle(txtAltura.Text);

                imc = peso / (altura * altura);

                if((altura * altura) > 6) 
                {
                    MessageBox.Show("Favor, utilizar a virgula como separador decimal");
                }
                else
                {
                    if (imc < 17)
                    {
                        situacao = "Muito abaixo do peso";
                        imcMinimo = 1;
                        imcMaximo = 16;
                    }
                    else if (imc < 18.49)
                    {
                        situacao = "Abaixo do peso";
                        imcMinimo = 17;
                        imcMaximo = 18.49f;
                    }
                    else if (imc < 24.49)
                    {
                        situacao = "Peso normal";
                        imcMinimo = 18.50f;
                        imcMaximo = 24.99f;
                    }
                    else if (imc < 29.99)
                    {
                        situacao = "Acima do peso";
                        imcMinimo = 25;
                        imcMaximo = 29.99f;
                    }
                    else if (imc < 34.99)
                    {
                        situacao = "Obesidade I";
                        imcMinimo = 30;
                        imcMaximo = 34.99f;
                    }
                    else if (imc < 39.99)
                    {
                        situacao = "Obesidade II (Severa)";
                        imcMinimo = 35;
                        imcMaximo = 39.99f;
                    }
                    else
                    {
                        situacao = "Obesidade III (Mórbida)";
                        imcMinimo = 40;
                        imcMaximo = 62.22f;
                    }

                    lblIMC.Text = imc.ToString("N2");
                    lblSituacao.Text = situacao;

                    pesoMinimo = imcMinimo * (altura * altura);
                    pesoMaximo = imcMaximo * (altura * altura);

                    lblPesoMinimo.Text = pesoMinimo.ToString("N2");
                    lblPesoMaximo.Text = pesoMaximo.ToString("N2");
                }

            }
            else
            {
                MessageBox.Show("Favor, preencher os campos de peso e altura para calcular o IMC");
            }

        }
    }
}
