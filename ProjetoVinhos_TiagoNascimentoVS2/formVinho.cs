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
    public partial class formVinho : Form
    {
        string guardar = "";
        modeloVinhos db = new modeloVinhos();
        Vinho vinho;
        public formVinho()
        {
            InitializeComponent();
        }
        private void formVinho_Load(object sender, EventArgs e)
        {
            GetProdutores();
            GetEnologos();
            GetRegioes();
            GetTipos();
            GetVinhos();
            BloquearFormulario(false);
            
        }

        #region Métodos
        void GetProdutores()
        {
            var q = from p in db.Produtors
                    orderby p.Nome 
                    select new
                    {
                        p.Id,
                        p.Nome
                    };
            comboBoxProdutor.DataSource = q.ToList();
            comboBoxProdutor.DisplayMember = "Nome";
            comboBoxProdutor.ValueMember = "Id";
        }
        void GetRegioes()
        {
            var q = from r in db.Regiaos
                    orderby r.Nome 
                    select new
                    {
                        r.Id,
                        r.Nome
                    };
            comboBoxRegiao.DataSource = q.ToList();
            comboBoxRegiao.DisplayMember = "Nome"; 
            comboBoxRegiao.ValueMember = "Id"; 
        }
        void GetTipos()
        {
            var q = from t in db.Tipoes
                    orderby t.Nome ascending
                    select new
                    {
                        t.Id,
                        t.Nome
                    };
            comboBoxTipo.DataSource = q.ToList();
            comboBoxTipo.DisplayMember = "Nome";
            comboBoxTipo.ValueMember = "Id"; 
        }
        void GetEnologos()
        {
            var q = from en in db.Enologoes
                    orderby en.Nome 
                    select new
                    {
                        en.Id,
                        en.Nome
                    };
            comboBoxEnologo.DataSource = q.ToList();
            comboBoxEnologo.DisplayMember = "Nome";
            comboBoxEnologo.ValueMember = "id"; 
        }

        void GetVinhos()
        {
            var q = from v in db.Vinhoes
                    orderby v.Nome
                    select new
                    {
                        v.Id,
                        v.Nome,
                        v.Produtor,
                        v.Regiao,
                        v.Enologo,
                        v.Tipo,
                        v.Volume,
                        v.TeorAlcoolico,
                        v.Ano
                    };
            gridVinhos.DataSource = q.ToList();
            gridVinhos.Columns[0].Visible = false;
            gridVinhos.Columns[1].HeaderText = "Vinho";
            gridVinhos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridVinhos.Columns[2].Visible = false;
            gridVinhos.Columns[3].Visible = false;
            gridVinhos.Columns[4].Visible = false;
            gridVinhos.Columns[5].Visible = false;
            gridVinhos.Columns[6].Visible = false;
            gridVinhos.Columns[7].Visible = false;
            gridVinhos.Columns[8].Visible = false;
        }
        void GetCastas()
        {
            List<int> temp_castas = new List<int>();

            foreach (var item in vinho.VinhoCastas)
                temp_castas.Add((int)item.Casta);

            var q1 = from c in db.Castas
                     where !temp_castas.Contains(c.Id)
                     orderby c.Nome
                     select new { c.Id, c.Nome };
            gridCastas.DataSource = q1.ToList();
            gridCastas.Columns[0].Visible = false;
            gridCastas.Columns[1].HeaderText = "Casta";
            gridCastas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            var castas = (from c in db.Castas
                          select new { c.Id, c.Nome }).ToList();

            var q2 = from c in castas
                     join vc in vinho.VinhoCastas on c.Id equals vc.Casta
                     orderby c.Nome
                     select new { c.Id, c.Nome, vc.Percentagem };
            gridVinhosCastas.DataSource = q2.ToList();
            gridVinhosCastas.Columns[0].Visible = false;
            gridVinhosCastas.Columns[1].HeaderText = "Casta";
            gridVinhosCastas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridVinhosCastas.Columns[2].HeaderText = "Percentagem";
            gridVinhosCastas.Columns[2].Width = 100;
        }

        void Clean()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = -1; 
                if (item is DataGridView)
                {
                    ((DataGridView)item).ClearSelection();
                    ((DataGridView)item).CurrentCell = null; 
                }
            }
        }
        void BloquearFormulario(bool b)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox | item is ComboBox)
                    item.Enabled = b; 
            }
            gridCastas.Enabled = b;
            gridVinhosCastas.Enabled = b; 
        }
        decimal VerificarPercentagem()
        {
            var q = from vc in vinho.VinhoCastas
                    select new
                    {
                        vc.Percentagem
                    };
            decimal p = 0;
            foreach (var item in q)
                p = p + (decimal)item.Percentagem;
            return p;
        }

        void NovoVinho()
        {
            vinho = new Vinho();
            vinho.Nome = textBoxNome.Text;
            if (Validacoes.ValidarNome(textBoxNome.Text) == false)
            {
                MessageBox.Show("Nome inválido");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                return;
            }
            vinho.TeorAlcoolico = decimal.Parse(textBoxTeorAlcoolico.Text);
            vinho.Volume = decimal.Parse(textBoxVolume.Text);
            vinho.Ano = int.Parse(textBoxAno.Text);
            vinho.Produtor = (int)comboBoxProdutor.SelectedValue;
            vinho.Regiao = (int)comboBoxRegiao.SelectedValue;
            vinho.Tipo = (int)comboBoxTipo.SelectedValue;
            vinho.Enologo = (int)comboBoxEnologo.SelectedValue;

            db.Vinhoes.Add(vinho);
            db.SaveChanges();
            Clean();
            BloquearFormulario(false);

            
            gridCastas.DataSource = null;
            gridVinhosCastas.DataSource = null;
            GetVinhos();
            panelGuardar.Visible = false;
            panelOpcoes.Visible = true;
        }

        void EditarVinho()
        {
            vinho = new Vinho();
            vinho.Nome = textBoxNome.Text;
            if (Validacoes.ValidarNome(textBoxNome.Text) == false)
            {
                MessageBox.Show("Nome inválido");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                return;
            }
            vinho.Produtor = (int)comboBoxProdutor.SelectedValue;
            vinho.Regiao = (int)comboBoxRegiao.SelectedValue;
            vinho.Tipo = (int)comboBoxTipo.SelectedValue;
            vinho.Enologo = (int)comboBoxEnologo.SelectedValue;
            vinho.TeorAlcoolico = decimal.Parse(textBoxTeorAlcoolico.Text);
            vinho.Volume = decimal.Parse(textBoxVolume.Text);
            vinho.Ano = int.Parse(textBoxAno.Text);

            db.SaveChanges();
            BloquearFormulario(false);
           
            gridCastas.DataSource = null;
            gridVinhosCastas.DataSource = null;
            GetVinhos();
            panelGuardar.Visible = false;
            panelOpcoes.Visible = true;
        }

        #endregion

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            guardar = "Insert";

            BloquearFormulario(true);
            Clean();
            textBoxNome.Focus();
            panelGuardar.Visible = true;
            panelGuardar.BringToFront();
            panelOpcoes.Visible = false;

            vinho = new Vinho();
            GetCastas(); 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (gridVinhos.CurrentRow != null)
            {
                int id = (int)gridVinhos.CurrentRow.Cells[0].Value;
                Vinho v = db.Vinhoes.Find(id);
                try
                {
                    if (MessageBox.Show($"Eliminra o vinho {v.Nome}?", "Eliminar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        v.VinhoCastas.Clear();
                        db.Vinhoes.Remove(v);
                        db.SaveChanges();
                        GetVinhos();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro!");
                }
            }
            else
            {
                MessageBox.Show("Seleccione o registo a eliminar.", "Eliminar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (gridVinhos.CurrentRow != null)
            {
                guardar = "update";
                BloquearFormulario(true);
                int id = int.Parse(gridVinhos.CurrentRow.Cells[0].Value.ToString());

                vinho = db.Vinhoes.Find(id);

                textBoxNome.Text = gridVinhos.CurrentRow.Cells[1].Value.ToString();
                comboBoxProdutor.SelectedValue = gridVinhos.CurrentRow.Cells[4].Value;
                comboBoxRegiao.SelectedValue = gridVinhos.CurrentRow.Cells[3].Value;
                comboBoxEnologo.SelectedValue = gridVinhos.CurrentRow.Cells[5].Value;
                comboBoxTipo.SelectedValue = gridVinhos.CurrentRow.Cells[2].Value;
                textBoxVolume.Text = gridVinhos.CurrentRow.Cells[6].Value.ToString();
                textBoxTeorAlcoolico.Text = gridVinhos.CurrentRow.Cells[7].Value.ToString();
                textBoxAno.Text = gridVinhos.CurrentRow.Cells[8].Value.ToString();

                
                GetCastas();

                textBoxNome.Focus();
                panelGuardar.Visible = true;
                panelOpcoes.Visible = false; 
            }
            else
            {
                MessageBox.Show("Selecione o registo a editar.", "Editar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonInsertCasta_Click(object sender, EventArgs e)
        {
            if (gridCastas.CurrentRow != null)
            {
                VinhoCasta vc = new VinhoCasta();
                vc.Casta = int.Parse(gridCastas.CurrentRow.Cells[0].Value.ToString());
                decimal.TryParse(textBoxPercentagem.Text, out decimal per);
                vc.Percentagem = per; 
                if (VerificarPercentagem() + per <=100)
                {
                    vinho.VinhoCastas.Add(vc);
                    GetCastas();
                    textBoxPercentagem.Text = ""; 
                }
                else
                {
                    MessageBox.Show("A soma das percentagens é superior a 100%.",
                        "Associar casta", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                        textBoxPercentagem.Focus();
                        textBoxPercentagem.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Selecione o vinho e a casta.", "Associar casta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleteCasta_Click(object sender, EventArgs e)
        {
            if (gridVinhosCastas.CurrentRow != null)
            {
                int id_casta = int.Parse(gridVinhosCastas.CurrentRow.Cells[0].Value.ToString());
                VinhoCasta vinho_casta = (from vc in vinho.VinhoCastas
                                          where vc.Casta == id_casta
                                          select vc).FirstOrDefault();
                vinho.VinhoCastas.Remove(vinho_casta);
                GetCastas();
            }
            else
            {
                MessageBox.Show("Selecione a casta a remover.", "Dissociar casta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (guardar == "Insert")
                NovoVinho();
            else if (guardar == "update")
                EditarVinho();
        }

        private void gridVinhos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNome.Text = gridVinhos.CurrentRow.Cells[1].Value.ToString();
            textBoxTeorAlcoolico.Text = gridVinhos.CurrentRow.Cells[7].Value.ToString();
            textBoxAno.Text = gridVinhos.CurrentRow.Cells[8].Value.ToString();
            textBoxVolume.Text = gridVinhos.CurrentRow.Cells[6].Value.ToString();
            comboBoxRegiao.SelectedValue = gridVinhos.CurrentRow.Cells[3].Value;
            comboBoxProdutor.SelectedValue = gridVinhos.CurrentRow.Cells[4].Value;
            comboBoxEnologo.SelectedValue = gridVinhos.CurrentRow.Cells[5].Value;
            comboBoxTipo.SelectedValue = gridVinhos.CurrentRow.Cells[2].Value;

           // int id = int.Parse(gridVinhos.CurrentRow.Cells[0].Value.ToString());

            //VinhoCastas(id);
            //RestantesCastas(id);
            //VinhoEnologos(id);
            //RestantesEnologos(id);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem a certeza que pretende cancelar?", "Cancelar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                panelGuardar.Visible = false;
                panelOpcoes.Visible = true;
                Clean();
            }
        }

        private void gridCastas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
