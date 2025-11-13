namespace cine_form.Forms
{
    partial class CristianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CristianForm));
            this.dgvVista = new System.Windows.Forms.DataGridView();
            this.lblVista = new System.Windows.Forms.Label();
            this.cboVista = new System.Windows.Forms.ComboBox();
            this.btnVista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVista
            // 
            this.dgvVista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVista.Location = new System.Drawing.Point(44, 199);
            this.dgvVista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVista.Name = "dgvVista";
            this.dgvVista.RowHeadersWidth = 51;
            this.dgvVista.Size = new System.Drawing.Size(876, 324);
            this.dgvVista.TabIndex = 0;
            this.dgvVista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblVista
            // 
            this.lblVista.AutoSize = true;
            this.lblVista.Location = new System.Drawing.Point(40, 52);
            this.lblVista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVista.Name = "lblVista";
            this.lblVista.Size = new System.Drawing.Size(44, 16);
            this.lblVista.TabIndex = 1;
            this.lblVista.Text = "label1";
            // 
            // cboVista
            // 
            this.cboVista.FormattingEnabled = true;
            this.cboVista.Location = new System.Drawing.Point(44, 130);
            this.cboVista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboVista.Name = "cboVista";
            this.cboVista.Size = new System.Drawing.Size(728, 24);
            this.cboVista.TabIndex = 2;
            this.cboVista.SelectedIndexChanged += new System.EventHandler(this.cboVista_SelectedIndexChanged);
            // 
            // btnVista
            // 
            this.btnVista.Location = new System.Drawing.Point(820, 130);
            this.btnVista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVista.Name = "btnVista";
            this.btnVista.Size = new System.Drawing.Size(100, 28);
            this.btnVista.TabIndex = 3;
            this.btnVista.Text = "Consultar";
            this.btnVista.UseVisualStyleBackColor = true;
            this.btnVista.Click += new System.EventHandler(this.btnVista_Click);
            // 
            // CristianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 596);
            this.Controls.Add(this.btnVista);
            this.Controls.Add(this.cboVista);
            this.Controls.Add(this.lblVista);
            this.Controls.Add(this.dgvVista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CristianForm";
            this.Text = "CristianForm";
            this.Load += new System.EventHandler(this.CristianForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVista;
        private System.Windows.Forms.Label lblVista;
        private System.Windows.Forms.ComboBox cboVista;
        private System.Windows.Forms.Button btnVista;
    }
}