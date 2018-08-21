using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;

namespace EtecMetodoGenerics
{
    public partial class CadastrarCliente : Form
    {
        List<Cliente> lista_cliente = new List<Cliente>();

        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            inserirCliente();
            carregarGrid();
        }

        private void txtNmProduto_KeyUp(object sender, KeyEventArgs e)
        {
            List<Cliente> lista_pesquisa = new List<Cliente>();
            lista_pesquisa = lista_cliente;

            lista_pesquisa = lista_pesquisa.Where(i => i.nmCliente.Contains(txtNmCliente.Text)).ToList();
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = lista_pesquisa;
        }

        public void inserirCliente() {
            Cliente c1 = new Cliente();
            c1.codigoCliente = 1;
            c1.nmCliente = "Bruna Emanuele";
            c1.nrTelefone = "(11)1234-5678";
            c1.endereco = "Jd Mamba";
            c1.dtNascimento = Convert.ToDateTime("2000-02-02");
            lista_cliente.Add(c1);

            Cliente c2 = new Cliente();
            c2.codigoCliente = 2;
            c2.nmCliente = "Vinicius Alves";
            c2.nrTelefone = "(11)1234-5678";
            c2.endereco = "Jd Sakura";
            c2.dtNascimento = Convert.ToDateTime("1999-01-01");
            lista_cliente.Add(c2);

            Cliente c3 = new Cliente();
            c3.codigoCliente = 3;
            c3.nmCliente = "Cabelinho de Pipoca";
            c3.nrTelefone = "(11)2345-6789";
            c3.endereco = "Jd Low Garden";
            c3.dtNascimento = Convert.ToDateTime("2001-03-03");
            lista_cliente.Add(c3);
        }

        public void carregarGrid() {
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = lista_cliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNmCliente.Text = "";
            carregarGrid();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            Cliente cm = new Cliente();
            cm.codigoCliente = Convert.ToInt32(txtCadCodigoCliente.Text);
            cm.nmCliente = txtCadNmCliente.Text;
            cm.endereco = endereco.Text;
            cm.nrTelefone = nrTelefone.Text;
            cm.dtNascimento = Convert.ToDateTime(dtNascimento.Text);
            lista_cliente.Add(cm);
            carregarGrid();
        }

        private void txtNmCliente_Leave(object sender, EventArgs e)
        {
            carregarGrid();
            txtNmCliente.Text = "";
        }

    }
}
