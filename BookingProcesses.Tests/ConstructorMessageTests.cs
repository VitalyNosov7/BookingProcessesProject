using BookingProcesses.Data;
using BookingProcesses.Interfaces;
using BookingProcesses.Models;
using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public class ConstructorMessageTests
    {
        private MessageModel MakeConstructorMessage()
        {
            return new MessageModel(null, null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void CurrentBooking_ByDefault_ReturnsNull()
        {
            MessageModel constructorMessage = MakeConstructorMessage();
            var result = constructorMessage.CurrentBooking;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void CurrentBooking_NewCurrentBooking_ReturnsNotNull()
        {
            MessageModel constructorMessage = MakeConstructorMessage();
            IBookingDetails newCurrentBooking = new Booking();
            constructorMessage.CurrentBooking = newCurrentBooking;
            var result = constructorMessage.CurrentBooking;
            Assert.That(result, !Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void CurrentBookingOperation_ByDefault_ReturnsNull()
        {
            MessageModel constructorMessage = MakeConstructorMessage();
            var result = constructorMessage.CurrentBookingOperation;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void CurrentBookingOperation_NewBookingOperation_ReturnsNotNull()
        {
            MessageModel constructorMessage = MakeConstructorMessage();
            BookingOperation newBookingOperation = new BookingOperation(null);
            constructorMessage.CurrentBookingOperation = newBookingOperation;
            var result = constructorMessage.CurrentBookingOperation;
            Assert.That(result, !Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void ConstructoredMessage_ByDefault_ReturnsNull()
        {
            MessageModel constructorMessage = MakeConstructorMessage();
            var result = constructorMessage.ConstructoredMessage;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void ConstructoredMessage_NewMessage_ReturnsNotNull()
        {
            MessageModel currentConstructorMessage = MakeConstructorMessage();
            String newConstructoredMessage = "New Message";
            currentConstructorMessage.ConstructoredMessage = newConstructoredMessage;
            var result = currentConstructorMessage.ConstructoredMessage;
            Assert.That(result, !Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void TemplateMessage_ByDefault_ReturnNull()
        {
            MessageModel currentConstructorMessage = MakeConstructorMessage();
            var result = currentConstructorMessage.CurrentTemplateMessage;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void TemplateMessage_NewTemplateMessage_ReturnsNotNull()
        {
            MessageModel currentConstructorMessage = MakeConstructorMessage();
            TemplateMessage newTemplateMessage = new TemplateMessage();
            currentConstructorMessage.CurrentTemplateMessage = newTemplateMessage;
            var result = currentConstructorMessage.CurrentTemplateMessage;
            Assert.That(result, !Is.Null);
        }
    }
}
