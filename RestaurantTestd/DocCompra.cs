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
    public class DocCompra
    {
        [TestMethod]
        public void DocCompra_Insertar()
        {
            Doc_compraDatos objDoc = new Doc_compraDatos();
            Doc_compraEntidad objDocE = new Doc_compraEntidad();
            objDocE.tipo_doc_compra = "PRUEBA2";
            objDocE.num_doc_compra = 12445;
            objDocE.venta_total = 1;
            objDocE.fecha = DateTime.Now.Date;
            objDocE.comentario = "buena venta";
            String rpta = objDoc.Insertar(objDocE);
            Assert.AreEqual(rpta, "OK");
        }
        [TestMethod]
        public void DocCompra_Editar()
        {
            Doc_compraDatos objDoc = new Doc_compraDatos();
            Doc_compraEntidad objDocE = new Doc_compraEntidad();
            objDocE.id_doc_compra = 3;
            objDocE.tipo_doc_compra = "DNII";
            objDocE.num_doc_compra = 1;
            objDocE.venta_total = 1;
            objDocE.fecha = DateTime.Now.Date;
            objDocE.comentario = "generado";
            String rpta = objDoc.Actualizar(objDocE);
            Assert.AreEqual(rpta, "OK");
        }
        [TestMethod]
        public void DocCompra_eliminar()
        {
            Doc_compraDatos objDoc = new Doc_compraDatos();
            Doc_compraEntidad objDocE = new Doc_compraEntidad();
            int id_doc_compra = 8;
            String rpta = objDoc.Eliminar(id_doc_compra);
            Assert.AreEqual(rpta, "OK");
        }
        [TestMethod]
        public void DocCompra_Listar()
        {
            Doc_compraDatos objDoc = new Doc_compraDatos();
            Doc_compraEntidad objDocE = new Doc_compraEntidad();
            DataTable tabla = new DataTable();
            tabla = objDoc.Listar();
        }
    }
}
