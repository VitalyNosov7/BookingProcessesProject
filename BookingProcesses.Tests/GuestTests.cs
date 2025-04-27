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
            Guest guest = MakeGuest();
            var result = guest.CurrentPerson;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void CurrentGuest_NewCurrentGuest()
        { 
            Guest guest = MakeGuest();
            Person newCurrentPerson = new Person();
            var result = guest.CurrentPerson == newCurrentPerson;
            Assert.That(result, !Is.Null);
        }

    }
}
