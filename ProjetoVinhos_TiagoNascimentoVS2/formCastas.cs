using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libValidacoes;

namespace ProjetoVinhos_TiagoNascimentoVS2
{
    public partial class formCastas : Form
    {
        modeloVinhos db = new modeloVinhos();
        public formCastas()
        {
            InitializeComponent();
        }

        private void formCastas_Load(object sender, EventArgs e)
        {
            Getcastas(); 
        }

        void Getcastas()
        {
            var q = from c in db.Castas
                    orderby c.Nome ascending
                    select new
                    {
                        c.Id,
                        c.Nome,
                        c.Caracteristicas
                    };
            gridCastas.DataSource = q.ToList();
            gridCastas.Columns[0].Visible = false;
            gridCastas.Columns[1].HeaderText = "Casta";
            gridCastas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridCastas.Columns[2].Visible = false; 
        }
        void Clean()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                if (item is DataGridView)
                {
                    ((DataGridView)item).ClearSelection();
                    ((DataGridView)item).CurrentCell = null;
                }
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Casta c = new Casta();
            c.Nome = textBoxNome.Text;
            if (Validacoes.ValidarNome(textBoxNome.Text) == false)
            {
                MessageBox.Show("Nome inválido");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                return;
            }
            c.Caracteristicas = textBoxCaracteristicas.Text;
            db.Castas.Add(c);
            db.SaveChanges();
            Getcastas();
            Clean();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(gridCastas.CurrentRow.Cells[0].Value.ToString());
                Casta c = new Casta();

                if (c.VinhoCastas.Count == 0)
                {
                    db.Castas.Remove(c);
                    db.SaveChanges();
                    Getcastas();
                }
                else
                {
                    MessageBox.Show($"A casta {c.Nome } não pode ser eliminada, " +
                        "está associada a um vinho!", "Eliminar - erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro!");
            }
            Clean();
        }

        private void gridCastas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNome.Text = gridCastas.CurrentRow.Cells[1].Value.ToString();
            textBoxCaracteristicas.Text = gridCastas.CurrentRow.Cells[2].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridCastas.CurrentRow.Cells[0].Value.ToString());
            Casta c = new Casta();
            c.Nome = textBoxNome.Text;
            if (Validacoes.ValidarNome(textBoxNome.Text) == false)
            {
                MessageBox.Show("Casta Inválida");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                return;
            }
            c.Caracteristicas = textBoxCaracteristicas.Text;
            db.SaveChanges();
            Getcastas();
            Clean();
        }   
    }
}
