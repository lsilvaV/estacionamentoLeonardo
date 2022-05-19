using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estacionamentoLeonardo.View.Cliente
{
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void TelaCliente_Load(object sender, EventArgs e)
        {

        }

        public void validarCPF()
        {
            if (string.IsNullOrEmpty(tbxCPF.Text))
            {
                MessageBox.Show("CPF é obrigatório", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxCPF.Focus();
                tbxCPF.SelectAll();
                return;
            }

            string cpfInformado = tbxCPF.Text.Replace(".", "").Replace("-", "");

            if (cpfInformado.Length != 11)
            {
                MessageBox.Show("Informe um CPF com 11 dígitos.");
                return;
            }

            string cpf = cpfInformado.Substring(0, 9);

            int soma = 0;
            int valorRef = 10;

            for (int i = 0; i <= 8; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }

            int dv1 = (int)soma % 11;

            if (dv1 < 2)
            {
                dv1 = 0;
            }
            else
            {
                dv1 = 11 - dv1;
            }

            if (!cpfInformado.Substring(9, 1).Equals(dv1.ToString()))
            {
                MessageBox.Show("Informe um CPF válido");
                return;
            }

            cpf = cpf + dv1.ToString();
            valorRef = 11;
            soma = 0;

            for (int i = 0; i <= 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }

            int dv2 = (int)soma % 11;

            if (dv2 < 2)
            {
                dv2 = 0;
            }
            else
            {
                dv2 = 11 - dv2;
            }

            if (!cpfInformado.Substring(10, 1).Equals(dv2.ToString()))
            {
                MessageBox.Show("Informe um CPF válido");
                return;
            }
            else
            {
                MessageBox.Show("Cliente Cadastrado");
            }

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            validarCPF();
        }

        private void TelaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                validarCPF();
            }
        }
    }
}
