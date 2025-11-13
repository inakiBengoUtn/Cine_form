namespace cine_form.Forms
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.procedimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iñakiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alexisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matheoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mauricioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cristianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procedimientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(801, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // procedimientosToolStripMenuItem
            // 
            this.procedimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iñakiToolStripMenuItem,
            this.alexisToolStripMenuItem,
            this.matheoToolStripMenuItem,
            this.mauricioToolStripMenuItem,
            this.cristianToolStripMenuItem});
            this.procedimientosToolStripMenuItem.Name = "procedimientosToolStripMenuItem";
            this.procedimientosToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.procedimientosToolStripMenuItem.Text = "Procedimientos";
            // 
            // iñakiToolStripMenuItem
            // 
            this.iñakiToolStripMenuItem.Name = "iñakiToolStripMenuItem";
            this.iñakiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iñakiToolStripMenuItem.Text = "Iñaki";
            this.iñakiToolStripMenuItem.Click += new System.EventHandler(this.iñakiToolStripMenuItem_Click);
            // 
            // alexisToolStripMenuItem
            // 
            this.alexisToolStripMenuItem.Name = "alexisToolStripMenuItem";
            this.alexisToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.alexisToolStripMenuItem.Text = "Alexis";
            // 
            // matheoToolStripMenuItem
            // 
            this.matheoToolStripMenuItem.Name = "matheoToolStripMenuItem";
            this.matheoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.matheoToolStripMenuItem.Text = "Matheo";
            this.matheoToolStripMenuItem.Click += new System.EventHandler(this.matheoToolStripMenuItem_Click);
            // 
            // mauricioToolStripMenuItem
            // 
            this.mauricioToolStripMenuItem.Name = "mauricioToolStripMenuItem";
            this.mauricioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mauricioToolStripMenuItem.Text = "Mauricio";
            this.mauricioToolStripMenuItem.Click += new System.EventHandler(this.mauricioToolStripMenuItem_Click);
            // 
            // cristianToolStripMenuItem
            // 
            this.cristianToolStripMenuItem.Name = "cristianToolStripMenuItem";
            this.cristianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cristianToolStripMenuItem.Text = "Cristian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cine Admin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::cine_form.Properties.Resources.cine;
            this.pictureBox2.Location = new System.Drawing.Point(127, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(547, 287);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem procedimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iñakiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alexisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matheoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mauricioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cristianToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}