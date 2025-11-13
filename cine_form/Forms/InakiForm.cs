using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cine_form.Data;

namespace cine_form.Forms
{
    public partial class InakiForm : Form
    {
        public InakiForm()
        {
            InitializeComponent();
        }

        private void InakiForm_Load(object sender, EventArgs e)
        {
            lbl.Text = "" +
                "La consulta obtiene las ventas totales de los últimos 6 meses, por producto y entrada de cine.\n\n" +
                "Priemer subconsulta que obtiene los productos vendidos, cantidad vendido, dinero que genero\n" +
                "y cantidad de facturas que lo incluye en los ultimos 6 meses simpre que el subtotal del\n" +
                "producto sea mayor a 1000.\n" +
                "Segunda subconsulta que obtiene cantidad de entradas vendidas, dinero generado por las \n" +
                "entradas,  cantidad de veces que aparece en facturas y agrupado por estado de cada reserva";

            DataTable table = new EjecutarSp().Ejecutar("sp_BengoInaki");
            ChargeData(table);
        }

        private void ChargeData(DataTable table)
        {
            dgv.DataSource = table;
            dgv.Columns["fuente"].HeaderText = "Fuente";
            dgv.Columns["id_item"].HeaderText = "Id item";
            dgv.Columns["item_nombre"].HeaderText = "Nombre";
            dgv.Columns["total_cantidad"].HeaderText = "Cantidad vendida";
            dgv.Columns["total_monto"].HeaderText = "Dinero generado";
            dgv.Columns["num_facturas"].HeaderText = "Cantidad de facturas";
            dgv.Columns["precio_promedio_unitario"].HeaderText = "Precio promedio unitario";
        }
    }
}
