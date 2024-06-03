using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunsplash
{
    public partial class Frm_empleados : Form
    {
        public Frm_empleados()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-UV581NK\\;Initial Catalog=SISTEMA_VENTAS;User ID=sas;Password=123456789");
        private void lbl_empleados_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Empleados_Click_1(object sender, EventArgs e)
        {

        }

        private void Frm_empleados_Load(object sender, EventArgs e)
        {
            string consulta = "select * from empleados";
            cn.Open();
            SqlDataAdapter data = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dtg_Empleados.DataSource = dt;
        }

        private void dtg_Empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Fecha_Hora_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToLongDateString();

            lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
         
         }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
