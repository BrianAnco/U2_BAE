using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAE_Restaurante.Negocios;

namespace BAE_Restaurante.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(object frmHijo)
        {
            if (this.pnlFormulario.Controls.Count > 0)
            { this.pnlFormulario.Controls.RemoveAt(0); }
            Form fh = frmHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlFormulario.Controls.Add(fh);
            this.pnlFormulario.Tag = fh;
            fh.Show();
           
        }


        //Extraer el usuario que está en sesión.
        private void UsuarioEnSesion()
        {
                
        }

        //Cambio de colores para todos los botones al color original.
        private void RestablecerColores()
        {
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            btnEmpleados.BackColor = Color.FromArgb(32, 32, 32);
            btnCaja.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(32, 32, 32);
        }

        //Cambio de colores para los botones del menú lateral izquierdo.
        private void ColorBotonLateral(Button boton)
        {
            RestablecerColores();
            boton.BackColor = Color.FromArgb(183, 115, 229);
        }

        //Cambio de colores para los botones del menú superior.
        private void ColorBotonSuperior(Button boton)
        {
            RestablecerColores();
            boton.BackColor = Color.FromArgb(64, 64, 64);
        }



        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ColorBotonLateral(btnInicio);
            AbrirFormulario(new FrmStart());
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }


        //Botones del menú lateral izquierdo.

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            ColorBotonLateral(btnPedidos);
            AbrirFormulario(new FrmPedidos());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ColorBotonLateral(btnProductos);
            AbrirFormulario(new FrmProductos());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ColorBotonLateral(btnInicio);
            AbrirFormulario(new FrmStart());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ColorBotonLateral(btnClientes);
            AbrirFormulario(new FrmClientes());
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            ColorBotonLateral(btnMesas);
            AbrirFormulario(new FrmMesas());
        }



        //Botones del menú superior.

        private void btnCaja_Click(object sender, EventArgs e)
        {
            ColorBotonSuperior(btnCaja);
            AbrirFormulario(new FrmCaja());
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            ColorBotonSuperior(btnMantenimiento);
            AbrirFormulario(new FrmMantenimiento());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ColorBotonSuperior(btnEmpleados);
            AbrirFormulario(new FrmEmpleados());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
