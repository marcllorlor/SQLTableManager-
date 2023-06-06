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
    public partial class FrmUfs : Form
    {
        public ClUfs ctrlUfs;

        public ClModuls ctrlModuls;
        public ClCicles ctrlCicles;                // utilitzem aquesta propietat per a facilitar la comunicació entre la connexió a la BD que hem fet al FrmMain i aquest Form
        

        private DataSet dset = new DataSet();

        public FrmUfs()
        {
            InitializeComponent();
        }

        private void FrmUfs_Load(object sender, EventArgs e)
        {
            getDades();
            iniDgrid();
        }

        private void iniDgrid()
        {
            Graphics g = this.CreateGraphics();

            dgUfs.Columns[0].HeaderText = "id.";
            dgUfs.Columns[1].HeaderText = "nom Uf";
            dgUfs.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgUfs.Columns[3].Visible = false;
            dgUfs.Columns[5].Visible = false;
        }

        private void getDades()
        {
            if (!ctrlUfs.modelAccessible())
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dset.Clear();
            ctrlUfs.llistaXnomUfs(ref dset);
            dgUfs.DataSource = dset.Tables[0];
            dgUfs.AutoResizeColumns();
        }

        private void btQuants_Click(object sender, EventArgs e)
        {
            Int32 n = 0;

            if (tbPrefix.Text.Trim() == "")
            {
                MessageBox.Show("Cal introduir una UF", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                n = ctrlUfs.quantesUfsXprefix(tbPrefix.Text.Trim());
                MessageBox.Show("Hi han " + n.ToString().Trim() + " Moduls amb el prefix " + tbPrefix.Text.Trim(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNou_Click(object sender, EventArgs e)
        {
            FrmAMBUfs frm = new FrmAMBUfs();

            frm.frmPare = this;
            frm.Text = "Alta d'una nova UF";
            frm.operacio = 'A';
            ctrlUfs.idUf = "";
            ctrlUfs.nomUf = "";
            ctrlUfs.nHores = "";
            ctrlUfs.idCicle = "";
            ctrlUfs.idModul = "";

            //Aqui declararem una array, que agafara el valor del que retornara
            //ctrlCicles.idsFamilies = retornaridFamilies();

            //Aqui hem de fer una funcio que ens retorni tots els noms de les families per saber quins podem posar i quins no

            frm.ShowDialog();
            if (frm.hanfetOK)
            {
                //MessageBox.Show("S'ha afegit el cicle " + ctrlCicles.idCicle + "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                getDades();

                // apliquem LINQ per a trobar al DataGridView la fila on és la familia que s'acaba d'inserir
                var quinaFila = from DataGridViewRow fila in dgUfs.Rows
                                where fila.Cells["idUf"].Value.ToString().Trim() == ctrlUfs.idUf
                                select fila.Index;

                dgUfs.Rows[quinaFila.First()].Selected = true;
                MessageBox.Show("S'ha afegit el cicle: " + ctrlUfs.idUf + " amb el nom: " + ctrlUfs.nomUf, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frm = null;
            GC.Collect();
        }

        private void dgUfs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 quinafila = 0;
            FrmAMBUfs frm;

            if (dgUfs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cal seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                quinafila = dgUfs.SelectedRows[0].Index;
                frm = new FrmAMBUfs();
                frm.frmPare = this;
                frm.Text = "Modificar una UF";
                frm.operacio = 'M';
                ctrlUfs.idUf = dgUfs.SelectedRows[0].Cells["idUf"].Value.ToString();
                ctrlUfs.getUf();
                frm.ShowDialog();
                if (frm.hanfetOK)
                {
                    getDades();
                }
                dgUfs.Rows[quinafila].Selected = true;
                frm = null;
                GC.Collect();
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dgUfs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cal seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ctrlUfs.idUf = dgUfs.SelectedRows[0].Cells["idUf"].Value.ToString().Trim();
                if (ctrlUfs.suprimirUf())
                {
                    getDades();
                    if (dgUfs.Rows.Count != 0)
                    {
                        dgUfs.Rows[0].Selected = true;
                    }

                }
            }
        }


    }
}
