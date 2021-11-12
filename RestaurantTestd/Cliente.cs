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
    public class Cliente
    {
        [TestMethod]
        public void ClienteTestListar()
        {
            ClienteDatos objDatos = new ClienteDatos();
            ClienteEntidad objDatosE = new ClienteEntidad();
            DataTable tabla = new DataTable();
            tabla = objDatos.Listar();
        }
        [TestMethod]
        public void ClienteTestBuscar()
        {
            String Busqueda = "71245612";
            ClienteDatos objDatos = new ClienteDatos();
            ClienteEntidad objDatosE = new ClienteEntidad();
            DataTable tabla = new DataTable();
            tabla = objDatos.Buscar(Busqueda);

        }
        [TestMethod]
        public void ClienteTestAgregar()
        {
            ClienteDatos objDatos = new ClienteDatos();
            ClienteEntidad objDatosE = new ClienteEntidad();
            objDatosE.apellidos = "MAMANI";
            objDatosE.nombres = "MANUEL";
            objDatosE.celular = "922952528";
            objDatosE.direccion = "av";
            objDatosE.num_documento = "38756";
            objDatosE.tipo_documento = "DNI";
            String rpta = objDatos.Insertar(objDatosE);
            Assert.AreEqual(rpta, "OK");
        }
        [TestMethod]
        public void ClienteTestActualizar()
        {
            ClienteDatos objDatos = new ClienteDatos();
            ClienteEntidad objDatosE = new ClienteEntidad();
            objDatosE.id_cliente = 2;
            objDatosE.apellidos = "GRADOS";
            objDatosE.nombres = "RODOLFO";
            objDatosE.celular = "922952528";
            objDatosE.direccion = "av";
            objDatosE.num_documento = "1234567";
            objDatosE.tipo_documento = "DNI";

            String rpta = objDatos.Actualizar(objDatosE);
            Assert.AreEqual(rpta, "OK");
        }
        [TestMethod]
        public void ClienteTestEliminar()
        {
            ClienteDatos objDatos = new ClienteDatos();
            ClienteEntidad objDatosE = new ClienteEntidad();
            int id_cliente = 2020;
            String rpta = objDatos.Eliminar(id_cliente);
            Assert.AreEqual(rpta, "OK");
        }
    }
}
