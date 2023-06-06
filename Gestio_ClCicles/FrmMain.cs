using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASSES;
using DAM_ClCpSqlServer.CLASSES;
using Gestio_ClCicles.CLASSES;

namespace Gestio_ClCicles
{
    public partial class FrmMain : Form
    {
        //AQUI ES A ON DECLARAREM LES VARIABLES DE LES BASES DE DADES
        public string nomfitxercfg = "CFGBD.TXT";

        //Aquestes son les variables que farem servir per la connnexio de la base de dades
        public string servidorbasedadesarxiu = "";
        public string basedadesarxiu = "";

        //Aixo en principi no faria falta, pero la podriem fer servir per comprovar que la connexio funciona aixi no li passarem una cosa que no sabem si funciona
        public SqlConnection connexioSQL = null;

        //Aqui haig de fer la declaracio de la classe extra per saber si la base de dades funciona
        ClTesting testing = null;
        public ClFamilies ctrlFamilia = null;
        public ClCicles ctrlCicles = null;
        public ClModuls ctrlModuls = null;
        public ClUfs ctrlUfs = null;

        //Aqui farem la declaracio de forms que farem servir per que l'aplicació tingui totes les funcions
        FrmBD fBD;
        FrmFamilies FrmFamilies;
        FrmCicles FrmCicles;
        FrmModuls FrmModuls;
        FrmUfs frmUfs;


        public FrmMain()
        {
            InitializeComponent();
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connexioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aqui haurem de fer la lectura del arxiu, per saber quin servidor hem de fer la consulta i quina base de dades hem de fer la consulta

            //Aqui hem d'arrancar el form de la base de dades
            if (!ja_està_obert("frmBD"))
            {
                //Recorda que sempre per obrir un nou formulari hem de tenir el mdi parent activat
                fBD = new FrmBD(); //En el cas que sigui importar posarem la connSQL i el tipus de dades que volem importar
                fBD.MdiParent = this;           // --- hem fet que FRM_MAIN sigui MdiContainer i posem aquest Form com a fill seu ---

                fBD.WindowState = FormWindowState.Normal;
                fBD.Location = new System.Drawing.Point(0, 0);
                fBD.Show();
            }

        }

        Boolean ja_està_obert(String xnom_frm)
        {
            //Aquesta es la funcio que farem servir per saber si una pagina ja esta oberta actualment o no
            int x1 = 0;
            Boolean xb = false;

            while ((x1 < this.MdiChildren.Length) && (!(xb)))
            {
                xb = (this.MdiChildren[x1].Name == xnom_frm);
                x1++;
            }
            return (xb); //Aqui retornara el valor TRUE si esta oberta i FALSE si la pagina no esta oberta
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Aqui farem l'arrancada per que faci la lectura de l'arxiu del servidor de base de dades i la base de dades
            funcioobrirarxiuconfiguraciosql();
            funcioobrirconnexiosql();

            this.WindowState = FormWindowState.Maximized;
        }

        public void funcioobrirconnexiosql()
        {
            testing = new ClTesting(servidorbasedadesarxiu, basedadesarxiu);
            opcionsMenuGestio(testing.modelAccessible());
            if (testing.modelAccessible())
            {
                ctrlFamilia = new ClFamilies(servidorbasedadesarxiu, basedadesarxiu);
                ctrlCicles = new ClCicles(servidorbasedadesarxiu, basedadesarxiu);
                ctrlModuls = new ClModuls(servidorbasedadesarxiu, basedadesarxiu);
                ctrlUfs = new ClUfs(servidorbasedadesarxiu, basedadesarxiu);
            }
        }

        private void funcioobrirarxiuconfiguraciosql()
        {
            StreamReader fcfg;
            if (File.Exists(nomfitxercfg))
            {
                fcfg = new StreamReader(nomfitxercfg);
                servidorbasedadesarxiu = fcfg.ReadLine().Trim();
                basedadesarxiu = fcfg.ReadLine().Trim();
                fcfg.Close();

                //Aqui haurem de cridar a la classe ClTesting que aquesta cridara a ClTestingSqlServer que aquesta cridara a ClBDSqlServer
                testing = new ClTesting(servidorbasedadesarxiu, basedadesarxiu);
                Boolean xb = testing.modelAccessible();
                opcionsMenuGestio(testing.modelAccessible()); //Si la connexio ha sigut un succes la funcio de opcionsMenuGestio rebra un treu si no un false
            }
            else
            {
                //Aqui hauras indicat malament o no hauras indicat el nom de l'arxiu de la connexio a la base de dades
                
                //En el cas que l'arxiu de la  base de dades no existeixi, entrara a dins daquesta funcio

                opcionsMenuGestio(false);
            }
        }

        

        public void opcionsMenuGestio(Boolean xb)
        {
            //Depenent de l'estat de la connexio de la base de dades rebra un true o un false
            dadesToolStripMenuItem.Enabled = xb;
        }

        private void famíliesDeCiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aqui es a on literalment copiarem la funcio de obrir el form de families
            if ((!ja_està_obert("FrmFamilies")))
            {
                FrmFamilies = new FrmFamilies();
                FrmFamilies.MdiParent = this;
                FrmFamilies.ctrlFamilia = ctrlFamilia;
            }
            FrmFamilies.Show();
        }

        private void ciclesFormatiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((!ja_està_obert("FrmCicles")))
            {
                FrmCicles = new FrmCicles();
                FrmCicles.MdiParent = this;
                FrmCicles.ctrlCicles = ctrlCicles;
                FrmCicles.ctrlFamilies = ctrlFamilia;
            }
            FrmCicles.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void mòdulsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((!ja_està_obert("FrmModuls"))) //aQUI HAUREM DE FER EL DE MODULS
            {
                FrmModuls = new FrmModuls();
                FrmModuls.MdiParent = this;

                FrmModuls.ctrlModuls = ctrlModuls;
                FrmModuls.ctrlCicles = ctrlCicles;
            }
            FrmModuls.Show();
        }

        private void unitatsFormativesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((!ja_està_obert("FrmUfs"))) //aQUI HAUREM DE FER EL DE MODULS
            {
                frmUfs = new FrmUfs();
                frmUfs.MdiParent = this;

                frmUfs.ctrlModuls = ctrlModuls;
                frmUfs.ctrlCicles = ctrlCicles;
                frmUfs.ctrlUfs = ctrlUfs;
            }
            frmUfs.Show();
        }
    }
}
