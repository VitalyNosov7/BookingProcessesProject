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
    }
}
