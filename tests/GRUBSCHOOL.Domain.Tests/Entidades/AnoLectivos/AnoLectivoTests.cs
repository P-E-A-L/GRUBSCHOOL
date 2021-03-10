
using GRUBSCHOOL.Domain.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using Xunit.Sdk;

namespace GRUBSCHOOL.Domain.Tests.Entidades
{
    [TestClass()]
    public class AnoLectivoTests
    {
        private AnoLectivo _anoLectivo;
        private Mock<AnoLectivo> _mock;

        public AnoLectivoTests(AnoLectivo anoLectivo, Mock<AnoLectivo> mock)
        {
            _anoLectivo = anoLectivo;
            _mock = mock;
        }

        [TestMethod]
        public void InserirAnoLectivoValido()
        {
            var anoLectivo = new AnoLectivo(2021, DateTime.Now, DateTime.Now.AddMonths(11));
            Assert.IsFalse(anoLectivo.IsValid);
        }
        
        [TestMethod]
        public void InserirAnoLectivoDataInicioInvalida_Igual()
        {
            var anoLectivo = new AnoLectivo(2021, DateTime.Now, DateTime.Now);
            Assert.IsFalse(anoLectivo.IsValid);
        }

        [TestMethod]
        public void InserirAnoLectivoDataInicioInvalida_Maior()
        {
            var anoLectivo = new AnoLectivo(2021, DateTime.Now.AddMonths(11), DateTime.Now);
            Assert.IsFalse(anoLectivo.IsValid);
        }
    }
}
