using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estacionamentoLeonardo.View.Carro
{
    public partial class TelaCarro : Form
    {
        public TelaCarro()
        {
            InitializeComponent();
        }

        public void Validar()
        {

            string carro = Convert.ToString(cbxCarro.SelectedItem);
            string cor = Convert.ToString(cbxCor.SelectedItem);
            string marca = Convert.ToString(cbxMarca.SelectedItem);

            if (string.IsNullOrEmpty(carro))
            {
                MessageBox.Show("Selecione um carro");

            }

            else if (string.IsNullOrEmpty(cor))
            {
                MessageBox.Show("Selecione uma cor");
            }

            else if (string.IsNullOrEmpty(marca))
            {
                MessageBox.Show("Selecione uma marca");
            }

            else if (string.IsNullOrEmpty(tbxPlaca.Text))
            {
                MessageBox.Show("Selecione uma placa");
            }

            else
            {
                MessageBox.Show("Carro cadastrado sucesso.");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void TelaCarro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Validar();
            }
        }
    }
}
