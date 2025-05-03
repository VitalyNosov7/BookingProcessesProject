using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public class GuestTests
    {
        private Guest MakeGuest()
        {
            return new Guest();
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]  
        public void CurrentGuest_ByDefault_ReturnsNull()
        {
            Guest currentGuest = MakeGuest();
            var result = currentGuest.CurrentPerson;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void CurrentGuest_NewCurrentGuest()
        { 
            Guest currentGuest = MakeGuest();
            Person newCurrentPerson = new Person();
            currentGuest.CurrentPerson = newCurrentPerson;
            var result = currentGuest.CurrentPerson;
            Assert.That(result, !Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void StartPeriodResidence_ByDefault_ReturnsTrue ()
        {
            Guest currentGuest = MakeGuest();
            DateTime defaultDateTime = new DateTime(0001,01,01,0,00,00);
            var currentStartPeriodResidence = currentGuest.StartPeriodResidence;
            var result = defaultDateTime == currentStartPeriodResidence;
            Assert.That(result, Is.True);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void StartPeriodResidence_NewDate_ReturnsFalse()
        {
            Guest currentGuest = MakeGuest();
            DateTime defaultDateTime = new DateTime(0001, 01, 01, 0, 00, 00);
            var currentStartPeriodResidence = DateTime.Now;
            var result = defaultDateTime == currentStartPeriodResidence;
            Assert.That(result, Is.False);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void EndPeriodResidence_ByDefault_ReturnsTrue()
        {
            Guest currentGuest = MakeGuest();
            DateTime defaultDateTime = new DateTime(0001, 01, 01, 0, 00, 00);
            var currentEndPeriodResidence = currentGuest.StartPeriodResidence;
            var result = defaultDateTime == currentEndPeriodResidence;
            Assert.That(result, Is.True);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void EndPeriodResidence_NewDate_ReturnsFalse()
        {
            Guest currentGuest = MakeGuest();
            DateTime defaultDateTime = new DateTime(0001, 01, 01, 0, 00, 00);
            var currentEndPeriodResidence = DateTime.Now;
            var result = defaultDateTime == currentEndPeriodResidence;
            Assert.That(result, Is.False);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void ChiefGuest_ByDefault_ReturnsFalse()
        {
            Guest currentGuest = MakeGuest();
            var result = currentGuest.ChiefGuest;
            Assert.That(result, Is.False);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void ChiefGuest_SetValueIsTrue_ReturnsTrue()
        {
            Guest currentGuest = MakeGuest();
            Boolean valueTrue = true;
            currentGuest.ChiefGuest = valueTrue;
            var result = currentGuest.ChiefGuest;
            Assert.That(result, Is.True);
        }

    }
}
