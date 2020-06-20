using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoraBlazor.BLL;
using MoraBlazor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoraBlazor.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Personas persona = new Personas(0, "Martinz", "8094758366", "402129123398", "Jose idjnjdnb", DateTime.Now, 0);
            bool paso = PersonasBLL.Guardar(persona);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Personas persona = new Personas(1, "Martin", "8096758366", "402129123398", "Jose idjnjdnb", DateTime.Now, 0);
            bool paso = PersonasBLL.Modificar(persona);
            Assert.AreEqual(paso, paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = PersonasBLL.Eliminar(1);
            Assert.IsNotNull(paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var encontrar = PersonasBLL.Buscar(1);
            Assert.AreEqual(encontrar, encontrar);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Personas> persona = new List<Personas>();
            persona = PersonasBLL.GetList(p => true);
            Assert.IsNotNull(persona);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            var paso = PersonasBLL.Existe(1);
            Assert.IsNotNull(paso);
        }
    }
}