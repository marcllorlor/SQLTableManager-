namespace Gestio_ClCicles
{
    partial class FrmModuls
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModuls));
            this.dgModuls = new System.Windows.Forms.DataGridView();
            this.lbModuls = new System.Windows.Forms.Label();
            this.btQuants = new System.Windows.Forms.Button();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.lbPobl = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.btNou = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgModuls)).BeginInit();
            this.SuspendLayout();
            // 
            // dgModuls
            // 
            this.dgModuls.AllowUserToAddRows = false;
            this.dgModuls.AllowUserToDeleteRows = false;
            this.dgModuls.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgModuls.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgModuls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModuls.Location = new System.Drawing.Point(13, 48);
            this.dgModuls.Margin = new System.Windows.Forms.Padding(4);
            this.dgModuls.MultiSelect = false;
            this.dgModuls.Name = "dgModuls";
            this.dgModuls.ReadOnly = true;
            this.dgModuls.RowHeadersVisible = false;
            this.dgModuls.RowHeadersWidth = 51;
            this.dgModuls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgModuls.Size = new System.Drawing.Size(498, 500);
            this.dgModuls.TabIndex = 33;
            this.dgModuls.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgModuls_CellDoubleClick);
            // 
            // lbModuls
            // 
            this.lbModuls.AutoSize = true;
            this.lbModuls.BackColor = System.Drawing.Color.Orange;
            this.lbModuls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbModuls.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModuls.Location = new System.Drawing.Point(13, 16);
            this.lbModuls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModuls.MinimumSize = new System.Drawing.Size(500, 2);
            this.lbModuls.Name = "lbModuls";
            this.lbModuls.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbModuls.Size = new System.Drawing.Size(500, 34);
            this.lbModuls.TabIndex = 34;
            this.lbModuls.Text = "Moduls";
            this.lbModuls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btQuants
            // 
            this.btQuants.BackColor = System.Drawing.Color.SteelBlue;
            this.btQuants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuants.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuants.ForeColor = System.Drawing.Color.White;
            this.btQuants.Location = new System.Drawing.Point(9, 587);
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
            this.tbPrefix.Location = new System.Drawing.Point(177, 552);
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
            this.lbPobl.Location = new System.Drawing.Point(9, 552);
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
            this.btDel.Location = new System.Drawing.Point(519, 474);
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
            this.btNou.Location = new System.Drawing.Point(519, 411);
            this.btNou.Margin = new System.Windows.Forms.Padding(4);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(75, 70);
            this.btNou.TabIndex = 28;
            this.btNou.UseVisualStyleBackColor = false;
            this.btNou.Click += new System.EventHandler(this.btNou_Click);
            // 
            // FrmModuls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 657);
            this.Controls.Add(this.dgModuls);
            this.Controls.Add(this.lbModuls);
            this.Controls.Add(this.btQuants);
            this.Controls.Add(this.tbPrefix);
            this.Controls.Add(this.lbPobl);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btNou);
            this.Name = "FrmModuls";
            this.Text = "FrmModuls";
            this.Load += new System.EventHandler(this.FrmModuls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgModuls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgModuls;
        private System.Windows.Forms.Label lbModuls;
        private System.Windows.Forms.Button btQuants;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Label lbPobl;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btNou;
    }
}