using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using BAE_Restaurante.Negocios;
using BAE_Restaurante.Entidad;
using BAE_Restaurante.Datos;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantTestd
{
    [TestClass]
    public class comida
    {
        [TestMethod]
        public void ComidaTestListar()
        {
            ComidaDatos objDatos = new ComidaDatos();
            ComidaEntidad objDatosE = new ComidaEntidad();
            DataTable tabla = new DataTable();
            tabla = objDatos.Listar();
        }
        [TestMethod]
        public void ComidaTestBuscar()
        {
            String Busqueda = "Arroz Chaufa";
            ComidaDatos objDatos = new ComidaDatos();
            ComidaEntidad objDatosE = new ComidaEntidad();
            DataTable tabla = new DataTable();
            tabla = objDatos.Buscar(Busqueda);

        }

    }
}
