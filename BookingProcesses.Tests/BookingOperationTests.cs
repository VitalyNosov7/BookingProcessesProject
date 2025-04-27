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

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void OperationName_ByDefault_ReturnsNull()
        {
            BookingOperation bookingsOperations = MakeBookingOperation();
            var result = bookingsOperations.OperationName;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void OperationName_NewOperationName_ReturnsNotNull()
        {
            BookingOperation bookingsOperations = MakeBookingOperation();
            String newOperationName = "New Operation Name";
            var result = bookingsOperations.OperationName == newOperationName;
            Assert.That(result, !Is.Null);
        }
    }
}
