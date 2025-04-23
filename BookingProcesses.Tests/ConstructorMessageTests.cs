using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public class ConstructorMessageTests
    {
        [Test]
        public void ConstructoredMessage_ByDefault_ReturnsNull()
        {
            ConstructorMessage constructorMessage = new BookingProcesses.ConstructorMessage();
            var result = constructorMessage.ConstructoredMessage;
           Assert.That(result,Is.Empty);          
        }
        [Test]
        public void ConstructoredMessage_NewValue_ReturnsNotNull()
        {
            ConstructorMessage constructorMessage = new BookingProcesses.ConstructorMessage();
            String newValue = "NewValue";
            constructorMessage.ConstructoredMessage = newValue;
            var result = constructorMessage.ConstructoredMessage;
            Assert.That(result, !Is.Null);
        }
    }
}
