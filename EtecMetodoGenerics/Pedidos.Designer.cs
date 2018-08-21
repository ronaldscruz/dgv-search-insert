namespace EtecMetodoGenerics
{
    partial class Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.idPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientePedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNmProduto = new System.Windows.Forms.TextBox();
            this.lblNmProduto = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCadPed = new System.Windows.Forms.Button();
            this.marca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPedido = new System.Windows.Forms.DateTimePicker();
            this.nmProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientePedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AutoGenerateColumns = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedidoDataGridViewTextBoxColumn,
            this.nmProdutoDataGridViewTextBoxColumn,
            this.dtPedidoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn});
            this.dgvPedidos.DataSource = this.clientePedidoBindingSource;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 79);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(599, 498);
            this.dgvPedidos.TabIndex = 0;
            // 
            // idPedidoDataGridViewTextBoxColumn
            // 
            this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "idPedido";
            this.idPedidoDataGridViewTextBoxColumn.HeaderText = "idPedido";
            this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
            // 
            // nmProdutoDataGridViewTextBoxColumn
            // 
            this.nmProdutoDataGridViewTextBoxColumn.DataPropertyName = "nmProduto";
            this.nmProdutoDataGridViewTextBoxColumn.HeaderText = "nmProduto";
            this.nmProdutoDataGridViewTextBoxColumn.Name = "nmProdutoDataGridViewTextBoxColumn";
            // 
            // dtPedidoDataGridViewTextBoxColumn
            // 
            this.dtPedidoDataGridViewTextBoxColumn.DataPropertyName = "dtPedido";
            this.dtPedidoDataGridViewTextBoxColumn.HeaderText = "dtPedido";
            this.dtPedidoDataGridViewTextBoxColumn.Name = "dtPedidoDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // clientePedidoBindingSource
            // 
            this.clientePedidoBindingSource.DataSource = typeof(Classes.ClientePedido);
            // 
            // txtNmProduto
            // 
            this.txtNmProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmProduto.Location = new System.Drawing.Point(154, 12);
            this.txtNmProduto.Name = "txtNmProduto";
            this.txtNmProduto.Size = new System.Drawing.Size(341, 26);
            this.txtNmProduto.TabIndex = 1;
            this.txtNmProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNmProduto_KeyUp);
            this.txtNmProduto.Leave += new System.EventHandler(this.txtNmProduto_Leave);
            // 
            // lblNmProduto
            // 
            this.lblNmProduto.AutoSize = true;
            this.lblNmProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmProduto.Location = new System.Drawing.Point(12, 15);
            this.lblNmProduto.Name = "lblNmProduto";
            this.lblNmProduto.Size = new System.Drawing.Size(136, 20);
            this.lblNmProduto.TabIndex = 2;
            this.lblNmProduto.Text = "Nome do produto:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(12, 47);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 20);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(154, 44);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(341, 26);
            this.txtMarca.TabIndex = 8;
            this.txtMarca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMarca_KeyUp);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 57);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCadPed
            // 
            this.btnCadPed.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadPed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadPed.Location = new System.Drawing.Point(460, 657);
            this.btnCadPed.Name = "btnCadPed";
            this.btnCadPed.Size = new System.Drawing.Size(151, 27);
            this.btnCadPed.TabIndex = 22;
            this.btnCadPed.Text = "Cadastrar";
            this.btnCadPed.UseVisualStyleBackColor = false;
            this.btnCadPed.Click += new System.EventHandler(this.btnCadPed_Click);
            // 
            // marca
            // 
            this.marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca.Location = new System.Drawing.Point(76, 657);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(377, 26);
            this.marca.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 660);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Marca:";
            // 
            // preco
            // 
            this.preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preco.Location = new System.Drawing.Point(488, 621);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(122, 26);
            this.preco.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 624);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 627);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Data do pedido:";
            // 
            // dtPedido
            // 
            this.dtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPedido.Location = new System.Drawing.Point(141, 622);
            this.dtPedido.Name = "dtPedido";
            this.dtPedido.Size = new System.Drawing.Size(280, 26);
            this.dtPedido.TabIndex = 16;
            // 
            // nmProduto
            // 
            this.nmProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmProduto.Location = new System.Drawing.Point(254, 587);
            this.nmProduto.Name = "nmProduto";
            this.nmProduto.Size = new System.Drawing.Size(356, 26);
            this.nmProduto.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 590);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome:";
            // 
            // idPedido
            // 
            this.idPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPedido.Location = new System.Drawing.Point(45, 590);
            this.idPedido.Name = "idPedido";
            this.idPedido.Size = new System.Drawing.Size(144, 26);
            this.idPedido.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 692);
            this.Controls.Add(this.btnCadPed);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPedido);
            this.Controls.Add(this.nmProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblNmProduto);
            this.Controls.Add(this.txtNmProduto);
            this.Controls.Add(this.dgvPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientePedidoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientePedidoBindingSource;
        private System.Windows.Forms.TextBox txtNmProduto;
        private System.Windows.Forms.Label lblNmProduto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCadPed;
        private System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox preco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPedido;
        private System.Windows.Forms.TextBox nmProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idPedido;
        private System.Windows.Forms.Label label1;
    }
}