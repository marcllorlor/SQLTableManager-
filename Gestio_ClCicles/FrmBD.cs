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
    public partial class FrmBD : Form
    {
        public FrmBD()
        {
            InitializeComponent();
        }

        private void FrmBD_Load(object sender, EventArgs e)
        {
            tbCadenaConnexio.Text = ((FrmMain)this.MdiParent).servidorbasedadesarxiu;
            tbNomBD.Text = ((FrmMain)this.MdiParent).basedadesarxiu;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            //Primer farem el canvi de variables del mainForm

            ((FrmMain)this.MdiParent).servidorbasedadesarxiu = tbCadenaConnexio.Text;
            ((FrmMain)this.MdiParent).basedadesarxiu = tbNomBD.Text;

            ((FrmMain)this.MdiParent).funcioobrirconnexiosql();

            //Despres farem l'execució del metode per canviar la base de dades

            this.Close();
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
