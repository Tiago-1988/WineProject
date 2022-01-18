
namespace ProjetoVinhos_TiagoNascimentoVS2
{
    partial class formEnologo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEnologo));
            this.gridEnologo = new System.Windows.Forms.DataGridView();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.PictureBox();
            this.buttonUpdate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnologo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEnologo
            // 
            this.gridEnologo.AllowUserToAddRows = false;
            this.gridEnologo.AllowUserToDeleteRows = false;
            this.gridEnologo.AllowUserToResizeColumns = false;
            this.gridEnologo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEnologo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEnologo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEnologo.Location = new System.Drawing.Point(12, 12);
            this.gridEnologo.MultiSelect = false;
            this.gridEnologo.Name = "gridEnologo";
            this.gridEnologo.ReadOnly = true;
            this.gridEnologo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEnologo.Size = new System.Drawing.Size(349, 235);
            this.gridEnologo.TabIndex = 0;
            this.gridEnologo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEnologo_CellContentClick);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxNome.Location = new System.Drawing.Point(379, 69);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(286, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(386, 50);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(66, 16);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Enólogo";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_plus_480;
            this.buttonInsert.Location = new System.Drawing.Point(392, 155);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(50, 50);
            this.buttonInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.TabStop = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_delete_480;
            this.buttonDelete.Location = new System.Drawing.Point(494, 155);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(50, 50);
            this.buttonDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Image = global::ProjetoVinhos_TiagoNascimentoVS2.Properties.Resources.icons8_available_updates_80;
            this.buttonUpdate.Location = new System.Drawing.Point(596, 155);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(50, 50);
            this.buttonUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.TabStop = false;
            this.buttonUpdate.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // formEnologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 260);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.gridEnologo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formEnologo";
            this.Text = "Enólogo";
            this.Load += new System.EventHandler(this.formEnologo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEnologo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEnologo;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.PictureBox buttonInsert;
        private System.Windows.Forms.PictureBox buttonDelete;
        private System.Windows.Forms.PictureBox buttonUpdate;
    }
}