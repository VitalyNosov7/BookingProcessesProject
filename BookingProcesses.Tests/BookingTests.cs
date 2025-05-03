using BookingProcesses.Interfaces;
using BookingProcesses.Models;
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
            var result = currentBooking.CurrentGuest;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void CurretnGuests_NewListCurrentGuests_ReturnsNotNull()
        {
            Booking currentBooking = MakeBookingData();
            var currentGuest = new Guest();
            currentBooking.CurrentGuest = currentGuest;
            var result = currentBooking.CurrentGuest;
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
            IResortComplex newCurrentResortComplex = new Sanatorium();
            currentBooking.CurrentResortComplex = newCurrentResortComplex;
            var result = currentBooking.CurrentResortComplex;
            Assert.That(result, !Is.Null);
        }

        [Test]
        public void TreatmentIncluded_ByDefalt_ReturnsFalse()
        {
            Booking currentBooking = MakeBookingData();
            var result = currentBooking.TreatmentIncluded;
            Assert.That(result, Is.False);
        }

        [Test]
        public void TreatmentIncluded_SetValueIsTrue_ReturnsTrue()
        {
            Booking currentBooking = MakeBookingData();
            Boolean valueTrue = true;
            currentBooking.TreatmentIncluded = valueTrue;
            var result = currentBooking.TreatmentIncluded;
            Assert.That(result, Is.True);
        }
    }
}
