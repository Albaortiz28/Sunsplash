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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\I1.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            lbl_bienvenidos.BackColor = Color.Transparent;
            lbl_fecha.BackColor = Color.Transparent;
            lbl_hora.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form formulario = new Frm_clientes();
            formulario.Show();
            Form1 frm = new Form1();
            frm.Hide();
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            Form formulario = new Frm_factura();
            formulario.Show();
            Form1 frm = new Form1();
            frm.Hide();
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            Form formulario = new Frm_empleados();
            formulario.Show();
            Form1 frm = new Form1();
            frm.Hide();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {

            Form formulario = new Frm_inventario();
            formulario.Show();
            Form1 frm = new Form1();
            frm.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cargoss_Click(object sender, EventArgs e)
        {
            Form formulario = new Frmcargos();
            formulario.Show();
            Form1 frm = new Form1();
            frm.Hide();
        }

        private void Fecha_Hora_Tick(object sender, EventArgs e)
        {

            lbl_fecha.Text = DateTime.Now.ToLongDateString();

            lbl_hora.Text = DateTime.Now.ToLongTimeString(); 

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}