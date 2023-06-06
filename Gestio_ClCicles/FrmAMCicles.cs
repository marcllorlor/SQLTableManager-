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
    public partial class FrmAMCicles : Form
    {
        public char operacio = ' ';
        public FrmCicles frmPare;
        public Boolean hanfetOK = false;            // ens indicarà si s'ha tancat aquest Form amb el botó OK o amb un altre

        private DataSet DsetFamilies = new DataSet();

        public FrmAMCicles()
        {
            InitializeComponent();
        }

        private void FrmAMCicles_Load(object sender, EventArgs e)
        {
            tbId.Enabled = (operacio == 'A');
            if (operacio == 'M')
            {
                tbId.Text = frmPare.ctrlCicles.idCicle;
                tbNom.Text = frmPare.ctrlCicles.nomCicle;
            }

            getdadesfamilia();
            afegirvalorscomobox();
        }

        private void getdadesfamilia()
        {
            if (!frmPare.ctrlFamilies.modelAccessible())
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DsetFamilies.Clear();
            frmPare.ctrlFamilies.llistaXnomFamilies(ref DsetFamilies);
        }

        private void afegirvalorscomobox()
        {
            cbIdFamilia.DataSource = DsetFamilies.Tables[0];
            cbIdFamilia.DisplayMember = "nomFamilia";
            cbIdFamilia.ValueMember = "idFamilia";
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            frmPare.ctrlCicles.idCicle = tbId.Text.Trim();
            frmPare.ctrlCicles.nomCicle = tbNom.Text.Trim();
            frmPare.ctrlCicles.idFamilia = cbIdFamilia.SelectedValue.ToString();
            switch (operacio)
            {
                case 'A':
                    hanfetOK = frmPare.ctrlCicles.nouCicle();
                    break;
                case 'M':
                    hanfetOK = frmPare.ctrlCicles.modificarCicle();
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
