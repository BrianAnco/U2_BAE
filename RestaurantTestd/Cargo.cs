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
    public class Cargo
    {
        [TestMethod]
        public void CargoTestListar()
        {
            CargoDatos objDatos = new CargoDatos();
            CargoEntidad objDatosE = new CargoEntidad();
            DataTable tabla = new DataTable();
            tabla = objDatos.Listar();
          

        }
        [TestMethod]
        public void CargoTestBuscar()
        {
            String Busqueda = "Chef";
            CargoDatos objDatos = new CargoDatos();
            CargoEntidad objDatosE = new CargoEntidad();
            DataTable tabla = new DataTable();
            tabla = objDatos.Buscar(Busqueda);

        }
        [TestMethod]
        public void CargoTestAgregar()
        {
            CargoDatos objDatos = new CargoDatos();
            CargoEntidad objDatosE = new CargoEntidad();
            objDatosE.nombre="nuevo7";
            objDatosE.sueldo=1000;
            String rpta = objDatos.Insertar(objDatosE);
            Assert.AreEqual(rpta, "OK");
        }
        [TestMethod]
        public void CargoTestActualizar()
        {
            CargoDatos objDatos = new CargoDatos();
            CargoEntidad objDatosE = new CargoEntidad();
            objDatosE.id_cargo = 3;
            objDatosE.nombre = "Nuevo";
            objDatosE.sueldo = 1000;

            String rpta = objDatos.Actualizar(objDatosE);
            Assert.AreEqual(rpta, "No se pudo actualizar el registro.");
        }


    }
}
