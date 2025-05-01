using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public class ResortComplexTests
    {
        private ResortComplex MakeSanatorium()
        {
            return new ResortComplex();
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void SanatoriumName_ByDefaut_ReturnsNull ()
        {
            ResortComplex currentResortComplex = MakeSanatorium();
            var result = currentResortComplex.ResortComplexName;
            Assert.That (result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void Sanatorium_NewSanatoriumName_ResultsNotNull ()
        {
            ResortComplex currentResortComplex =  MakeSanatorium();
            String newResortComplexName = "New Resort Complex Name";
            currentResortComplex.ResortComplexName = newResortComplexName;
            var result = currentResortComplex.ResortComplexName;
            Assert.That(result, !Is.Null);
        }
    }
}
