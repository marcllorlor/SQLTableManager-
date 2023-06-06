using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASSES;
using DAM_ClCpSqlServer.CLASSES;

namespace Gestio_ClCicles
{
    public partial class FrmCicles : Form
    {
        public ClCicles ctrlCicles;                // utilitzem aquesta propietat per a facilitar la comunicació entre la connexió a la BD que hem fet al FrmMain i aquest Form
        public ClFamilies ctrlFamilies;

        private DataSet dset = new DataSet();

        public FrmCicles()
        {
            InitializeComponent();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            getDades();
            iniDgrid();
        }

        private void iniDgrid()
        {
            Graphics g = this.CreateGraphics();

            dgCicles.Columns[0].HeaderText = "id.";
            dgCicles.Columns[1].HeaderText = "nom família";
            dgCicles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void getDades()
        {
            if (!ctrlCicles.modelAccessible())
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dset.Clear();
            ctrlCicles.llistaXnomCicles(ref dset);
            dgCicles.DataSource = dset.Tables[0];
            dgCicles.AutoResizeColumns();
        }

        private void btQuants_Click(object sender, EventArgs e)
        {
            Int32 n = 0;

            if (tbPrefix.Text.Trim() == "")
            {
                MessageBox.Show("Cal introduir una població", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                n = ctrlCicles.quantsCiclesXPrefix(tbPrefix.Text.Trim());
                MessageBox.Show("Hi han " + n.ToString().Trim() + " Cicles amb el prefix " + tbPrefix.Text.Trim(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNou_Click(object sender, EventArgs e)
        {
            FrmAMCicles frm = new FrmAMCicles();

            frm.frmPare = this;
            frm.Text = "Alta d'una nova família";
            frm.operacio = 'A';
            ctrlCicles.idCicle = "";
            ctrlCicles.nomCicle = "";
            ctrlCicles.idFamilia = "";

            //Aqui declararem una array, que agafara el valor del que retornara
            ctrlCicles.idsFamilies = retornaridFamilies(); 

            //Aqui hem de fer una funcio que ens retorni tots els noms de les families per saber quins podem posar i quins no

            frm.ShowDialog();
            if (frm.hanfetOK)
            {
                //MessageBox.Show("S'ha afegit el cicle " + ctrlCicles.idCicle + "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                getDades();

                // apliquem LINQ per a trobar al DataGridView la fila on és la familia que s'acaba d'inserir
                var quinaFila = from DataGridViewRow fila in dgCicles.Rows
                                where fila.Cells["idCicle"].Value.ToString().Trim() == ctrlCicles.idCicle
                                select fila.Index;

                dgCicles.Rows[quinaFila.First()].Selected = true;
                MessageBox.Show("S'ha afegit el cicle: " + ctrlCicles.idCicle + " amb el nom: " + ctrlCicles.nomCicle, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frm = null;
            GC.Collect();
        }

        private List<String> retornaridFamilies()
        {
            return ctrlCicles.retornaridsFamilies();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dgCicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cal seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ctrlCicles.idCicle = dgCicles.SelectedRows[0].Cells["idCicle"].Value.ToString().Trim();
                if (ctrlCicles.suprimirCicle())
                {
                    getDades();
                    if(dgCicles.Rows.Count != 0)
                    {
                        dgCicles.Rows[0].Selected = true;
                    }
                    
                }
            }
        }

        private void dgCP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 quinafila = 0;
            FrmAMCicles frm;

            if (dgCicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cal seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                quinafila = dgCicles.SelectedRows[0].Index;
                frm = new FrmAMCicles();
                frm.frmPare = this;
                frm.Text = "Modificar un Cicle";
                frm.operacio = 'M';
                ctrlCicles.idCicle = dgCicles.SelectedRows[0].Cells["idCicle"].Value.ToString();
                ctrlCicles.getCicle();
                frm.ShowDialog();
                if (frm.hanfetOK)
                {
                    getDades();
                }
                dgCicles.Rows[quinafila].Selected = true;
                frm = null;
                GC.Collect();
            }
        }

        
    }
}
