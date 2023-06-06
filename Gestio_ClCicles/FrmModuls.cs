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
using Gestio_ClCicles.CLASSES;

namespace Gestio_ClCicles
{
    public partial class FrmModuls : Form
    {

        public ClCicles ctrlCicles;                // utilitzem aquesta propietat per a facilitar la comunicació entre la connexió a la BD que hem fet al FrmMain i aquest Form
        public ClModuls ctrlModuls;

        private DataSet dset = new DataSet();

        public FrmModuls()
        {
            InitializeComponent();
        }

        private void FrmModuls_Load(object sender, EventArgs e)
        {
            getDades();
            iniDgrid();
        }

        private void iniDgrid()
        {
            Graphics g = this.CreateGraphics();

            dgModuls.Columns[0].HeaderText = "idModul";
            dgModuls.Columns[1].HeaderText = "nomModul";
            dgModuls.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgModuls.Columns[2].Visible = false;
        }

        private void getDades()
        {
            if (!ctrlModuls.modelAccessible())
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dset.Clear();
            ctrlModuls.llistaXnomModuls(ref dset);
            dgModuls.DataSource = dset.Tables[0];
            dgModuls.AutoResizeColumns();
        }

        private void btNou_Click(object sender, EventArgs e)
        {
            FrmAMModuls frm = new FrmAMModuls();

            frm.frmPare = this;
            frm.Text = "Alta d'una nou Modul";
            frm.operacio = 'A';
            ctrlModuls.idModul = "";
            ctrlModuls.nomModul = "";
            ctrlModuls.idCicle = "";

            //Aqui declararem una array, que agafara el valor del que retornara
            //ctrlCicles.idsFamilies = retornaridFamilies();

            //Aqui hem de fer una funcio que ens retorni tots els noms de les families per saber quins podem posar i quins no

            frm.ShowDialog();
            if (frm.hanfetOK)
            {
                //MessageBox.Show("S'ha afegit el cicle " + ctrlCicles.idCicle + "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                getDades();

                // apliquem LINQ per a trobar al DataGridView la fila on és la familia que s'acaba d'inserir
                var quinaFila = from DataGridViewRow fila in dgModuls.Rows
                                where fila.Cells["idModul"].Value.ToString().Trim() == ctrlModuls.idModul
                                select fila.Index;

                dgModuls.Rows[quinaFila.First()].Selected = true;
                MessageBox.Show("S'ha afegit el modul: " + ctrlModuls.idModul + " amb el nom: " + ctrlModuls.nomModul, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frm = null;
            GC.Collect();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dgModuls.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cal seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ctrlModuls.idModul = dgModuls.SelectedRows[0].Cells["idModul"].Value.ToString().Trim();
                if (ctrlModuls.suprimirModul())
                {
                    getDades();
                    if (dgModuls.Rows.Count != 0)
                    {
                        dgModuls.Rows[0].Selected = true;
                    }

                }
            }
        }

        private void dgModuls_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 quinafila = 0;
            FrmAMModuls frm;

            if (dgModuls.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cal seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                quinafila = dgModuls.SelectedRows[0].Index;
                frm = new FrmAMModuls();
                frm.frmPare = this;
                frm.Text = "Modificar un Modul";
                frm.operacio = 'M';
                ctrlModuls.idModul = dgModuls.SelectedRows[0].Cells["idModul"].Value.ToString();
                ctrlModuls.getModul();
                frm.ShowDialog();
                if (frm.hanfetOK)
                {
                    getDades();
                }
                dgModuls.Rows[quinafila].Selected = true;
                frm = null;
                GC.Collect();
            }
        }

        private void btQuants_Click(object sender, EventArgs e)
        {
            Int32 n = 0;

            if (tbPrefix.Text.Trim() == "")
            {
                MessageBox.Show("Cal introduir un Modul", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                n = ctrlModuls.quantsModulsXPrefix(tbPrefix.Text.Trim());
                MessageBox.Show("Hi han " + n.ToString().Trim() + " Moduls amb el prefix " + tbPrefix.Text.Trim(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
