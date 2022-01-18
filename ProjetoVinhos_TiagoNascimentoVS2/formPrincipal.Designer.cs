
namespace ProjetoVinhos_TiagoNascimentoVS2
{
    partial class formPrincipal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonVinhos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonProdutores = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCastas = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEnologo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRegioes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonVinhos,
            this.toolStripButtonProdutores,
            this.toolStripButtonCastas,
            this.toolStripButtonEnologo,
            this.toolStripButtonRegioes,
            this.toolStripButtonSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonVinhos
            // 
            this.toolStripButtonVinhos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonVinhos.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.Serving_wine256px;
            this.toolStripButtonVinhos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonVinhos.Name = "toolStripButtonVinhos";
            this.toolStripButtonVinhos.Size = new System.Drawing.Size(69, 22);
            this.toolStripButtonVinhos.Text = "Vinhos";
            this.toolStripButtonVinhos.Click += new System.EventHandler(this.toolStripButtonVinhos_Click);
            // 
            // toolStripButtonProdutores
            // 
            this.toolStripButtonProdutores.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonProdutores.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.Barrels_storage512px;
            this.toolStripButtonProdutores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProdutores.Name = "toolStripButtonProdutores";
            this.toolStripButtonProdutores.Size = new System.Drawing.Size(96, 22);
            this.toolStripButtonProdutores.Text = "Produtores";
            this.toolStripButtonProdutores.Click += new System.EventHandler(this.toolStripButtonProdutores_Click);
            // 
            // toolStripButtonCastas
            // 
            this.toolStripButtonCastas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonCastas.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.Grape256px;
            this.toolStripButtonCastas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCastas.Name = "toolStripButtonCastas";
            this.toolStripButtonCastas.Size = new System.Drawing.Size(67, 22);
            this.toolStripButtonCastas.Text = "Castas";
            this.toolStripButtonCastas.Click += new System.EventHandler(this.toolStripButtonCastas_Click);
            // 
            // toolStripButtonEnologo
            // 
            this.toolStripButtonEnologo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonEnologo.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.Wine_tasting_smell256px;
            this.toolStripButtonEnologo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEnologo.Name = "toolStripButtonEnologo";
            this.toolStripButtonEnologo.Size = new System.Drawing.Size(84, 22);
            this.toolStripButtonEnologo.Text = "Enólogos";
            this.toolStripButtonEnologo.Click += new System.EventHandler(this.toolStripButtonEnologo_Click);
            // 
            // toolStripButtonRegioes
            // 
            this.toolStripButtonRegioes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonRegioes.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.map;
            this.toolStripButtonRegioes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRegioes.Name = "toolStripButtonRegioes";
            this.toolStripButtonRegioes.Size = new System.Drawing.Size(75, 22);
            this.toolStripButtonRegioes.Text = "Regiões";
            this.toolStripButtonRegioes.Click += new System.EventHandler(this.toolStripButtonRegioes_Click);
            // 
            // toolStripButtonSair
            // 
            this.toolStripButtonSair.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonSair.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_delete_480;
            this.toolStripButtonSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSair.Name = "toolStripButtonSair";
            this.toolStripButtonSair.Size = new System.Drawing.Size(50, 22);
            this.toolStripButtonSair.Text = "Sair";
            this.toolStripButtonSair.Click += new System.EventHandler(this.toolStripButtonSair_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formPrincipal";
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonVinhos;
        private System.Windows.Forms.ToolStripButton toolStripButtonProdutores;
        private System.Windows.Forms.ToolStripButton toolStripButtonCastas;
        private System.Windows.Forms.ToolStripButton toolStripButtonEnologo;
        private System.Windows.Forms.ToolStripButton toolStripButtonRegioes;
        private System.Windows.Forms.ToolStripButton toolStripButtonSair;
    }
}