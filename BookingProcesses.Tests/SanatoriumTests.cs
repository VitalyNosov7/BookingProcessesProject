using BookingProcesses.Interfaces;
using BookingProcesses.Models;
using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public class SanatoriumTests
    {
        private Sanatorium MakeSanatorium()
        {
            return new Sanatorium();
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void Sanatorium_ByDefault_ReturnsNull()
        {
            IResortComplex currentSanatorium = MakeSanatorium();
            var result = currentSanatorium.ResortComplexName;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void Sanatorium_NewSanatoriumName_ReturnsNotNull()
        {
            IResortComplex currentSanatorium = MakeSanatorium();
            String newSanatoriumName = "NewSanatoriumName";
            currentSanatorium.ResortComplexName = newSanatoriumName;
            var result = currentSanatorium.ResortComplexName;
            Assert.That(result, !Is.Null);
        }
    }
}
