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

namespace cine_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInaki_Click(object sender, EventArgs e)
        {
            lblText.Text = "" +
                "La consulta obtiene las ventas totales de los últimos 6 meses, por producto y entrada de cine. \n" +
                "Priemer subconsulta que obtiene los productos vendidos, cantidad vendido, dinero que genero \n" +
                "y cantidad de facturas que lo incluye en los ultimos 6 meses simpre que el subtotal del producto sea mayor a 1000.\n" +
                "Segunda subconsulta que obtiene cantidad de entradas vendidas, dinero generado por las entradas, \n" + 
                "cantidad de veces que aparece en facturas y agrupado por estado de cada reserva";

            GridView.DataSource = null;
            DataTable table = new EjecutarSp().Ejecutar("sp_BengoInaki");
            CargarGrid(table);
        }

        private void CargarGrid(DataTable table)
        {
            GridView.DataSource = table;
        }

        private void btnAlexis_Click(object sender, EventArgs e)
        {
            lblText.Text = "" +
                "Obtener el total recaudado, cantidad de funciones y promedio de precios de entradas por mes y por película. \n" +
                "Solo se incluyen películas cuyo idioma es inglés y las funciones del mes que superaron las 300 entradas vendidas. ";
            GridView.DataSource = null;
            DataTable table = new EjecutarSp().Ejecutar("Alexis");
            CargarGrid(table);
        }

        private void btnCristian_Click(object sender, EventArgs e)
        {
            lblText.Text = "" +
                "Crear una vista que agrupe productos por sucursales y muestra su stock actual, las ventas acumuladas del último año, \n" +
                "la recaudación total. Verificar que los productos deben tener algún ingreso en el ultimo mes.(Para verificar que este activo). \n" +
                "Para productos sin rotación:";
            GridView.DataSource = null;
            DataSet table = new EjecutarSp().EjecutarVarios("cristian");
            CargarGrid(table.Tables[0]);
        }

        private void btnMatheo_Click(object sender, EventArgs e)
        {
            lblText.Text = "" +
               "Mostrar todas las películas del mes que tuvieron una cantidad de funciones superior a la cantidad de funciones \n" +
               "de una película específica,  y aquellas películas que registraron reservas confirmadas.";
            GridView.DataSource = null;
            DataTable table = new EjecutarSp().Ejecutar("matheo");
            CargarGrid(table);
        }

        private void btnMauri_Click(object sender, EventArgs e)
        {
            lblText.Text = "" +
               " Se requiere crear una consulta que muestre las películas mas vistas junto con su recaudación en orden, para eso \n" +
               "se requiere el nombre de la película, cantidad de entradas vendidas, el monto total por película y promedio de  \n" +
               "recaudación por función. Solo se mostraran las películas cuyas entradas vendidas superen la cantidad promedio \n" +
               "de entradas por película.";
            GridView.DataSource = null;
            DataTable table = new EjecutarSp().Ejecutar("mauri");
            CargarGrid(table);
        }

        private void btnCristian2_Click(object sender, EventArgs e)
        {
            lblText.Text = "" +
               "Reporte de los productos activos, incluso los que no se vendieron. Para productos sin rotación: \n" +
               "Recaudacion total por sucursal:";
            GridView.DataSource = null;
            DataSet table = new EjecutarSp().EjecutarVarios("cristian");
            CargarGrid(table.Tables[1]);
        }

        private void btnCristian3_Click(object sender, EventArgs e)
        {
            lblText.Text = "" +
               "Reporte de los productos activos, incluso los que no se vendieron. Para productos sin rotación: \n" +
               "Balance de stock general:";
            GridView.DataSource = null;
            DataSet table = new EjecutarSp().EjecutarVarios("cristian");
            CargarGrid(table.Tables[2]);
        }
    }
}
