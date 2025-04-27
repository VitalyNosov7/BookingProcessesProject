using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public class BookingDataTests
    {
        private BookingData MakeBookingData()
        {
            return new BookingData();
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void BookingNumber_ByDefault_ReturnsZero()
        {
            BookingData bookingData = MakeBookingData();
            var result = bookingData.BookingNumber;
            Assert.That(result, Is.Zero);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void BookingNumber_NewBookingNumber_ReturnsNotZero()
        {
            BookingData bookingData = MakeBookingData();
            UInt32 newBookingData = 123456;
            var result = bookingData.BookingNumber == newBookingData;
            Assert.That(result,!Is.Zero);
        }
    }
}
