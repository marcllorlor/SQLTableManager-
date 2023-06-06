namespace Gestio_ClCicles
{
    partial class FrmUfs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUfs));
            this.dgUfs = new System.Windows.Forms.DataGridView();
            this.lbUfs = new System.Windows.Forms.Label();
            this.btQuants = new System.Windows.Forms.Button();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.lbPobl = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.btNou = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUfs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUfs
            // 
            this.dgUfs.AllowUserToAddRows = false;
            this.dgUfs.AllowUserToDeleteRows = false;
            this.dgUfs.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgUfs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUfs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUfs.Location = new System.Drawing.Point(13, 43);
            this.dgUfs.Margin = new System.Windows.Forms.Padding(4);
            this.dgUfs.MultiSelect = false;
            this.dgUfs.Name = "dgUfs";
            this.dgUfs.ReadOnly = true;
            this.dgUfs.RowHeadersVisible = false;
            this.dgUfs.RowHeadersWidth = 51;
            this.dgUfs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUfs.Size = new System.Drawing.Size(498, 500);
            this.dgUfs.TabIndex = 33;
            this.dgUfs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUfs_CellDoubleClick);
            // 
            // lbUfs
            // 
            this.lbUfs.AutoSize = true;
            this.lbUfs.BackColor = System.Drawing.Color.Orange;
            this.lbUfs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUfs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUfs.Location = new System.Drawing.Point(13, 11);
            this.lbUfs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUfs.MinimumSize = new System.Drawing.Size(500, 2);
            this.lbUfs.Name = "lbUfs";
            this.lbUfs.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbUfs.Size = new System.Drawing.Size(500, 34);
            this.lbUfs.TabIndex = 34;
            this.lbUfs.Text = "Ufs";
            this.lbUfs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btQuants
            // 
            this.btQuants.BackColor = System.Drawing.Color.SteelBlue;
            this.btQuants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuants.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuants.ForeColor = System.Drawing.Color.White;
            this.btQuants.Location = new System.Drawing.Point(9, 582);
            this.btQuants.Margin = new System.Windows.Forms.Padding(4);
            this.btQuants.Name = "btQuants";
            this.btQuants.Size = new System.Drawing.Size(259, 42);
            this.btQuants.TabIndex = 31;
            this.btQuants.Text = "&Quantes n\'hi ha amb aquest prefix?";
            this.btQuants.UseVisualStyleBackColor = false;
            this.btQuants.Click += new System.EventHandler(this.btQuants_Click);
            // 
            // tbPrefix
            // 
            this.tbPrefix.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrefix.Location = new System.Drawing.Point(177, 547);
            this.tbPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(329, 26);
            this.tbPrefix.TabIndex = 32;
            // 
            // lbPobl
            // 
            this.lbPobl.AutoSize = true;
            this.lbPobl.BackColor = System.Drawing.Color.Gray;
            this.lbPobl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPobl.ForeColor = System.Drawing.Color.White;
            this.lbPobl.Location = new System.Drawing.Point(9, 547);
            this.lbPobl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPobl.Name = "lbPobl";
            this.lbPobl.Padding = new System.Windows.Forms.Padding(4);
            this.lbPobl.Size = new System.Drawing.Size(160, 26);
            this.lbPobl.TabIndex = 30;
            this.lbPobl.Text = "Introdueix un prefix";
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.Transparent;
            this.btDel.FlatAppearance.BorderSize = 0;
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.Image = ((System.Drawing.Image)(resources.GetObject("btDel.Image")));
            this.btDel.Location = new System.Drawing.Point(519, 469);
            this.btDel.Margin = new System.Windows.Forms.Padding(4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 70);
            this.btDel.TabIndex = 29;
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
            this.btNou.Location = new System.Drawing.Point(519, 406);
            this.btNou.Margin = new System.Windows.Forms.Padding(4);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(75, 70);
            this.btNou.TabIndex = 28;
            this.btNou.UseVisualStyleBackColor = false;
            this.btNou.Click += new System.EventHandler(this.btNou_Click);
            // 
            // FrmUfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 638);
            this.Controls.Add(this.dgUfs);
            this.Controls.Add(this.lbUfs);
            this.Controls.Add(this.btQuants);
            this.Controls.Add(this.tbPrefix);
            this.Controls.Add(this.lbPobl);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btNou);
            this.Name = "FrmUfs";
            this.Text = "FrmUfs";
            this.Load += new System.EventHandler(this.FrmUfs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUfs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUfs;
        private System.Windows.Forms.Label lbUfs;
        private System.Windows.Forms.Button btQuants;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Label lbPobl;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btNou;
    }
}