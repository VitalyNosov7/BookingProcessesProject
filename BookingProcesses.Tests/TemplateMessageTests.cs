using BookingProcesses.Models;
using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public class TemplateMessageTests
    {
        private TemplateMessage MakeTemplateMessage()
        {
            return new TemplateMessage();
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void TemplateMessageName_ByDefault_ReturnsNull()
        {
            TemplateMessage currentTemplateMessage = MakeTemplateMessage();
            var result = currentTemplateMessage.TemplateMessageName;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void TemplateMessageName_NewTemplateMessageName_ReturnsNotNull()
        {
            TemplateMessage currentTemplateMessage = MakeTemplateMessage();
            String newTemplateMessageName = "New Template Message Name";
            currentTemplateMessage.TemplateMessageName = newTemplateMessageName;
            var result = currentTemplateMessage.TemplateMessageName;
            Assert.That(result,!Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void CurrentTemplateMessage_ByDefault_ReturnsNull()
        {
            TemplateMessage currentTemplateMessage = MakeTemplateMessage();
            var result = currentTemplateMessage.CurrentTemplateMessage;
            Assert.That(result, Is.Null);
        }


        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void CurrentTemplateMessage_NewTemplateMessage_ReturnsNotNull()
        {
            TemplateMessage currentTemplateMessage = MakeTemplateMessage();
            String newCurrentTemplateMessage = "New Current Template Message";
            currentTemplateMessage.CurrentTemplateMessage = newCurrentTemplateMessage;
            var result = currentTemplateMessage.CurrentTemplateMessage;
            Assert.That(result, !Is.Null);
        }
    }
}
