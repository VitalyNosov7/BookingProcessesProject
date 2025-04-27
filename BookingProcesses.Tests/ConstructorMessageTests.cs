using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public class ConstructorMessageTests
    {
        private ConstructorMessage MakeConstructorMessage()
        {
            return new ConstructorMessage(null, null);
        }
        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void CurrentBookingOperation_ByDefault_ReturnsNull()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            var result = constructorMessage.CurrentBookingOperation;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void CurrentBookingOperation_NewBookingOperation_ReturnsNotNull()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            BookingOperation currentBookingOperation = new BookingOperation();
            var result = constructorMessage.CurrentBookingOperation == currentBookingOperation;
            Assert.That(result, !Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void ConstructoredMessage_ByDefault_ReturnsNull()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            var result = constructorMessage.ConstructoredMessage;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void ConstructoredMessage_NewMessage_ReturnsNotNull()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            String newConstructoredMessage = "New Message";
            var result = constructorMessage.ConstructoredMessage == newConstructoredMessage;
            Assert.That(result, !Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void TemplateMessage_ByDefault_ReturnNull()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            var result = constructorMessage.CurrentTemplateMessage;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void TemplateMessage_NewTemplate_ReturnsNotNull()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            TemplateMessage newTemplateMessage = new TemplateMessage();
            var result = constructorMessage.CurrentTemplateMessage == newTemplateMessage;
            Assert.That(result, !Is.Null);
        }
    }
}
