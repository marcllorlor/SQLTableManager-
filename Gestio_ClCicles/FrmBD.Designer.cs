namespace Gestio_ClCicles
{
    partial class FrmBD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btNo = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.tbCadenaConnexio = new System.Windows.Forms.TextBox();
            this.lbCadenaConnexio = new System.Windows.Forms.Label();
            this.tbNomBD = new System.Windows.Forms.TextBox();
            this.lbNomBD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Red;
            this.btNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(415, 171);
            this.btNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(107, 34);
            this.btNo.TabIndex = 15;
            this.btNo.Text = "&Cancel·lar";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Green;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(225, 171);
            this.btOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(107, 34);
            this.btOK.TabIndex = 14;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbCadenaConnexio
            // 
            this.tbCadenaConnexio.Location = new System.Drawing.Point(23, 43);
            this.tbCadenaConnexio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCadenaConnexio.Name = "tbCadenaConnexio";
            this.tbCadenaConnexio.Size = new System.Drawing.Size(737, 22);
            this.tbCadenaConnexio.TabIndex = 13;
            // 
            // lbCadenaConnexio
            // 
            this.lbCadenaConnexio.AutoSize = true;
            this.lbCadenaConnexio.Location = new System.Drawing.Point(20, 24);
            this.lbCadenaConnexio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadenaConnexio.Name = "lbCadenaConnexio";
            this.lbCadenaConnexio.Size = new System.Drawing.Size(131, 16);
            this.lbCadenaConnexio.TabIndex = 12;
            this.lbCadenaConnexio.Text = "Cadena de connexió";
            // 
            // tbNomBD
            // 
            this.tbNomBD.Location = new System.Drawing.Point(23, 110);
            this.tbNomBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNomBD.Name = "tbNomBD";
            this.tbNomBD.Size = new System.Drawing.Size(737, 22);
            this.tbNomBD.TabIndex = 17;
            // 
            // lbNomBD
            // 
            this.lbNomBD.AutoSize = true;
            this.lbNomBD.Location = new System.Drawing.Point(20, 91);
            this.lbNomBD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomBD.Name = "lbNomBD";
            this.lbNomBD.Size = new System.Drawing.Size(58, 16);
            this.lbNomBD.TabIndex = 16;
            this.lbNomBD.Text = "Nom BD";
            // 
            // FrmBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this.tbNomBD);
            this.Controls.Add(this.lbNomBD);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbCadenaConnexio);
            this.Controls.Add(this.lbCadenaConnexio);
            this.Name = "FrmBD";
            this.Text = "FrmBD";
            this.Load += new System.EventHandler(this.FrmBD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbCadenaConnexio;
        private System.Windows.Forms.Label lbCadenaConnexio;
        private System.Windows.Forms.TextBox tbNomBD;
        private System.Windows.Forms.Label lbNomBD;
    }
}