
namespace ProjetoVinhos_TiagoNascimentoVS2
{
    partial class formRegiao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegiao));
            this.gridRegiao = new System.Windows.Forms.DataGridView();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCaracteristicas = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCaracteristicas = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.PictureBox();
            this.buttonUpdate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRegiao
            // 
            this.gridRegiao.AllowUserToAddRows = false;
            this.gridRegiao.AllowUserToDeleteRows = false;
            this.gridRegiao.AllowUserToResizeColumns = false;
            this.gridRegiao.AllowUserToResizeRows = false;
            this.gridRegiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegiao.Location = new System.Drawing.Point(16, 13);
            this.gridRegiao.MultiSelect = false;
            this.gridRegiao.Name = "gridRegiao";
            this.gridRegiao.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRegiao.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRegiao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRegiao.Size = new System.Drawing.Size(329, 411);
            this.gridRegiao.TabIndex = 0;
            this.gridRegiao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRegiao_CellContentClick);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxNome.Location = new System.Drawing.Point(359, 55);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(288, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxCaracteristicas
            // 
            this.textBoxCaracteristicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxCaracteristicas.Location = new System.Drawing.Point(359, 123);
            this.textBoxCaracteristicas.Multiline = true;
            this.textBoxCaracteristicas.Name = "textBoxCaracteristicas";
            this.textBoxCaracteristicas.Size = new System.Drawing.Size(288, 167);
            this.textBoxCaracteristicas.TabIndex = 2;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(356, 36);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(59, 16);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Região";
            // 
            // labelCaracteristicas
            // 
            this.labelCaracteristicas.AutoSize = true;
            this.labelCaracteristicas.Location = new System.Drawing.Point(356, 104);
            this.labelCaracteristicas.Name = "labelCaracteristicas";
            this.labelCaracteristicas.Size = new System.Drawing.Size(112, 16);
            this.labelCaracteristicas.TabIndex = 4;
            this.labelCaracteristicas.Text = "Características";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_plus_480;
            this.buttonInsert.Location = new System.Drawing.Point(379, 346);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(50, 50);
            this.buttonInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonInsert.TabIndex = 5;
            this.buttonInsert.TabStop = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_delete_480;
            this.buttonDelete.Location = new System.Drawing.Point(479, 346);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(50, 50);
            this.buttonDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_available_updates_80;
            this.buttonUpdate.Location = new System.Drawing.Point(579, 346);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(50, 50);
            this.buttonUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.TabStop = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // formRegiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 436);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelCaracteristicas);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxCaracteristicas);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.gridRegiao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formRegiao";
            this.Text = "Região";
            this.Load += new System.EventHandler(this.formRegiao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRegiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRegiao;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCaracteristicas;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCaracteristicas;
        private System.Windows.Forms.PictureBox buttonInsert;
        private System.Windows.Forms.PictureBox buttonDelete;
        private System.Windows.Forms.PictureBox buttonUpdate;
    }
}