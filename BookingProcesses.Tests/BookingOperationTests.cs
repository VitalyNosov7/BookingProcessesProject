using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public class BookingOperationTests
    {
        private BookingOperation MakeBookingOperation()
        {
            return new BookingOperation();
        }

        /// <summary>Тест пустого значения поля(через свойство)</summary>
        [Test]
        public void OperationName_ByDefault_ReturnsEmpty()
        {
            BookingOperation bookingsOperations = MakeBookingOperation();
            var result = bookingsOperations.OperationName;
            Assert.That(result, Is.Empty);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void OperationName_NewOperationNameReturnsNotEmpty()
        {
            BookingOperation bookingsOperations = MakeBookingOperation();
            String newOperationName = "New Operation Name";
            bookingsOperations.OperationName = newOperationName;
            var result = bookingsOperations.OperationName;
            Assert.That(result, !Is.Empty);
        }
    }
}
