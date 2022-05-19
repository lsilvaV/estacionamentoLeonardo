using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estacionamentoLeonardo.View.Ticket
{
    public partial class TelaTicket : Form
    {
        public TelaTicket()
        {
            InitializeComponent();
        }

        public void Validar()
        {

            string cor = Convert.ToString(cbxCor.SelectedItem);

            if (string.IsNullOrEmpty(tbxNome.Text))
            {
                MessageBox.Show("Preencha o nome.");

            }

            else if (string.IsNullOrEmpty(tbxPlaca.Text))
            {
                MessageBox.Show("Preencha a placa do carro.");
            }

            else if (string.IsNullOrEmpty(cor))
            {
                MessageBox.Show("Selecione uma cor.");
            }

            else
            {
                MessageBox.Show("Ticket cadastrado sucesso.");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void TelaTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Validar();
            }
        }
    }
}
