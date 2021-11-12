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
    public partial class FrmLogin : Form
    {
        public readonly UsuarioNegocios negocios; //Instanciamos
        public FrmLogin()
        {
            InitializeComponent();
            negocios = new UsuarioNegocios();
        }



        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "BAE Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (negocios.Login(txtUser.Text, txtPas.Text) == true)
            {
                FrmPrincipal mv = new FrmPrincipal();
                mv.lblUser.Text = txtUser.Text;
                mv.Show();
                this.Hide();
            }
            else
            {
                this.MensajeError("Usuario o contraseña incorrectos.");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
