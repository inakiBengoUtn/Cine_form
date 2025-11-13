using System;
using System.Windows.Forms;

namespace cine_form.Forms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void iñakiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InakiForm form = new InakiForm();
            form.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void matheoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatheoForm form = new MatheoForm();
            form.Show();
        }

        private void mauricioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MauriForm form =  new MauriForm();
            form.Show();
        }

        private void cristianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CristianForm form = new CristianForm();
            form.Show();
        }
    }
}
