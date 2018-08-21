namespace EtecMetodoGenerics
{
    partial class CadastrarCliente
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
            this.btnCadCli = new System.Windows.Forms.Button();
            this.endereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtCadNmCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCadCodigoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNmCliente = new System.Windows.Forms.Label();
            this.txtNmCliente = new System.Windows.Forms.TextBox();
            this.nrTelefone = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clientePedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientePedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadCli
            // 
            this.btnCadCli.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadCli.Location = new System.Drawing.Point(527, 654);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(151, 27);
            this.btnCadCli.TabIndex = 39;
            this.btnCadCli.Text = "Cadastrar";
            this.btnCadCli.UseVisualStyleBackColor = false;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // endereco
            // 
            this.endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco.Location = new System.Drawing.Point(101, 654);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(420, 26);
            this.endereco.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 657);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 623);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 623);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data de nascimento: ";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNascimento.Location = new System.Drawing.Point(179, 621);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(161, 26);
            this.dtNascimento.TabIndex = 33;
            // 
            // txtCadNmCliente
            // 
            this.txtCadNmCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadNmCliente.Location = new System.Drawing.Point(254, 584);
            this.txtCadNmCliente.Name = "txtCadNmCliente";
            this.txtCadNmCliente.Size = new System.Drawing.Size(424, 26);
            this.txtCadNmCliente.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nome:";
            // 
            // txtCadCodigoCliente
            // 
            this.txtCadCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadCodigoCliente.Location = new System.Drawing.Point(45, 584);
            this.txtCadCodigoCliente.Name = "txtCadCodigoCliente";
            this.txtCadCodigoCliente.Size = new System.Drawing.Size(144, 26);
            this.txtCadCodigoCliente.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID:";
            // 
            // lblNmCliente
            // 
            this.lblNmCliente.AutoSize = true;
            this.lblNmCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmCliente.Location = new System.Drawing.Point(13, 9);
            this.lblNmCliente.Name = "lblNmCliente";
            this.lblNmCliente.Size = new System.Drawing.Size(127, 20);
            this.lblNmCliente.TabIndex = 25;
            this.lblNmCliente.Text = "Nome do cliente:";
            // 
            // txtNmCliente
            // 
            this.txtNmCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmCliente.Location = new System.Drawing.Point(146, 6);
            this.txtNmCliente.Name = "txtNmCliente";
            this.txtNmCliente.Size = new System.Drawing.Size(404, 26);
            this.txtNmCliente.TabIndex = 24;
            this.txtNmCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNmProduto_KeyUp);
            this.txtNmCliente.Leave += new System.EventHandler(this.txtNmCliente_Leave);
            // 
            // nrTelefone
            // 
            this.nrTelefone.Location = new System.Drawing.Point(444, 621);
            this.nrTelefone.Mask = "(##)####-####";
            this.nrTelefone.Name = "nrTelefone";
            this.nrTelefone.Size = new System.Drawing.Size(234, 24);
            this.nrTelefone.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(570, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 26);
            this.button1.TabIndex = 43;
            this.button1.Text = "RELOAD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientePedidoBindingSource
            // 
            this.clientePedidoBindingSource.DataSource = typeof(Classes.ClientePedido);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(16, 41);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(662, 537);
            this.dgvCliente.TabIndex = 44;
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 686);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nrTelefone);
            this.Controls.Add(this.btnCadCli);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.txtCadNmCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCadCodigoCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNmCliente);
            this.Controls.Add(this.txtNmCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarCliente";
            this.Load += new System.EventHandler(this.CadastrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientePedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadCli;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.TextBox txtCadNmCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCadCodigoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource clientePedidoBindingSource;
        private System.Windows.Forms.Label lblNmCliente;
        private System.Windows.Forms.TextBox txtNmCliente;
        private System.Windows.Forms.MaskedTextBox nrTelefone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCliente;

    }
}