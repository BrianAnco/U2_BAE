using BAE_Restaurante.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAE_Restaurante.Negocios
{
    public class LoginLog : UsuarioNegocios
    {
        public readonly UsuarioDatos datos; //Instanciamos

        public LoginLog() //Creamos el constructor
        {
            datos = new UsuarioDatos();
        }

        public override bool Login(string usuario, string contrasena)
        {
            datos.log_login(usuario);
            return base.Login(usuario, contrasena);
        }

    }
}
