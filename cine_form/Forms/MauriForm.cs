using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using cine_form.Data;

namespace cine_form.Forms
{
    public partial class MauriForm : Form
    {
        public MauriForm()
        {
            InitializeComponent();
        }

        private void ChargeData(DataTable table)
        {
            dgv.DataSource = table;
                dgv.Columns["Pelicula"].HeaderText = "Título de la Película";
                      
                dgv.Columns["EntradasVendidas"].HeaderText = "Entradas Vendidas";
                       
                dgv.Columns["RecaudacionTotal"].HeaderText = "Recaudación Total";
                                     
                dgv.Columns["PromedioPorFuncion"].HeaderText = "Precio Promedio Entrada";
        }

        private void MauriForm_Load_1(object sender, EventArgs e)
        {
            lbl.Text =
                 "Se requiere crear una consulta que muestre las películas mas vistas junto con su recaudación en orden,\n" +
                 "para eso se requiere el nombre de la película, cantidad de entradas vendidas, el monto total por película y promedio\n" +
                 "de recaudación por función. Solo se mostraran las películas cuyas entradas vendidas superen la cantidad\n" +
                 "promedio de entradas por película.";

            DataTable table = new EjecutarSp().Ejecutar("mauri");
            ChargeData(table);
        }
    }
}


