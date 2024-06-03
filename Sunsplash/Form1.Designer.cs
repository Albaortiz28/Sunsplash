namespace Sunsplash
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_cargoss = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_factura = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_bienvenidos = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.Fecha_Hora = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel_Menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.LightSalmon;
            this.panel_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_Menu.Controls.Add(this.btn_cargoss);
            this.panel_Menu.Controls.Add(this.label1);
            this.panel_Menu.Controls.Add(this.btn_inventario);
            this.panel_Menu.Controls.Add(this.btn_factura);
            this.panel_Menu.Controls.Add(this.btn_empleados);
            this.panel_Menu.Controls.Add(this.btn_clientes);
            this.panel_Menu.Controls.Add(this.panel_logo);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(233, 606);
            this.panel_Menu.TabIndex = 0;
            // 
            // btn_cargoss
            // 
            this.btn_cargoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargoss.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargoss.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_cargoss.Image = global::Sunsplash.Properties.Resources.customer_35;
            this.btn_cargoss.Location = new System.Drawing.Point(0, 543);
            this.btn_cargoss.Name = "btn_cargoss";
            this.btn_cargoss.Size = new System.Drawing.Size(58, 63);
            this.btn_cargoss.TabIndex = 7;
            this.btn_cargoss.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_cargoss.UseVisualStyleBackColor = true;
            this.btn_cargoss.Click += new System.EventHandler(this.btn_cargoss_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(-4, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "__________________________________________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.FlatAppearance.BorderSize = 0;
            this.btn_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventario.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventario.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_inventario.Image = global::Sunsplash.Properties.Resources.open_box_35px;
            this.btn_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventario.Location = new System.Drawing.Point(22, 400);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(198, 39);
            this.btn_inventario.TabIndex = 5;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.UseVisualStyleBackColor = true;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_factura
            // 
            this.btn_factura.FlatAppearance.BorderSize = 0;
            this.btn_factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_factura.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_factura.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_factura.Image = global::Sunsplash.Properties.Resources.bill_;
            this.btn_factura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_factura.Location = new System.Drawing.Point(22, 342);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(198, 39);
            this.btn_factura.TabIndex = 4;
            this.btn_factura.Text = "Factura";
            this.btn_factura.UseVisualStyleBackColor = true;
            this.btn_factura.Click += new System.EventHandler(this.btn_factura_Click);
            // 
            // btn_empleados
            // 
            this.btn_empleados.FlatAppearance.BorderSize = 0;
            this.btn_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleados.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empleados.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_empleados.Image = global::Sunsplash.Properties.Resources.customer_support_35px1;
            this.btn_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empleados.Location = new System.Drawing.Point(22, 284);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(198, 39);
            this.btn_empleados.TabIndex = 3;
            this.btn_empleados.Text = "Empleados";
            this.btn_empleados.UseVisualStyleBackColor = true;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_clientes.Image = global::Sunsplash.Properties.Resources.cliente1;
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.Location = new System.Drawing.Point(22, 221);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(187, 39);
            this.btn_clientes.TabIndex = 2;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(233, 153);
            this.panel_logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sunsplash.Properties.Resources.Sol_y_palma_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(6, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_bienvenidos
            // 
            this.lbl_bienvenidos.AutoSize = true;
            this.lbl_bienvenidos.Font = new System.Drawing.Font("Comic Sans MS", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bienvenidos.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_bienvenidos.Location = new System.Drawing.Point(404, 69);
            this.lbl_bienvenidos.Name = "lbl_bienvenidos";
            this.lbl_bienvenidos.Size = new System.Drawing.Size(508, 94);
            this.lbl_bienvenidos.TabIndex = 12;
            this.lbl_bienvenidos.Text = "Bienvenidos/as";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_fecha.Location = new System.Drawing.Point(420, 291);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(42, 49);
            this.lbl_fecha.TabIndex = 15;
            this.lbl_fecha.Text = "h";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_hora.Location = new System.Drawing.Point(515, 186);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(58, 67);
            this.lbl_hora.TabIndex = 16;
            this.lbl_hora.Text = "F";
            // 
            // Fecha_Hora
            // 
            this.Fecha_Hora.Enabled = true;
            this.Fecha_Hora.Tick += new System.EventHandler(this.Fecha_Hora_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.Image = global::Sunsplash.Properties.Resources.maximizar2;
            this.pictureBox2.Location = new System.Drawing.Point(1133, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox5.Image = global::Sunsplash.Properties.Resources.Minimize_Window_35px;
            this.pictureBox5.Location = new System.Drawing.Point(1087, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox4.Image = global::Sunsplash.Properties.Resources.Maximize;
            this.pictureBox4.Location = new System.Drawing.Point(1109, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1162, 606);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_bienvenidos);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel_Menu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbl_bienvenidos;
        private System.Windows.Forms.Button btn_cargoss;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer Fecha_Hora;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

