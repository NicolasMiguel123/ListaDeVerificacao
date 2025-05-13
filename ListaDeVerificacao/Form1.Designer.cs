namespace ListaDeVerificacao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbVerificador = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txbAnonasc = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txbNomeAcesso = new System.Windows.Forms.TextBox();
            this.lblNomeConsulta = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibResultado = new System.Windows.Forms.PictureBox();
            this.lblAprovado = new System.Windows.Forms.Label();
            this.grbVerificador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // grbVerificador
            // 
            this.grbVerificador.Controls.Add(this.lblAprovado);
            this.grbVerificador.Controls.Add(this.pibResultado);
            this.grbVerificador.Controls.Add(this.btnSair);
            this.grbVerificador.Controls.Add(this.btnLimpar);
            this.grbVerificador.Controls.Add(this.btnVerificar);
            this.grbVerificador.Controls.Add(this.txbAnonasc);
            this.grbVerificador.Controls.Add(this.lblAno);
            this.grbVerificador.Controls.Add(this.txbSobrenome);
            this.grbVerificador.Controls.Add(this.lblSobrenome);
            this.grbVerificador.Controls.Add(this.txbNomeAcesso);
            this.grbVerificador.Controls.Add(this.lblNomeConsulta);
            this.grbVerificador.Location = new System.Drawing.Point(19, 79);
            this.grbVerificador.Name = "grbVerificador";
            this.grbVerificador.Size = new System.Drawing.Size(424, 342);
            this.grbVerificador.TabIndex = 3;
            this.grbVerificador.TabStop = false;
            this.grbVerificador.Text = "Verificador";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(264, 297);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(123, 35);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(135, 297);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 35);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(6, 297);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(123, 35);
            this.btnVerificar.TabIndex = 14;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txbAnonasc
            // 
            this.txbAnonasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAnonasc.Location = new System.Drawing.Point(6, 170);
            this.txbAnonasc.Name = "txbAnonasc";
            this.txbAnonasc.Size = new System.Drawing.Size(113, 24);
            this.txbAnonasc.TabIndex = 13;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(6, 147);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(80, 20);
            this.lblAno.TabIndex = 12;
            this.lblAno.Text = "Ano nasc:";
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSobrenome.Location = new System.Drawing.Point(6, 111);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(113, 24);
            this.txbSobrenome.TabIndex = 11;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(6, 88);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(96, 20);
            this.lblSobrenome.TabIndex = 10;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txbNomeAcesso
            // 
            this.txbNomeAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeAcesso.Location = new System.Drawing.Point(6, 54);
            this.txbNomeAcesso.Name = "txbNomeAcesso";
            this.txbNomeAcesso.Size = new System.Drawing.Size(113, 24);
            this.txbNomeAcesso.TabIndex = 5;
            // 
            // lblNomeConsulta
            // 
            this.lblNomeConsulta.AutoSize = true;
            this.lblNomeConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeConsulta.Location = new System.Drawing.Point(3, 31);
            this.lblNomeConsulta.Name = "lblNomeConsulta";
            this.lblNomeConsulta.Size = new System.Drawing.Size(55, 20);
            this.lblNomeConsulta.TabIndex = 4;
            this.lblNomeConsulta.Text = "Nome:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(315, 39);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Controle de acesso";
            // 
            // pibResultado
            // 
            this.pibResultado.Location = new System.Drawing.Point(194, 19);
            this.pibResultado.Name = "pibResultado";
            this.pibResultado.Size = new System.Drawing.Size(209, 199);
            this.pibResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibResultado.TabIndex = 17;
            this.pibResultado.TabStop = false;
            // 
            // lblAprovado
            // 
            this.lblAprovado.AutoSize = true;
            this.lblAprovado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprovado.Location = new System.Drawing.Point(190, 221);
            this.lblAprovado.Name = "lblAprovado";
            this.lblAprovado.Size = new System.Drawing.Size(0, 20);
            this.lblAprovado.TabIndex = 18;
            this.lblAprovado.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 444);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbVerificador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbVerificador.ResumeLayout(false);
            this.grbVerificador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbVerificador;
        private System.Windows.Forms.TextBox txbNomeAcesso;
        private System.Windows.Forms.Label lblNomeConsulta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txbAnonasc;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.PictureBox pibResultado;
        private System.Windows.Forms.Label lblAprovado;
    }
}

