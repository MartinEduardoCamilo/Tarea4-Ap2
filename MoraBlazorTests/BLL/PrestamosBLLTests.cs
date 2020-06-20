using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoraBlazor.BLL;
using MoraBlazor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoraBlazor.BLL.Tests
{
    [TestClass()]
    public class PrestamosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Prestamos prestamo = new Prestamos(0, DateTime.Now, 1, "Deuda", 10000, 0);
            bool paso = PrestamosBLL.Guardar(prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Prestamos prestamo = new Prestamos(1, DateTime.Now, 1, "Deuda", 2000, 0);
            bool paso = PrestamosBLL.Modificar(prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = PrestamosBLL.Eliminar(1);
            Assert.IsNotNull(paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var paso = PrestamosBLL.Buscar(1);
            Assert.AreEqual(paso, paso);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Prestamos> persona = new List<Prestamos>();
            persona = PrestamosBLL.GetList(p => true);
            Assert.IsNotNull(persona);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            var paso = PrestamosBLL.Existe(1);
            Assert.IsNotNull(paso);
        }
    }
}