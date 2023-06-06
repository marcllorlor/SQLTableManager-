namespace Gestio_ClCicles
{
    partial class FrmCicles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCicles));
            this.dgCicles = new System.Windows.Forms.DataGridView();
            this.lbCicles = new System.Windows.Forms.Label();
            this.btQuants = new System.Windows.Forms.Button();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.lbPobl = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.btNou = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCicles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCicles
            // 
            this.dgCicles.AllowUserToAddRows = false;
            this.dgCicles.AllowUserToDeleteRows = false;
            this.dgCicles.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgCicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCicles.Location = new System.Drawing.Point(24, 50);
            this.dgCicles.Margin = new System.Windows.Forms.Padding(4);
            this.dgCicles.MultiSelect = false;
            this.dgCicles.Name = "dgCicles";
            this.dgCicles.ReadOnly = true;
            this.dgCicles.RowHeadersVisible = false;
            this.dgCicles.RowHeadersWidth = 51;
            this.dgCicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCicles.Size = new System.Drawing.Size(498, 500);
            this.dgCicles.TabIndex = 26;
            this.dgCicles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCP_CellDoubleClick);
            // 
            // lbCicles
            // 
            this.lbCicles.AutoSize = true;
            this.lbCicles.BackColor = System.Drawing.Color.Orange;
            this.lbCicles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCicles.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCicles.Location = new System.Drawing.Point(24, 18);
            this.lbCicles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCicles.MinimumSize = new System.Drawing.Size(500, 2);
            this.lbCicles.Name = "lbCicles";
            this.lbCicles.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbCicles.Size = new System.Drawing.Size(500, 34);
            this.lbCicles.TabIndex = 27;
            this.lbCicles.Text = "cicles";
            this.lbCicles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btQuants
            // 
            this.btQuants.BackColor = System.Drawing.Color.SteelBlue;
            this.btQuants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuants.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuants.ForeColor = System.Drawing.Color.White;
            this.btQuants.Location = new System.Drawing.Point(20, 589);
            this.btQuants.Margin = new System.Windows.Forms.Padding(4);
            this.btQuants.Name = "btQuants";
            this.btQuants.Size = new System.Drawing.Size(259, 42);
            this.btQuants.TabIndex = 24;
            this.btQuants.Text = "&Quantes n\'hi ha amb aquest prefix?";
            this.btQuants.UseVisualStyleBackColor = false;
            this.btQuants.Click += new System.EventHandler(this.btQuants_Click);
            // 
            // tbPrefix
            // 
            this.tbPrefix.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrefix.Location = new System.Drawing.Point(188, 554);
            this.tbPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(329, 26);
            this.tbPrefix.TabIndex = 25;
            // 
            // lbPobl
            // 
            this.lbPobl.AutoSize = true;
            this.lbPobl.BackColor = System.Drawing.Color.Gray;
            this.lbPobl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPobl.ForeColor = System.Drawing.Color.White;
            this.lbPobl.Location = new System.Drawing.Point(20, 554);
            this.lbPobl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPobl.Name = "lbPobl";
            this.lbPobl.Padding = new System.Windows.Forms.Padding(4);
            this.lbPobl.Size = new System.Drawing.Size(160, 26);
            this.lbPobl.TabIndex = 23;
            this.lbPobl.Text = "Introdueix un prefix";
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.Transparent;
            this.btDel.FlatAppearance.BorderSize = 0;
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.Image = ((System.Drawing.Image)(resources.GetObject("btDel.Image")));
            this.btDel.Location = new System.Drawing.Point(530, 476);
            this.btDel.Margin = new System.Windows.Forms.Padding(4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 70);
            this.btDel.TabIndex = 22;
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btNou
            // 
            this.btNou.BackColor = System.Drawing.Color.Transparent;
            this.btNou.FlatAppearance.BorderSize = 0;
            this.btNou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNou.ForeColor = System.Drawing.Color.Transparent;
            this.btNou.Image = ((System.Drawing.Image)(resources.GetObject("btNou.Image")));
            this.btNou.Location = new System.Drawing.Point(530, 413);
            this.btNou.Margin = new System.Windows.Forms.Padding(4);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(75, 70);
            this.btNou.TabIndex = 21;
            this.btNou.UseVisualStyleBackColor = false;
            this.btNou.Click += new System.EventHandler(this.btNou_Click);
            // 
            // FrmCicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 649);
            this.Controls.Add(this.dgCicles);
            this.Controls.Add(this.lbCicles);
            this.Controls.Add(this.btQuants);
            this.Controls.Add(this.tbPrefix);
            this.Controls.Add(this.lbPobl);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btNou);
            this.Name = "FrmCicles";
            this.Text = "FrmCicles";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCicles;
        private System.Windows.Forms.Label lbCicles;
        private System.Windows.Forms.Button btQuants;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Label lbPobl;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btNou;
    }
}