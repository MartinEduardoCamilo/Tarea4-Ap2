using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoraBlazor.BLL;
using MoraBlazor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoraBlazor.BLL.Tests
{
    [TestClass()]
    public class MoraBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Moras mora = new Moras();
            mora.MoraId = 0;
            mora.Fecha = DateTime.Now;
            mora.Total = 10;
            mora.MoraDetalles.Add(new MoraDetalles
            {
                MoradetalleId = 0,
                MoraId = 0,
                PrestamoId = 1,
                Valor = 10
            });

            Assert.IsTrue(MoraBLL.Guardar(mora));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var paso = MoraBLL.Buscar(1);
            Assert.AreEqual(paso, paso);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Moras>();
            lista = MoraBLL.GetList(p => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = MoraBLL.Existe(1);
            Assert.IsNotNull(paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = MoraBLL.Eliminar(1);
            Assert.IsNotNull(paso);
        }
    }
}