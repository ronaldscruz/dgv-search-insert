using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EtecMetodoGenerics
{
    public partial class CadastrarProduto : Form
    {

        List<CadastrarProduto> lista_produto = new List<CadastrarProduto>();

        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {
            inserirProduto();
            carregarGrid();
        }

        private void txtNmProduto_KeyUp(object sender, KeyEventArgs e)
        {
            List<CadastrarProduto> lista_pesquisa = new List<adastrarProduto>();
            lista_pesquisa = lista_produto;

            lista_pesquisa = lista_pesquisa.Where(i => i.txtCadNmProduto.Contains(txtNmProduto.Text) && i.txtCadMarca.Contains(txtMarca.Text)).ToList();
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = lista_pesquisa;
        }

        private void txtMarca_KeyUp(object sender, KeyEventArgs e)
        {
            List<adastrarProduto> lista_pesquisa = new List<adastrarProduto>();
            lista_pesquisa = lista_produto;

            lista_pesquisa = lista_pesquisa.Where(i => i.nmProduto.Contains(txtNmProduto.Text) && i.marca.Contains(txtMarca.Text)).ToList();
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = lista_pesquisa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNmProduto.Text = "";
            txtMarca.Text = "";
            dgvProdutos.DataSource = null;
            carregarGrid();
        }

        private void inserirProduto() {
            CadastrarProduto produto1 = new CadastrarProduto();
            produto1.idProduto = 1;
            produto1.txtCadNmProduto = "lapis";
            produto1.txtCadMarca = "bic";
            produto1.txtPreco = "0.60";

            lista_produto.Add(pedido1);

            CadastrarProduto produto2 = new CadastrarProduto();
            produto2.txtIdProduto = 2;
            produto2.txtCadNmProduto = "borracha";
            produto2.txtCadMarca = "faber castell";
            produto2.txtPreco = "1.50";

            lista_produto.Add(produto2);

            CadastrarProduto produto3 = new CadastrarProduto();
            produto3.txtIdProduto = 3;
            produto3.txtCadNmProduto = "caneta";
            produto3.txtCadMarca = "bic";
            produto3.txtPreco = "1.20";

            lista_produto.Add(produto3);
        }

        public void carregarGrid() {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = lista_produto;
        }





    }
}
