
namespace ProjetoVinhos_TiagoNascimentoVS2
{
    partial class formProdutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProdutor));
            this.gridProdutor = new System.Windows.Forms.DataGridView();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.PictureBox();
            this.buttonUpdate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProdutor
            // 
            this.gridProdutor.AllowUserToAddRows = false;
            this.gridProdutor.AllowUserToDeleteRows = false;
            this.gridProdutor.AllowUserToResizeColumns = false;
            this.gridProdutor.AllowUserToResizeRows = false;
            this.gridProdutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutor.Location = new System.Drawing.Point(14, 10);
            this.gridProdutor.Margin = new System.Windows.Forms.Padding(4);
            this.gridProdutor.MultiSelect = false;
            this.gridProdutor.Name = "gridProdutor";
            this.gridProdutor.ReadOnly = true;
            this.gridProdutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdutor.Size = new System.Drawing.Size(493, 375);
            this.gridProdutor.TabIndex = 0;
            this.gridProdutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutor_CellContentClick);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxNome.Location = new System.Drawing.Point(514, 50);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(304, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxEmail.Location = new System.Drawing.Point(514, 128);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(304, 22);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxURL.Location = new System.Drawing.Point(514, 206);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(304, 22);
            this.textBoxURL.TabIndex = 3;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(514, 31);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(49, 16);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(514, 109);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(47, 16);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(514, 187);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(38, 16);
            this.labelURL.TabIndex = 6;
            this.labelURL.Text = "URL";
            // 
            // buttonInsert
            // 
            this.buttonInsert.ErrorImage = null;
            this.buttonInsert.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_plus_480;
            this.buttonInsert.Location = new System.Drawing.Point(537, 291);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(50, 50);
            this.buttonInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonInsert.TabIndex = 7;
            this.buttonInsert.TabStop = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_delete_480;
            this.buttonDelete.InitialImage = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_delete_480;
            this.buttonDelete.Location = new System.Drawing.Point(641, 291);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(50, 50);
            this.buttonDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_available_updates_80;
            this.buttonUpdate.Location = new System.Drawing.Point(745, 291);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(50, 50);
            this.buttonUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.TabStop = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // formProdutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 406);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.gridProdutor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formProdutor";
            this.Text = "Produtor";
            this.Load += new System.EventHandler(this.formProdutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProdutor;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.PictureBox buttonInsert;
        private System.Windows.Forms.PictureBox buttonDelete;
        private System.Windows.Forms.PictureBox buttonUpdate;
    }
}