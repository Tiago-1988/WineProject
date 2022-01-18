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
    public partial class formProdutor : Form
    {

        modeloVinhos db = new modeloVinhos();
        public formProdutor()
        {
            InitializeComponent();
        }

        private void formProdutor_Load(object sender, EventArgs e)
        {
            GetProdutor();
        }

        void GetProdutor()
        {
            var q = from p in db.Produtors
                    orderby p.Nome ascending
                    select new
                    {
                        p.Id,
                        p.Nome,
                        p.Email,
                        p.URL
                    };
            gridProdutor.DataSource = q.ToList();
            gridProdutor.Columns[0].Visible = false;
            gridProdutor.Columns[1].HeaderText = "Produtor";
            gridProdutor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridProdutor.Columns[2].Visible = false;
            gridProdutor.Columns[3].Visible = false;
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
            Produtor p = new Produtor();

            p.Nome = textBoxNome.Text;
            if (Validacoes.ValidarNome(textBoxNome.Text) == false)
            {
                MessageBox.Show("Nome inválido");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                return;
            }
            p.Email = textBoxEmail.Text;
            if (Validacoes.ValidarEmail(textBoxEmail.Text) == false)
            {
                MessageBox.Show("Email Inválido");
                textBoxEmail.Focus();
                textBoxEmail.SelectAll();
                return;
            }
            p.URL = textBoxURL.Text;
            db.Produtors.Add(p);
            db.SaveChanges();
            GetProdutor();
            Clean(); 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridProdutor.CurrentRow != null)
                {
                    int id = int.Parse(gridProdutor.CurrentRow.Cells[0].Value.ToString());
                    Produtor p = db.Produtors.Find(id);
                    if (p.Vinhoes.Count == 0)
                    {
                        db.Produtors.Remove(p);
                        db.SaveChanges();
                        GetProdutor();
                    }
                    else
                    {
                        MessageBox.Show($"A casta {p.Nome } não pode ser eliminada, " +
                       "está associada a um vinho!", "Eliminar - erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione o registo a editar.", "Editar",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Clean();
            }
            catch (Exception) 
            {
                MessageBox.Show("Ocorreu um erro!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
          
                int id = int.Parse(gridProdutor.CurrentRow.Cells[0].Value.ToString());
                Produtor p = db.Produtors.Find(id);
                p.Nome = textBoxNome.Text;
                if (Validacoes.ValidarNome(textBoxNome.Text) == false)
                {
                    MessageBox.Show("Nome inválido");
                    textBoxNome.Focus();
                    textBoxNome.SelectAll();
                    return;
                }
                p.URL = textBoxURL.Text;
                p.Email = textBoxEmail.Text;
                if (Validacoes.ValidarEmail(textBoxEmail.Text) == false)
                {
                    MessageBox.Show("Email Inválido");
                    textBoxEmail.Focus();
                    textBoxEmail.SelectAll();
                   return;
                }
               
                db.SaveChanges();
                GetProdutor();
                Clean();
            
        }

        private void gridProdutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNome.Text = gridProdutor.CurrentRow.Cells[1].Value.ToString();
            textBoxURL.Text = gridProdutor.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text = gridProdutor.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
