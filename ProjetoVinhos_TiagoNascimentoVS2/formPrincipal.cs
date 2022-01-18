using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVinhos_TiagoNascimentoVS2
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButtonVinhos_Click(object sender, EventArgs e)
        {
            formVinho fv = new formVinho();
            fv.MdiParent = this;
            fv.Show();
        }

        private void toolStripButtonProdutores_Click(object sender, EventArgs e)
        {
            formProdutor fp = new formProdutor();
            fp.MdiParent = this;
            fp.Show();
        }

        private void toolStripButtonCastas_Click(object sender, EventArgs e)
        {
            formCastas fc = new formCastas();
            fc.MdiParent = this;
            fc.Show();
        }

        private void toolStripButtonEnologo_Click(object sender, EventArgs e)
        {
            formEnologo fe = new formEnologo();
            fe.MdiParent = this;
            fe.Show(); 
        }

        private void toolStripButtonRegioes_Click(object sender, EventArgs e)
        {
            formRegiao fr = new formRegiao();
            fr.MdiParent = this;
            fr.Show();
        }

        private void toolStripButtonSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que quer sair?", "Sair",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
