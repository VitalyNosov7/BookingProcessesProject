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

    }
}
