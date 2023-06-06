namespace Gestio_ClCicles
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnu_main = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famíliesDeCiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciclesFormatiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mòdulsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitatsFormativesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_main
            // 
            this.mnu_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.dadesToolStripMenuItem});
            this.mnu_main.Location = new System.Drawing.Point(0, 0);
            this.mnu_main.Name = "mnu_main";
            this.mnu_main.Size = new System.Drawing.Size(849, 28);
            this.mnu_main.TabIndex = 0;
            this.mnu_main.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexioToolStripMenuItem,
            this.sortirToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // connexioToolStripMenuItem
            // 
            this.connexioToolStripMenuItem.Name = "connexioToolStripMenuItem";
            this.connexioToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.connexioToolStripMenuItem.Text = "Connexió BD";
            this.connexioToolStripMenuItem.Click += new System.EventHandler(this.connexioToolStripMenuItem_Click);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // dadesToolStripMenuItem
            // 
            this.dadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.famíliesDeCiclesToolStripMenuItem,
            this.ciclesFormatiusToolStripMenuItem,
            this.mòdulsToolStripMenuItem,
            this.unitatsFormativesToolStripMenuItem});
            this.dadesToolStripMenuItem.Name = "dadesToolStripMenuItem";
            this.dadesToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.dadesToolStripMenuItem.Text = "Dades";
            // 
            // famíliesDeCiclesToolStripMenuItem
            // 
            this.famíliesDeCiclesToolStripMenuItem.Name = "famíliesDeCiclesToolStripMenuItem";
            this.famíliesDeCiclesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.famíliesDeCiclesToolStripMenuItem.Text = "Famílies de Cicles";
            this.famíliesDeCiclesToolStripMenuItem.Click += new System.EventHandler(this.famíliesDeCiclesToolStripMenuItem_Click);
            // 
            // ciclesFormatiusToolStripMenuItem
            // 
            this.ciclesFormatiusToolStripMenuItem.Name = "ciclesFormatiusToolStripMenuItem";
            this.ciclesFormatiusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ciclesFormatiusToolStripMenuItem.Text = "Cicles Formatius";
            this.ciclesFormatiusToolStripMenuItem.Click += new System.EventHandler(this.ciclesFormatiusToolStripMenuItem_Click);
            // 
            // mòdulsToolStripMenuItem
            // 
            this.mòdulsToolStripMenuItem.Name = "mòdulsToolStripMenuItem";
            this.mòdulsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mòdulsToolStripMenuItem.Text = "Mòduls";
            this.mòdulsToolStripMenuItem.Click += new System.EventHandler(this.mòdulsToolStripMenuItem_Click);
            // 
            // unitatsFormativesToolStripMenuItem
            // 
            this.unitatsFormativesToolStripMenuItem.Name = "unitatsFormativesToolStripMenuItem";
            this.unitatsFormativesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.unitatsFormativesToolStripMenuItem.Text = "Unitats Formatives";
            this.unitatsFormativesToolStripMenuItem.Click += new System.EventHandler(this.unitatsFormativesToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 509);
            this.Controls.Add(this.mnu_main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnu_main;
            this.Name = "FrmMain";
            this.Text = "Activitat 4 Marc Llorca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnu_main.ResumeLayout(false);
            this.mnu_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_main;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem famíliesDeCiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciclesFormatiusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mòdulsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitatsFormativesToolStripMenuItem;
    }
}

