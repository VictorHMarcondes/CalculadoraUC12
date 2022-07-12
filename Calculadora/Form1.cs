using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        // Variável global:
        bool clicouNoOperador = true;
        int acumuladora;
        string ultimOp;
        public Form1()


        {
            InitializeComponent();
        }

        private void Numero_Click(object sender, EventArgs e)

        {
            if (txtTela.Text == "ERRO!")
            {
                txtTela.Text = null;
                clicouNoOperador = true;
            }
            else
            {
                var btnClicado = sender as Button;
                txtTela.Text += btnClicado.Text;

                clicouNoOperador = false;
            }
        }
        private void Operacao_Click(object sender, EventArgs e)
        {
            var btnClicado = sender as Button;
            // Só atribuir na tela se não tiver clicado no operador:
            if (clicouNoOperador == false)
            {
                // Salvar na acumuladora o valor digitado:
                if (txtTela.Text == "ERRO!")
                {
                    txtTela.Text = null;
                    clicouNoOperador= true;
                }
                else
                {
                    acumuladora += int.Parse(txtTela.Text);
                    txtAux.Text = txtTela.Text + btnClicado.Text;
                    txtTela.Text = "";
                    //txtTela.Text = acumuladora.Tostring();
                    clicouNoOperador = true;
                    ultimOp = btnClicado.Text;

                    //.Text += btnClicado.Text;
                    clicouNoOperador = true;
                }

                






            }

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (ultimOp)
            {
                case "+":
                    txtTela.Text = (acumuladora + int.Parse(txtTela.Text)).ToString();
                    break;
            

                case "-":
                    txtTela.Text = (acumuladora - int.Parse(txtTela.Text)).ToString();
                break;
            
            
                case "*":
                    
                    txtTela.Text = (acumuladora * int.Parse(txtTela.Text)).ToString();
                break;
            
            
                case "/":

                    if (txtTela.Text == "0")
                        txtTela.Text = "ERRO!";
                    else

                    txtTela.Text = (acumuladora / int.Parse(txtTela.Text)).ToString();
                   

                        break;


                      



            }
            txtAux.Text = "";
            acumuladora = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //LIMPAR TELA
            txtTela.Text = null;
            clicouNoOperador = true;
        }
    }
}


