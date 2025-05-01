using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public class BookingTests
    {
        private Booking MakeBookingData()
        {
            return new Booking();
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void BookingNumber_ByDefault_ReturnsZero()
        {
            Booking currentBooking = MakeBookingData();
            var result = currentBooking.BookingNumber;
            Assert.That(result, Is.Zero);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void BookingNumber_NewBookingNumber_ReturnsNotZero()
        {
            Booking currentBooking = MakeBookingData();
            UInt32 newBookingNumber = 123456;
            currentBooking.BookingNumber = newBookingNumber;
            var result = currentBooking.BookingNumber;
            Assert.That(result, !Is.Zero);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void CurrentGuests_ByDefault_ReturnsNull()
        {
            Booking currentBooking = MakeBookingData();
            var result = currentBooking.CurrentGuests;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void CurretnGuests_NewListCurrentGuests_ReturnsNotNull()
        {
            Booking currentBooking = MakeBookingData();
            var currentGuestsList = new List<Guest>()
            {
                new Guest(),new Guest(), new Guest()
            };
            currentBooking.CurrentGuests = currentGuestsList;
            var result = currentBooking.CurrentGuests;
            Assert.That(result, !Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void CurrentResortComplex_ByDefault_ReturnsNull()
        {
            Booking currentBooking = MakeBookingData();
            var result = currentBooking.CurrentResortComplex;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void CurrentResortComplex_NewCurrentSanatorium_ReturnsNotNull()
        {
            Booking currentBooking = MakeBookingData();
            ResortComplex newCurrentResortComplex = new ResortComplex();
            currentBooking.CurrentResortComplex = newCurrentResortComplex;
            var result = currentBooking.CurrentResortComplex;
            Assert.That(result, !Is.Null);
        }
    }
}
