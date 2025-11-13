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
using System.Xml;

namespace cine_form.Forms
{
    public partial class MatheoForm : Form
    {
        public MatheoForm()
        {
            InitializeComponent();
        }

        private void MatheoForm_Load(object sender, EventArgs e)
        {
            lblMatheo.Text =
            @"Esta consulta muestra dos resultados sobre las películas del mes actual:

            • Películas con mayor cantidad de funciones que la película con ID 1.
            • Películas que registraron reservas confirmadas.

            Primera parte:
            Muestra las películas que tuvieron más funciones que la película seleccionada,
            considerando solamente las funciones realizadas en el mes actual.

            Segunda parte:
            Muestra las películas que registraron reservas confirmadas en el mismo período.

            Ambos resultados se combinan mediante UNION para generar un único listado.";


            DataTable table = new EjecutarSp().Ejecutar("matheo");
            ChargeData(table);
        }

        private void ChargeData(DataTable table)
        {
            dgv.DataSource = table;

            dgv.Columns["Pelicula"].HeaderText = "Película";
            dgv.Columns["Cantidad"].HeaderText = "Cantidad de funciones / reservas";
            dgv.Columns["Tipo"].HeaderText = "Tipo de registro";

            
            dgv.RowHeadersVisible = false;

            
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
    }
}
