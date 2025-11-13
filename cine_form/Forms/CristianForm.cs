using cine_form.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cine_form.Forms
{
    public partial class CristianForm : Form
    {
        EjecutarSp dao;
        public CristianForm()
        {
            InitializeComponent();
            dao = new EjecutarSp();
        }

        private void CristianForm_Load(object sender, EventArgs e)
        {
            cboVista.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVista.Items.Add("Vista Principal");
            cboVista.Items.Add("Productos sin rotación");
            cboVista.Items.Add("Recaudación total por Sucursal"); 
            cboVista.Items.Add("Balance stock general");
            cboVista.Items.Add("Seleccione una consulta...");
            this.dgvVista.AllowUserToAddRows = false;
            this.dgvVista.RowHeadersVisible = false;

            lblVista.Text = "Crear una vista que agrupe productos por sucursales y muestra su stock actual, las ventas acumuladas del último año,la recaudación total. \n" +
                                              "Verificar que los productos deben tener algún ingreso en el ultimo mes.(Para verificar que este activo).";
            this.dgvVista.ReadOnly = true;
            DataTable table = new EjecutarSp().Ejecutar("Cristian");
            ChargeData(table);
            this.cboVista.SelectedIndex = 4;
        }
        private void ChargeData(DataTable table)
        {
            dgvVista.DataSource = table;
        }

        private void cboVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboVista.SelectedIndex)
            {
                case 0:
                    lblVista.Text = "Crear una vista que agrupe productos por sucursales y muestra su stock actual, las ventas acumuladas del último año,la recaudación total. \n" +
                                              "Verificar que los productos deben tener algún ingreso en el ultimo mes.(Para verificar que este activo)."; 
                    break;
                case 1:
                    lblVista.Text = "Reporte de los productos activos, incluso los que no se vendieron. Para productos sin rotación:";
                    break;
                case 2:
                    lblVista.Text = "Recaudacion total por sucursal:";
                    break;
                case 3:
                    lblVista.Text = "Balance de stock general:";
                    break;
                case 4:
                    lblVista.Text = "Seleccione una consulta...";
                    break;

            }
        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            int opcion = cboVista.SelectedIndex;
            if (opcion != -1)
            {
                dgvVista.DataSource = dao.ObtenerResultados(opcion);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una consulta.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
