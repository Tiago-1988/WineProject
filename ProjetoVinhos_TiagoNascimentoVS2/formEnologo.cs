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
    public partial class formEnologo : Form
    {
        modeloVinhos db = new modeloVinhos();
        public formEnologo()
        {
            InitializeComponent();
        }

        private void formEnologo_Load(object sender, EventArgs e)
        {
            GetEnologos();
        }
        void GetEnologos()
        {
            var q = from c in db.Enologoes
                    orderby c.Nome ascending
                    select new
                    {
                        c.Id,
                        c.Nome,
                    };
            gridEnologo.DataSource = q.ToList();
            gridEnologo.Columns[0].Visible = false;
            gridEnologo.Columns[1].HeaderText = "Enólogo";
            gridEnologo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            Enologo en = new Enologo();

            en.Nome = textBoxNome.Text;
            if (Validacoes.ValidarNome(textBoxNome.Text) == false)
            {
                MessageBox.Show("Nome inválido");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                return;
            }
            db.Enologoes.Add(en);
            db.SaveChanges();
            GetEnologos();
            Clean();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(gridEnologo.CurrentRow.Cells[0].Value.ToString());
                Enologo en = db.Enologoes.Find(id);
                if (en.Vinhoes.Count == 0)
                {
                    db.Enologoes.Remove(en);
                    db.SaveChanges();
                    GetEnologos();
                }
                else
                {
                    MessageBox.Show($"O Enólogo {en.Nome } não pode ser eliminado, " +
                        "está associado a um vinho!", "Eliminar - erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!");
            }
            Clean();
        }

        private void gridEnologo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNome.Text = gridEnologo.CurrentRow.Cells[1].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridEnologo.CurrentRow.Cells[0].Value.ToString());
            Enologo en = db.Enologoes.Find(id);
            en.Nome = textBoxNome.Text;
            if (Validacoes.ValidarNome(textBoxNome.Text) == false)
            {
                MessageBox.Show("Nome inválido");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                return;
            }
            db.SaveChanges();
            GetEnologos();
            Clean();
        }
    }
}
