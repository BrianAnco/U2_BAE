using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using BAE_Restaurante.Negocios;
using BAE_Restaurante.Entidad;
using BAE_Restaurante.Datos;
namespace RestaurantTestd
{
    [TestClass]
    public class Caja
    {
        [TestMethod]
        public void CajaTestInsertar()
        {
            CajaDatos objDatos = new CajaDatos();
            CajaEntidad objDatosE = new CajaEntidad();
            objDatosE.fecha = DateTime.Now.Date;
            objDatosE.reserva = 1;
            objDatosE.ingreso = 0;
            objDatosE.egreso = 0;
            objDatosE.comentario = "bien";
            String rpta = objDatos.Insertar(objDatosE);
            Assert.AreEqual(rpta, "OK");

        }
        [TestMethod]
        public void CajaTestEditar()
        {
            CajaDatos objDatos = new CajaDatos();
            CajaEntidad objDatosE = new CajaEntidad();
            objDatosE.id_caja = 5;
            objDatosE.fecha = DateTime.Now.Date;
            objDatosE.reserva = 1;
            objDatosE.ingreso = 10;
            objDatosE.egreso = 10;
            objDatosE.comentario = "bien";
            String rpta = objDatos.Actualizar(objDatosE);
            Assert.AreEqual(rpta, "OK");
        }
        [TestMethod]
        public void CajaTestEliminar()
        {
            CajaDatos objDatos = new CajaDatos();
            CajaEntidad objDatosE = new CajaEntidad();
            int id_caja = 13;
            String rpta = objDatos.Eliminar(id_caja);
            Assert.AreEqual(rpta, "OK");
        }
        [TestMethod]
        public void CajaTestActualizar2()
        {
            CajaDatos objDatos = new CajaDatos();
            CajaEntidad objDatosE = new CajaEntidad();
            objDatosE.fecha = DateTime.Now.Date;
            objDatosE.ingreso = 10;
            String rpta = objDatos.Actualizar2(objDatosE);
            Assert.AreEqual(rpta, "No se pudo actualizar el registro.");
        }
        public void CajaTestActualizar3()
        {
            CajaDatos objDatos = new CajaDatos();
            CajaEntidad objDatosE = new CajaEntidad();
            objDatosE.fecha = DateTime.Now.Date;
            objDatosE.egreso = 10;
            String rpta = objDatos.Actualizar3(objDatosE);
            Assert.AreEqual(rpta, "No se pudo actualizar el registro.");
        }
    }
}
