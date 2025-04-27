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
            TemplateMessage templateMessage = MakeTemplateMessage();
            var result = templateMessage.TemplateMessageName;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void TemplateMessageName_NewTemplateMessageName_ReturnsNotNull()
        {
            TemplateMessage templateMessage = MakeTemplateMessage();
            String newTemplateMessageName = "New Template Message Name";
            var result = templateMessage.TemplateMessageName == newTemplateMessageName;
            Assert.That(result,!Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void CurrentTemplateMessage_ByDefault_ReturnsNull()
        {
            TemplateMessage templateMessage = MakeTemplateMessage();
            var result = templateMessage.CurrentTemplateMessage;
            Assert.That(result, Is.Null);
        }


        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void CurrentTemplateMessage_NewTemplateMessage_ReturnsNotNull()
        {
            TemplateMessage templateMessage = MakeTemplateMessage();
            String newCurrentTemplateMessage = "New Current Template Message";
            var result = templateMessage.CurrentTemplateMessage == newCurrentTemplateMessage;
            Assert.That(result, !Is.Null);
        }
    }
}
