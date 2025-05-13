using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeVerificacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo está vazio
            if(txbNomeAcesso.Text == "")
            {
                MessageBox.Show("O campo nome não pode estar vazio!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSobrenome.Text == "")
            {
                MessageBox.Show("O campo Sobrenome não pode estar vazio!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbAnonasc.Text == "")
            {
                MessageBox.Show("O campo Ano nascimento não pode estar vazio!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Calcular a idade
                int idade = DateTime.Now.Year - int.Parse(txbAnonasc.Text);
                if (idade >= 18)
                {
                    pibResultado.Image = Properties.Resources.ok;
                    lblAprovado.Text = $"{txbNomeAcesso.Text} {txbSobrenome.Text} Bem vindo!\n Você tem {idade} Anos.";

                }
                else
                {
                    pibResultado.Image = Properties.Resources.error;
                    lblAprovado.Text = "Não pode entrar!";
                }

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar todos os campos de entrada
            txbNomeAcesso.Clear();
            txbSobrenome.Clear();
            txbAnonasc.Clear();
            lblNomeConsulta.Text = "";
            lblAprovado.Text = "";
            pibResultado.Image = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Fechar o aplicativo
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
