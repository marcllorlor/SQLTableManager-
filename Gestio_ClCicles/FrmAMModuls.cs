using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestio_ClCicles
{
    public partial class FrmAMModuls : Form
    {

        public char operacio = ' ';
        public FrmModuls frmPare;
        public Boolean hanfetOK = false;            // ens indicarà si s'ha tancat aquest Form amb el botó OK o amb un altre

        private DataSet DsetCicles = new DataSet();

        public FrmAMModuls()
        {
            InitializeComponent();
        }

        private void FrmAMModuls_Load(object sender, EventArgs e)
        {
            tbId.Enabled = (operacio == 'A');
            if (operacio == 'M')
            {
                tbId.Text = frmPare.ctrlModuls.idModul;
                tbNom.Text = frmPare.ctrlModuls.nomModul;
            }

            getdadescicle();
            afegirvalorscomobox();
        }

        private void getdadescicle()
        {
            if (!frmPare.ctrlCicles.modelAccessible())
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DsetCicles.Clear();
                frmPare.ctrlCicles.llistaXnomCicles(ref DsetCicles);
            }
            
        }

        private void afegirvalorscomobox()
        {
            cbIdCicle.DataSource = DsetCicles.Tables[0];
            cbIdCicle.DisplayMember = "nomCicle";
            cbIdCicle.ValueMember = "idCicle";
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            frmPare.ctrlModuls.idModul = tbId.Text.Trim();
            frmPare.ctrlModuls.nomModul = tbNom.Text.Trim();
            frmPare.ctrlModuls.idCicle = cbIdCicle.SelectedValue.ToString();
            switch (operacio)
            {
                case 'A':
                    hanfetOK = frmPare.ctrlModuls.nouModul();
                    break;
                case 'M':
                    hanfetOK = frmPare.ctrlModuls.modificarModul();
                    break;
                default: break;
            }
            if (hanfetOK)
            {
                this.Close();
            }
        }
    }
}
