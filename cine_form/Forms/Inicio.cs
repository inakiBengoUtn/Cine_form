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
    }
}
