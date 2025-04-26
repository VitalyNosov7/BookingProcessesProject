using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public class ConstructorMessageTests
    {
        private ConstructorMessage MakeConstructorMessage()
        {
            return new ConstructorMessage();
        }
        /// <summary>Тест пустого значения поля(через свойство)</summary>
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

        /// <summary>Тест пустого значения поля(через свойство)</summary>
        [Test]
        public void ConstructoredMessage_ByDefault_ReturnsEmpty()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            var result = constructorMessage.ConstructoredMessage;
            Assert.That(result, Is.Empty);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void ConstructoredMessage_NewMessage_ReturnsNotEmpty()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            String newMessage = "New Message";
            constructorMessage.ConstructoredMessage = newMessage;
            var result = constructorMessage.ConstructoredMessage;
            Assert.That(result, !Is.Empty);
        }

        /// <summary>Тест пустого значения поля(через свойство)</summary>
        [Test]
        public void TemplateMessage_ByDefault_ReturnEmpty()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            var result = constructorMessage.TemplateMessage;
            Assert.That(result, Is.Empty);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void TemplateMessage_NewTemplate_ReturnsNotEmpty()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            String newTemplate = "New Template";
            constructorMessage.TemplateMessage = newTemplate;
            var result = constructorMessage.TemplateMessage;
            Assert.That(result, !Is.Empty);
        }
    }
}
