using Microsoft.VisualStudio.TestTools.UnitTesting;
using BAE_Restaurante.Negocios;
using BAE_Restaurante.Entidad;
using BAE_Restaurante.Datos;
using System;
namespace RestaurantTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void CajaTestInsertar()
        {
            CajaDatos objDatos = new CajaDatos();
            CajaEntidad objDatosE = new CajaEntidad();
            objDatosE.fecha= DateTime.Now.Date;
            objDatosE.reserva = 1;
            objDatosE.ingreso = 0;
            objDatosE.egreso = 0;
            objDatosE.comentario = "bien";
            String rpta = objDatos.Insertar(objDatosE);
            Assert.AreEqual(rpta, "OK se inserto en el registro");
  
        }
        public void CajaTestActualizar()
        {
            CajaDatos objDatos = new CajaDatos();
            CajaEntidad objDatosE = new CajaEntidad();
             objDatosE.id_caja;
             objDatosE.fecha;
            objDatosE.reserva;
            objDatosE.ingreso;
            objDatosE.egreso;
            objDatosE.comentario;
        }
    }
}
