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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sunsplash
{
    public partial class Frm_clientes : Form
    {
        public Frm_clientes()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-UV581NK\\;Initial Catalog=SISTEMA_VENTAS;User ID=sas;Password=123456789");
        #region Metodos

        public void Eliminar()
        {

            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.CommandText = @"Delete Cliente set 
                            nombre   = '" + textBox02.Text + " ',  " +
                            " email = '" + textBox03.Text + " ',  " +
                            " telefono = '" + textBox04.Text + " ',  " +
                            " direccion = '" + textBox05.Text + " ',  " +
                            " where Codigo = '" + textBox01.Text + " ' " + "";
            cn.Open();
            command.ExecuteNonQuery();
            
            MessageBox.Show("Registro Elminido");

            string consulta = "select * from Cliente";
            cn.Open();
            SqlDataAdapter data = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dtg_Clientes.DataSource = dt;
            cn.Close();

        }

        public void Modificar()
        {

            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.CommandText = @"update Cliente set 
                            nombre   = '" + textBox02.Text + " ',  " +
                            " email = '" + textBox03.Text + " ',  " +
                            " telefono = '" + textBox04.Text + " ',  " +
                            " direccion = '" + textBox05.Text + " ',  " +
                            " where Codigo = '" + textBox01.Text + " ' " + "";
            cn.Open();
            command.ExecuteNonQuery();
            
            MessageBox.Show("Registro Actualizado");


            string consulta = "select * from Cliente";
            cn.Open();
            SqlDataAdapter data = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dtg_Clientes.DataSource = dt;
            cn.Close();
        }

        public void Consultar()
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-UV581NK\\;Initial Catalog=SISTEMA_VENTAS;User ID=sas;Password=123456789");
            SqlCommand command = new SqlCommand(" Select * from Cliente where Id_cliente =" + "'" + textBox01.Text + "'", cn);

            
            cn.Open();
            SqlDataReader registro = command.ExecuteReader();
            if (registro.Read())
            {
                textBox02.Text = registro["nombre"].ToString();
                textBox03.Text = registro["email"].ToString();
                textBox04.Text = registro["telefono"].ToString();
                textBox05.Text = registro["direccion"].ToString();
            }
            


            string consulta = " Select * from Cliente where Id_cliente =" + "'" + textBox01.Text + "'" + cn;
            cn.Open();
            SqlDataAdapter data = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dtg_Clientes.DataSource = dt;
            cn.Close();
            
        }

        public void Guardar()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.CommandText = "INSERT INTO Cliente (nombre,email,telefono,direccion)VALUES(' " + textBox02.Text + "','" + textBox03.Text + "','" + textBox04.Text + "','" + textBox05.Text + "')";
 
            command.ExecuteNonQuery();
            cn.Open();

            
            MessageBox.Show("Registro Almacenado");

            string consulta = "select * from Cliente";
            SqlDataAdapter data = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dtg_Clientes.DataSource = dt;
            cn.Close();
        }
        

        #endregion


        private void Frm_clientes_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Cliente";
            cn.Open();
            SqlDataAdapter data = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dtg_Clientes.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Guardar();


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
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
    }
}
