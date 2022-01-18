
namespace ProjetoVinhos_TiagoNascimentoVS2
{
    partial class formVinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVinho));
            this.gridVinhos = new System.Windows.Forms.DataGridView();
            this.groupBoxCastas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCastas = new System.Windows.Forms.DataGridView();
            this.buttonDeleteCasta = new System.Windows.Forms.PictureBox();
            this.buttonInsertCasta = new System.Windows.Forms.PictureBox();
            this.labelPercentagemdaCasta = new System.Windows.Forms.Label();
            this.labelCastas = new System.Windows.Forms.Label();
            this.textBoxPercentagem = new System.Windows.Forms.TextBox();
            this.gridVinhosCastas = new System.Windows.Forms.DataGridView();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.textBoxTeorAlcoolico = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.comboBoxRegiao = new System.Windows.Forms.ComboBox();
            this.comboBoxProdutor = new System.Windows.Forms.ComboBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxEnologo = new System.Windows.Forms.ComboBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEnologo = new System.Windows.Forms.Label();
            this.labelProdutor = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTEorAlcoolico = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.panelGuardar = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.PictureBox();
            this.buttonGuardar = new System.Windows.Forms.PictureBox();
            this.panelOpcoes = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.PictureBox();
            this.buttonInsert = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridVinhos)).BeginInit();
            this.groupBoxCastas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCastas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDeleteCasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInsertCasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVinhosCastas)).BeginInit();
            this.panelGuardar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGuardar)).BeginInit();
            this.panelOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVinhos
            // 
            this.gridVinhos.AllowUserToAddRows = false;
            this.gridVinhos.AllowUserToDeleteRows = false;
            this.gridVinhos.AllowUserToResizeColumns = false;
            this.gridVinhos.AllowUserToResizeRows = false;
            this.gridVinhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVinhos.Location = new System.Drawing.Point(8, 9);
            this.gridVinhos.MultiSelect = false;
            this.gridVinhos.Name = "gridVinhos";
            this.gridVinhos.ReadOnly = true;
            this.gridVinhos.RowHeadersVisible = false;
            this.gridVinhos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVinhos.Size = new System.Drawing.Size(929, 221);
            this.gridVinhos.TabIndex = 0;
            this.gridVinhos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVinhos_CellContentClick);
            // 
            // groupBoxCastas
            // 
            this.groupBoxCastas.Controls.Add(this.label1);
            this.groupBoxCastas.Controls.Add(this.gridCastas);
            this.groupBoxCastas.Controls.Add(this.buttonDeleteCasta);
            this.groupBoxCastas.Controls.Add(this.buttonInsertCasta);
            this.groupBoxCastas.Controls.Add(this.labelPercentagemdaCasta);
            this.groupBoxCastas.Controls.Add(this.labelCastas);
            this.groupBoxCastas.Controls.Add(this.textBoxPercentagem);
            this.groupBoxCastas.Controls.Add(this.gridVinhosCastas);
            this.groupBoxCastas.Location = new System.Drawing.Point(8, 452);
            this.groupBoxCastas.Name = "groupBoxCastas";
            this.groupBoxCastas.Size = new System.Drawing.Size(529, 162);
            this.groupBoxCastas.TabIndex = 1;
            this.groupBoxCastas.TabStop = false;
            this.groupBoxCastas.Text = "Castas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Castas do Vinho";
            // 
            // gridCastas
            // 
            this.gridCastas.AllowUserToAddRows = false;
            this.gridCastas.AllowUserToDeleteRows = false;
            this.gridCastas.AllowUserToResizeColumns = false;
            this.gridCastas.AllowUserToResizeRows = false;
            this.gridCastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCastas.Location = new System.Drawing.Point(315, 41);
            this.gridCastas.MultiSelect = false;
            this.gridCastas.Name = "gridCastas";
            this.gridCastas.ReadOnly = true;
            this.gridCastas.RowHeadersVisible = false;
            this.gridCastas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCastas.Size = new System.Drawing.Size(210, 115);
            this.gridCastas.TabIndex = 7;
            this.gridCastas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCastas_CellContentClick);
            // 
            // buttonDeleteCasta
            // 
            this.buttonDeleteCasta.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_sort_right_100;
            this.buttonDeleteCasta.Location = new System.Drawing.Point(248, 110);
            this.buttonDeleteCasta.Name = "buttonDeleteCasta";
            this.buttonDeleteCasta.Size = new System.Drawing.Size(35, 35);
            this.buttonDeleteCasta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonDeleteCasta.TabIndex = 6;
            this.buttonDeleteCasta.TabStop = false;
            this.buttonDeleteCasta.Click += new System.EventHandler(this.buttonDeleteCasta_Click);
            // 
            // buttonInsertCasta
            // 
            this.buttonInsertCasta.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_sort_left_80;
            this.buttonInsertCasta.Location = new System.Drawing.Point(248, 69);
            this.buttonInsertCasta.Name = "buttonInsertCasta";
            this.buttonInsertCasta.Size = new System.Drawing.Size(35, 35);
            this.buttonInsertCasta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonInsertCasta.TabIndex = 5;
            this.buttonInsertCasta.TabStop = false;
            this.buttonInsertCasta.Click += new System.EventHandler(this.buttonInsertCasta_Click);
            // 
            // labelPercentagemdaCasta
            // 
            this.labelPercentagemdaCasta.AutoSize = true;
            this.labelPercentagemdaCasta.Location = new System.Drawing.Point(222, 22);
            this.labelPercentagemdaCasta.Name = "labelPercentagemdaCasta";
            this.labelPercentagemdaCasta.Size = new System.Drawing.Size(87, 16);
            this.labelPercentagemdaCasta.TabIndex = 4;
            this.labelPercentagemdaCasta.Text = "% da Casta";
            // 
            // labelCastas
            // 
            this.labelCastas.AutoSize = true;
            this.labelCastas.Location = new System.Drawing.Point(386, 22);
            this.labelCastas.Name = "labelCastas";
            this.labelCastas.Size = new System.Drawing.Size(56, 16);
            this.labelCastas.TabIndex = 3;
            this.labelCastas.Text = "Castas";
            // 
            // textBoxPercentagem
            // 
            this.textBoxPercentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxPercentagem.Location = new System.Drawing.Point(241, 41);
            this.textBoxPercentagem.Name = "textBoxPercentagem";
            this.textBoxPercentagem.Size = new System.Drawing.Size(49, 22);
            this.textBoxPercentagem.TabIndex = 2;
            // 
            // gridVinhosCastas
            // 
            this.gridVinhosCastas.AllowUserToAddRows = false;
            this.gridVinhosCastas.AllowUserToDeleteRows = false;
            this.gridVinhosCastas.AllowUserToResizeColumns = false;
            this.gridVinhosCastas.AllowUserToResizeRows = false;
            this.gridVinhosCastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVinhosCastas.Location = new System.Drawing.Point(8, 41);
            this.gridVinhosCastas.MultiSelect = false;
            this.gridVinhosCastas.Name = "gridVinhosCastas";
            this.gridVinhosCastas.ReadOnly = true;
            this.gridVinhosCastas.RowHeadersVisible = false;
            this.gridVinhosCastas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVinhosCastas.Size = new System.Drawing.Size(210, 115);
            this.gridVinhosCastas.TabIndex = 0;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxNome.Location = new System.Drawing.Point(16, 271);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(475, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(801, 273);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(122, 22);
            this.textBoxAno.TabIndex = 3;
            // 
            // textBoxTeorAlcoolico
            // 
            this.textBoxTeorAlcoolico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxTeorAlcoolico.Location = new System.Drawing.Point(801, 338);
            this.textBoxTeorAlcoolico.Name = "textBoxTeorAlcoolico";
            this.textBoxTeorAlcoolico.Size = new System.Drawing.Size(122, 22);
            this.textBoxTeorAlcoolico.TabIndex = 4;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxVolume.Location = new System.Drawing.Point(801, 403);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(122, 22);
            this.textBoxVolume.TabIndex = 8;
            // 
            // comboBoxRegiao
            // 
            this.comboBoxRegiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxRegiao.FormattingEnabled = true;
            this.comboBoxRegiao.Location = new System.Drawing.Point(540, 271);
            this.comboBoxRegiao.Name = "comboBoxRegiao";
            this.comboBoxRegiao.Size = new System.Drawing.Size(222, 24);
            this.comboBoxRegiao.TabIndex = 2;
            // 
            // comboBoxProdutor
            // 
            this.comboBoxProdutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxProdutor.FormattingEnabled = true;
            this.comboBoxProdutor.Location = new System.Drawing.Point(281, 401);
            this.comboBoxProdutor.Name = "comboBoxProdutor";
            this.comboBoxProdutor.Size = new System.Drawing.Size(222, 24);
            this.comboBoxProdutor.TabIndex = 6;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(18, 401);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(222, 24);
            this.comboBoxTipo.TabIndex = 5;
            // 
            // comboBoxEnologo
            // 
            this.comboBoxEnologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxEnologo.FormattingEnabled = true;
            this.comboBoxEnologo.Location = new System.Drawing.Point(540, 401);
            this.comboBoxEnologo.Name = "comboBoxEnologo";
            this.comboBoxEnologo.Size = new System.Drawing.Size(222, 24);
            this.comboBoxEnologo.TabIndex = 7;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(13, 249);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(47, 16);
            this.labelNome.TabIndex = 10;
            this.labelNome.Text = "Vinho";
            // 
            // labelEnologo
            // 
            this.labelEnologo.AutoSize = true;
            this.labelEnologo.Location = new System.Drawing.Point(537, 382);
            this.labelEnologo.Name = "labelEnologo";
            this.labelEnologo.Size = new System.Drawing.Size(66, 16);
            this.labelEnologo.TabIndex = 11;
            this.labelEnologo.Text = "Enólogo";
            // 
            // labelProdutor
            // 
            this.labelProdutor.AutoSize = true;
            this.labelProdutor.Location = new System.Drawing.Point(278, 382);
            this.labelProdutor.Name = "labelProdutor";
            this.labelProdutor.Size = new System.Drawing.Size(67, 16);
            this.labelProdutor.TabIndex = 12;
            this.labelProdutor.Text = "Produtor";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(15, 382);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(40, 16);
            this.labelTipo.TabIndex = 13;
            this.labelTipo.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Região";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(798, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ano";
            // 
            // labelTEorAlcoolico
            // 
            this.labelTEorAlcoolico.AutoSize = true;
            this.labelTEorAlcoolico.Location = new System.Drawing.Point(798, 316);
            this.labelTEorAlcoolico.Name = "labelTEorAlcoolico";
            this.labelTEorAlcoolico.Size = new System.Drawing.Size(110, 16);
            this.labelTEorAlcoolico.TabIndex = 16;
            this.labelTEorAlcoolico.Text = "Teor Alcoólico";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(798, 382);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(60, 16);
            this.labelVolume.TabIndex = 17;
            this.labelVolume.Text = "Volume";
            // 
            // panelGuardar
            // 
            this.panelGuardar.Controls.Add(this.buttonCancelar);
            this.panelGuardar.Controls.Add(this.buttonGuardar);
            this.panelGuardar.Location = new System.Drawing.Point(635, 431);
            this.panelGuardar.Name = "panelGuardar";
            this.panelGuardar.Size = new System.Drawing.Size(198, 67);
            this.panelGuardar.TabIndex = 21;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_cancel_subscription_80;
            this.buttonCancelar.Location = new System.Drawing.Point(123, 3);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(60, 60);
            this.buttonCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.TabStop = false;
            this.buttonCancelar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_save_80;
            this.buttonGuardar.Location = new System.Drawing.Point(14, 4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(60, 60);
            this.buttonGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.TabStop = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.AutoSize = true;
            this.panelOpcoes.Controls.Add(this.buttonUpdate);
            this.panelOpcoes.Controls.Add(this.buttonDelete);
            this.panelOpcoes.Controls.Add(this.buttonInsert);
            this.panelOpcoes.Location = new System.Drawing.Point(573, 552);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Size = new System.Drawing.Size(322, 56);
            this.panelOpcoes.TabIndex = 22;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_available_updates_80;
            this.buttonUpdate.Location = new System.Drawing.Point(255, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(50, 50);
            this.buttonUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.TabStop = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_cancel_160;
            this.buttonDelete.Location = new System.Drawing.Point(137, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(50, 50);
            this.buttonDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_plus_480;
            this.buttonInsert.Location = new System.Drawing.Point(19, 3);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(50, 50);
            this.buttonInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonInsert.TabIndex = 21;
            this.buttonInsert.TabStop = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // formVinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 626);
            this.Controls.Add(this.panelOpcoes);
            this.Controls.Add(this.panelGuardar);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelTEorAlcoolico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelProdutor);
            this.Controls.Add(this.labelEnologo);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.comboBoxEnologo);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.comboBoxProdutor);
            this.Controls.Add(this.comboBoxRegiao);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.textBoxTeorAlcoolico);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.groupBoxCastas);
            this.Controls.Add(this.gridVinhos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formVinho";
            this.Text = "Vinhos";
            this.Load += new System.EventHandler(this.formVinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVinhos)).EndInit();
            this.groupBoxCastas.ResumeLayout(false);
            this.groupBoxCastas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCastas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDeleteCasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInsertCasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVinhosCastas)).EndInit();
            this.panelGuardar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGuardar)).EndInit();
            this.panelOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVinhos;
        private System.Windows.Forms.GroupBox groupBoxCastas;
        private System.Windows.Forms.DataGridView gridVinhosCastas;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.TextBox textBoxTeorAlcoolico;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.ComboBox comboBoxRegiao;
        private System.Windows.Forms.ComboBox comboBoxProdutor;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxEnologo;
        private System.Windows.Forms.Label labelCastas;
        private System.Windows.Forms.TextBox textBoxPercentagem;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEnologo;
        private System.Windows.Forms.Label labelProdutor;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTEorAlcoolico;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelPercentagemdaCasta;
        private System.Windows.Forms.PictureBox buttonDeleteCasta;
        private System.Windows.Forms.PictureBox buttonInsertCasta;
        private System.Windows.Forms.Panel panelGuardar;
        private System.Windows.Forms.Panel panelOpcoes;
        private System.Windows.Forms.PictureBox buttonUpdate;
        private System.Windows.Forms.PictureBox buttonDelete;
        private System.Windows.Forms.PictureBox buttonInsert;
        private System.Windows.Forms.PictureBox buttonCancelar;
        private System.Windows.Forms.PictureBox buttonGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridCastas;
    }
}