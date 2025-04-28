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
            BookingOperation newBookingOperation = new BookingOperation(null);
            constructorMessage.CurrentBookingOperation = newBookingOperation;
            var result = constructorMessage.CurrentBookingOperation;
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
            ConstructorMessage currentConstructorMessage = MakeConstructorMessage();
            String newConstructoredMessage = "New Message";
            currentConstructorMessage.ConstructoredMessage = newConstructoredMessage;
            var result = currentConstructorMessage.ConstructoredMessage;
            Assert.That(result, !Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void TemplateMessage_ByDefault_ReturnNull()
        {
            ConstructorMessage currentConstructorMessage = MakeConstructorMessage();
            var result = currentConstructorMessage.CurrentTemplateMessage;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void TemplateMessage_NewTemplateMessage_ReturnsNotNull()
        {
            ConstructorMessage currentConstructorMessage = MakeConstructorMessage();
            TemplateMessage newTemplateMessage = new TemplateMessage();
            currentConstructorMessage.CurrentTemplateMessage = newTemplateMessage;
            var result = currentConstructorMessage.CurrentTemplateMessage;
            Assert.That(result, !Is.Null);
        }
    }
}
