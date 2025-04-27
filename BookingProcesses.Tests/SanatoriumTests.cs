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
        public void SanatoriumName_ByDefaut_ReturnsNull ()
        {
            Sanatorium sanatorium = MakeSanatorium();
            var result = sanatorium.SanatoriumName;
            Assert.That (result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void Sanatorium_NewSanatoriumName_ResultsNotNull ()
        {
            Sanatorium sanatorium =  MakeSanatorium();
            String newSanatoriumName = "New Sanatorium Name";
            var result = sanatorium.SanatoriumName == newSanatoriumName;
            Assert.That(result, !Is.Null);
        }
    }
}
