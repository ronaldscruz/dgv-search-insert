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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        List<ClientePedido> lista_pedido = new List<ClientePedido>();

        private void Pedidos_Load(object sender, EventArgs e)
        {
            inserirPedido();
            carregarGrid();
        }

        private void txtNmProduto_KeyUp(object sender, KeyEventArgs e)
        {
            List<ClientePedido> lista_pesquisa = new List<ClientePedido>();
            lista_pesquisa = lista_pedido;

            lista_pesquisa = lista_pesquisa.Where(i => i.nmProduto.Contains(txtNmProduto.Text) && i.marca.Contains(txtMarca.Text)).ToList();
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = lista_pesquisa;
        }

        private void txtMarca_KeyUp(object sender, KeyEventArgs e)
        {
            List<ClientePedido> lista_pesquisa = new List<ClientePedido>();
            lista_pesquisa = lista_pedido;

            lista_pesquisa = lista_pesquisa.Where(i => i.nmProduto.Contains(txtNmProduto.Text) && i.marca.Contains(txtMarca.Text)).ToList();
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = lista_pesquisa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNmProduto.Text = "";
            txtMarca.Text = "";
            dgvPedidos.DataSource = null;
            carregarGrid();
        }

        private void inserirPedido() {
            ClientePedido pedido1 = new ClientePedido();
            pedido1.idPedido = 1;
            pedido1.nmProduto = "lapis";
            pedido1.marca = "bic";
            pedido1.dtPedido = Convert.ToDateTime("2018-08-10");
            pedido1.preco = "0.60";

            lista_pedido.Add(pedido1);

            ClientePedido pedido2 = new ClientePedido();
            pedido2.idPedido = 2;
            pedido2.nmProduto = "borracha";
            pedido2.marca = "faber castell";
            pedido2.dtPedido = Convert.ToDateTime("2018-08-11");
            pedido2.preco = "1.50";

            lista_pedido.Add(pedido2);

            ClientePedido pedido3 = new ClientePedido();
            pedido3.idPedido = 3;
            pedido3.nmProduto = "caneta";
            pedido3.marca = "bic";
            pedido3.dtPedido = Convert.ToDateTime("2018-08-11");
            pedido3.preco = "1.20";

            lista_pedido.Add(pedido3);

            ClientePedido pedido4 = new ClientePedido();
            pedido4.idPedido = 4;
            pedido4.nmProduto = "apontador";
            pedido4.marca = "faber castell";
            pedido4.dtPedido = Convert.ToDateTime("2018-08-10");
            pedido4.preco = "2.00";

            lista_pedido.Add(pedido4);

            ClientePedido pedido5 = new ClientePedido();
            pedido5.idPedido = 5;
            pedido5.nmProduto = "pasta";
            pedido5.marca = "dac";
            pedido5.dtPedido = Convert.ToDateTime("2018-08-11");
            pedido5.preco = "2.50";

            lista_pedido.Add(pedido5);
        }

        private void carregarGrid() {
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = lista_pedido;
        }

        private void btnCadPed_Click(object sender, EventArgs e)
        {
            ClientePedido p = new ClientePedido();
            p.idPedido = Convert.ToInt32(idPedido.Text);
            p.nmProduto = nmProduto.Text;
            p.marca = marca.Text;
            p.dtPedido = Convert.ToDateTime(dtPedido.Text);
            p.preco = preco.Text;

            lista_pedido.Add(p);

            carregarGrid();

        }

        private void txtNmProduto_Leave(object sender, EventArgs e)
        {
            carregarGrid();
            txtNmProduto.Text = "";
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            carregarGrid();
            txtMarca.Text = "";


        }



    }
}
