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
    public partial class FrmAMBUfs : Form
    {

        public char operacio = ' ';
        public FrmUfs frmPare;
        public Boolean hanfetOK = false;

        private DataSet DsetCicles = new DataSet();
        private DataSet DsetModuls = new DataSet();

        public FrmAMBUfs()
        {
            InitializeComponent();
        }

        private void FrmAMBUfs_Load(object sender, EventArgs e)
        {
            tbId.Enabled = (operacio == 'A');
            if (operacio == 'M')
            {
                tbId.Text = frmPare.ctrlUfs.idUf;
                tbNom.Text = frmPare.ctrlUfs.nomUf;
                nudnHores.Value = Int32.Parse(frmPare.ctrlUfs.nHores);
            }
            //Aqui hauriem d'agafar les dades del Modul
            getdadesmodul();
            afegirvalorscomoboxModuls();

            //Aqui hauriem d'agafar les dades de Cicles
            getdadescicle();
            afegirvalorscomoboxCicles();
        }

        

        private void getdadesmodul()
        {
            if (!frmPare.ctrlModuls.modelAccessible())
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DsetModuls.Clear();
                frmPare.ctrlModuls.llistaXnomModuls(ref DsetModuls);
            }
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

        private void afegirvalorscomoboxCicles()
        {
            cbIdCicle.DataSource = DsetCicles.Tables[0];
            cbIdCicle.DisplayMember = "nomCicle";
            cbIdCicle.ValueMember = "idCicle";
        }

        private void afegirvalorscomoboxModuls()
        {
            cbIdModul.DataSource = DsetModuls.Tables[0];
            cbIdModul.DisplayMember = "nomModul";
            cbIdModul.ValueMember = "idModul";
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            frmPare.ctrlUfs.idUf = tbId.Text.Trim();
            frmPare.ctrlUfs.nomUf = tbNom.Text.Trim();
            frmPare.ctrlUfs.nHores = nudnHores.Value.ToString();
            frmPare.ctrlUfs.idCicle = cbIdCicle.SelectedValue.ToString();
            frmPare.ctrlUfs.idModul = cbIdModul.SelectedValue.ToString();
            switch (operacio)
            {
                case 'A':
                    hanfetOK = frmPare.ctrlUfs.novaUf();
                    break;
                case 'M':
                    hanfetOK = frmPare.ctrlUfs.modificarUf();
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
