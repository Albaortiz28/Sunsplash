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
    public partial class Frm_factura : Form
    {
        public Frm_factura()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-UV581NK\\;Initial Catalog=SISTEMA_VENTAS;User ID=sas;Password=123456789");
        private void Frm_factura_Load(object sender, EventArgs e)
        {
            string consulta = "select * from factura";
            cn.Open();
            SqlDataAdapter data = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dtg_Factura.DataSource = dt;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void Fecha_Hora_Tick(object sender, EventArgs e)
        {

            lbl_fecha.Text = DateTime.Now.ToLongDateString();

            lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
