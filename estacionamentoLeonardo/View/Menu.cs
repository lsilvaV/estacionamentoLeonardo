using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//importando telas
using estacionamentoLeonardo.View.Cliente;
using estacionamentoLeonardo.View.Carro;
using estacionamentoLeonardo.View.Ticket;

namespace estacionamentoLeonardo.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente.TelaCliente cliente = new Cliente.TelaCliente();
            cliente.ShowDialog();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            Carro.TelaCarro carro = new Carro.TelaCarro();
            carro.ShowDialog();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            Ticket.TelaTicket ticket = new Ticket.TelaTicket();
            ticket.ShowDialog();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feito por Leonardo S. Vicente :)");
        }
    }
}
