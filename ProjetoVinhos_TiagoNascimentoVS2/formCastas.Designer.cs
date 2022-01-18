
namespace ProjetoVinhos_TiagoNascimentoVS2
{
    partial class formCastas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCastas));
            this.gridCastas = new System.Windows.Forms.DataGridView();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCaracteristicas = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCaracteristicas = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.PictureBox();
            this.buttonUpdate = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCastas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCastas
            // 
            this.gridCastas.AllowUserToAddRows = false;
            this.gridCastas.AllowUserToDeleteRows = false;
            this.gridCastas.AllowUserToResizeColumns = false;
            this.gridCastas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCastas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCastas.Location = new System.Drawing.Point(10, 8);
            this.gridCastas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridCastas.Name = "gridCastas";
            this.gridCastas.ReadOnly = true;
            this.gridCastas.RowHeadersVisible = false;
            this.gridCastas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCastas.Size = new System.Drawing.Size(308, 381);
            this.gridCastas.TabIndex = 0;
            this.gridCastas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCastas_CellContentClick);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(341, 61);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(270, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxCaracteristicas
            // 
            this.textBoxCaracteristicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaracteristicas.Location = new System.Drawing.Point(341, 119);
            this.textBoxCaracteristicas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCaracteristicas.Multiline = true;
            this.textBoxCaracteristicas.Name = "textBoxCaracteristicas";
            this.textBoxCaracteristicas.Size = new System.Drawing.Size(270, 154);
            this.textBoxCaracteristicas.TabIndex = 2;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(338, 43);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(48, 16);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Casta";
            // 
            // labelCaracteristicas
            // 
            this.labelCaracteristicas.AutoSize = true;
            this.labelCaracteristicas.Location = new System.Drawing.Point(338, 101);
            this.labelCaracteristicas.Name = "labelCaracteristicas";
            this.labelCaracteristicas.Size = new System.Drawing.Size(112, 16);
            this.labelCaracteristicas.TabIndex = 4;
            this.labelCaracteristicas.Text = "Caracteristicas";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_plus_480;
            this.buttonInsert.Location = new System.Drawing.Point(356, 312);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(50, 50);
            this.buttonInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonInsert.TabIndex = 5;
            this.buttonInsert.TabStop = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_available_updates_80;
            this.buttonUpdate.Location = new System.Drawing.Point(538, 312);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(50, 50);
            this.buttonUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.TabStop = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_delete_480;
            this.buttonDelete.Location = new System.Drawing.Point(447, 312);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(50, 50);
            this.buttonDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // formCastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 401);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelCaracteristicas);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxCaracteristicas);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.gridCastas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formCastas";
            this.Text = "Castas";
            this.Load += new System.EventHandler(this.formCastas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCastas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCastas;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCaracteristicas;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCaracteristicas;
        private System.Windows.Forms.PictureBox buttonInsert;
        private System.Windows.Forms.PictureBox buttonUpdate;
        private System.Windows.Forms.PictureBox buttonDelete;
    }
}