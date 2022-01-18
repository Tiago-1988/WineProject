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
    public partial class formRegiao : Form
    {
        modeloVinhos db = new modeloVinhos();
        public formRegiao()
        {
            InitializeComponent();
        }

        private void formRegiao_Load(object sender, EventArgs e)
        {
            GetRegiao();
        }

        void GetRegiao()
        {
            var q = from c in db.Regiaos
                    orderby c.Nome ascending
                    select new
                    {
                        c.Id,
                        c.Nome,
                        c.Caracteristicas
                    };
            gridRegiao.DataSource = q.ToList();
            gridRegiao.Columns[0].Visible = false;
            gridRegiao.Columns[1].HeaderText = "Casta";
            gridRegiao.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridRegiao.Columns[2].Visible = false;
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
            Regiao r = new Regiao();

            r.Nome = textBoxNome.Text;
            if (Validacoes.ValidarNome(textBoxNome.Text) == false)
            {
                MessageBox.Show("Nome inválido");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                return;
            }
            r.Caracteristicas = textBoxCaracteristicas.Text;
            db.Regiaos.Add(r);
            db.SaveChanges();
            GetRegiao();
            Clean();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(gridRegiao.CurrentRow.Cells[0].Value.ToString());
                Regiao r = db.Regiaos.Find(id);
                if (r.Vinhoes.Count==0)
                {
                    db.Regiaos.Remove(r);
                    db.SaveChanges();
                    GetRegiao();
                }
                else
                {
                    MessageBox.Show($"A região {r.Nome } não pode ser eliminada, " +
                    "está associada a um vinho!", "Eliminar - erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                Clean();
            }catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridRegiao.CurrentRow.Cells[0].Value.ToString());
            Regiao r = db.Regiaos.Find(id);
            r.Nome = textBoxNome.Text;
            if (Validacoes.ValidarNome(textBoxNome.Text) == false)
            {
                MessageBox.Show("Nome inválido");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                return;
            }
            r.Caracteristicas = textBoxCaracteristicas.Text;
            db.SaveChanges();
            GetRegiao();
            Clean();
        }

        private void gridRegiao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNome.Text = gridRegiao.CurrentRow.Cells[1].Value.ToString();
            textBoxCaracteristicas.Text = gridRegiao.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
