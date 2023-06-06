namespace Gestio_ClCicles
{
    partial class FrmFamilies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFamilies));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btQuants = new System.Windows.Forms.Button();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.lbPobl = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.btNou = new System.Windows.Forms.Button();
            this.lbhdr = new System.Windows.Forms.Label();
            this.dgFamilies = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgFamilies)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuants
            // 
            this.btQuants.BackColor = System.Drawing.Color.SteelBlue;
            this.btQuants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuants.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuants.ForeColor = System.Drawing.Color.White;
            this.btQuants.Location = new System.Drawing.Point(19, 586);
            this.btQuants.Margin = new System.Windows.Forms.Padding(4);
            this.btQuants.Name = "btQuants";
            this.btQuants.Size = new System.Drawing.Size(259, 42);
            this.btQuants.TabIndex = 17;
            this.btQuants.Text = "&Quantes n\'hi ha amb aquest prefix?";
            this.btQuants.UseVisualStyleBackColor = false;
            this.btQuants.Click += new System.EventHandler(this.btQuants_Click);
            // 
            // tbPrefix
            // 
            this.tbPrefix.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrefix.Location = new System.Drawing.Point(187, 551);
            this.tbPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(329, 26);
            this.tbPrefix.TabIndex = 18;
            // 
            // lbPobl
            // 
            this.lbPobl.AutoSize = true;
            this.lbPobl.BackColor = System.Drawing.Color.Gray;
            this.lbPobl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPobl.ForeColor = System.Drawing.Color.White;
            this.lbPobl.Location = new System.Drawing.Point(19, 551);
            this.lbPobl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPobl.Name = "lbPobl";
            this.lbPobl.Padding = new System.Windows.Forms.Padding(4);
            this.lbPobl.Size = new System.Drawing.Size(160, 26);
            this.lbPobl.TabIndex = 15;
            this.lbPobl.Text = "Introdueix un prefix";
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.Transparent;
            this.btDel.FlatAppearance.BorderSize = 0;
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.Image = ((System.Drawing.Image)(resources.GetObject("btDel.Image")));
            this.btDel.Location = new System.Drawing.Point(529, 473);
            this.btDel.Margin = new System.Windows.Forms.Padding(4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 70);
            this.btDel.TabIndex = 14;
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
            this.btNou.Location = new System.Drawing.Point(529, 410);
            this.btNou.Margin = new System.Windows.Forms.Padding(4);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(75, 70);
            this.btNou.TabIndex = 13;
            this.btNou.UseVisualStyleBackColor = false;
            this.btNou.Click += new System.EventHandler(this.btNou_Click);
            // 
            // lbhdr
            // 
            this.lbhdr.AutoSize = true;
            this.lbhdr.BackColor = System.Drawing.Color.Orange;
            this.lbhdr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbhdr.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhdr.Location = new System.Drawing.Point(107, -82);
            this.lbhdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbhdr.MinimumSize = new System.Drawing.Size(500, 2);
            this.lbhdr.Name = "lbhdr";
            this.lbhdr.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbhdr.Size = new System.Drawing.Size(500, 34);
            this.lbhdr.TabIndex = 12;
            this.lbhdr.Text = "famílies";
            this.lbhdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgFamilies
            // 
            this.dgFamilies.AllowUserToAddRows = false;
            this.dgFamilies.AllowUserToDeleteRows = false;
            this.dgFamilies.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgFamilies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFamilies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFamilies.Location = new System.Drawing.Point(23, 47);
            this.dgFamilies.Margin = new System.Windows.Forms.Padding(4);
            this.dgFamilies.MultiSelect = false;
            this.dgFamilies.Name = "dgFamilies";
            this.dgFamilies.ReadOnly = true;
            this.dgFamilies.RowHeadersVisible = false;
            this.dgFamilies.RowHeadersWidth = 51;
            this.dgFamilies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFamilies.Size = new System.Drawing.Size(498, 500);
            this.dgFamilies.TabIndex = 19;
            this.dgFamilies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCP_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(500, 2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.label1.Size = new System.Drawing.Size(500, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "famílies";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmFamilies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 687);
            this.Controls.Add(this.dgFamilies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuants);
            this.Controls.Add(this.tbPrefix);
            this.Controls.Add(this.lbPobl);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btNou);
            this.Controls.Add(this.lbhdr);
            this.Name = "FrmFamilies";
            this.Text = "FrmFamilies";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFamilies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuants;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Label lbPobl;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btNou;
        private System.Windows.Forms.Label lbhdr;
        private System.Windows.Forms.DataGridView dgFamilies;
        private System.Windows.Forms.Label label1;
    }
}