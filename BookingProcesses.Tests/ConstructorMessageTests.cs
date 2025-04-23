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

        [Test]
        public void ConstructoredMessage_ByDefault_ReturnsNull()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            var result = constructorMessage.ConstructoredMessage;
           Assert.That(result,Is.Empty);          
        }

        [Test]
        public void ConstructoredMessage_NewMessage_ReturnsNotNull()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            String newValue = "NewValue";
            constructorMessage.ConstructoredMessage = newValue;
            var result = constructorMessage.ConstructoredMessage;
            Assert.That(result, !Is.Null);
        }

        [Test]
        public void TemplateMessage_ByDefault_ReturnNull()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            var result = constructorMessage.TemplateMessage;
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void TemplateMessage_NewTemplate_ReturnsNotNull()
        {
            ConstructorMessage constructorMessage = MakeConstructorMessage();
            String newTemplate = "NewTemplate";
            constructorMessage.TemplateMessage = newTemplate;
            var result = constructorMessage.TemplateMessage;
            Assert.That(result, !Is.Null);
        }
    }
}
