using BookingProcesses.Data;
using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public class BookingOperationTests
    {
        private BookingOperation MakeBookingOperation()
        {
            return new BookingOperation(null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void OperationName_ByDefault_ReturnsNull()
        {
            BookingOperation currentBookingOperation = MakeBookingOperation();
            var result = currentBookingOperation.OperationName;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void OperationName_NewOperationName_ReturnsNotNull()
        {
            BookingOperation currentBookingOperation = MakeBookingOperation();
            String newOperationName = "New Operation Name";
            currentBookingOperation.OperationName = newOperationName;
            var result = currentBookingOperation.OperationName;
            Assert.That(result, !Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void CurrentBooking_ByDefault_ReturnsNull()
        {
            BookingOperation currentBookingOperation = MakeBookingOperation();
            var result = currentBookingOperation.CurrentBooking;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void CurrentBooking_NewCurrentBooking_ReturnsNotNull()
        {
            BookingOperation currentBookingOperation = MakeBookingOperation();
            Booking newCurrentBooking = new Booking();
            currentBookingOperation.CurrentBooking = newCurrentBooking;
            var result = currentBookingOperation.CurrentBooking;
            Assert.That(result, !Is.Null);
        }
    }
}
