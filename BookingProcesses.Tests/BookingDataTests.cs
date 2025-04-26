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

        [Test]
        public void BookingNumber_ByDefault_ReturnsZero()
        {
            BookingData bookingData = MakeBookingData();
            var result = bookingData.BookingNumber;
            Assert.That(result, Is.Zero);
        }
    }
}
