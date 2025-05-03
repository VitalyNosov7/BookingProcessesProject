using BookingProcesses.Controllers;
using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public  class PersonControllerTests
    {
        private PersonController MakePersonController()
        {
            return new PersonController();
        }

        [Test]
        public void CurrentPersonLastName_ByDefault_ReturnsNull()
        {
            PersonController currentPersonController = MakePersonController();
            var currentPersonLastName  = currentPersonController.CurrentPerson.LastName;
            Assert.That(currentPersonLastName, Is.Null);
        }

        [Test]
        public void EnterLastNamePerson_LastName_ReturnsNotNull()
        {
            PersonController currentPersonController = MakePersonController();
            //currentPersonController.EnterLastNamePerson();
            String fakeEnteredLastName = "FakeEnteredLastName";
            currentPersonController.CurrentPerson.LastName = fakeEnteredLastName;
            var currentPersonLastName = currentPersonController.CurrentPerson.LastName;
            Assert.That(currentPersonLastName, !Is.Null);
        }
    }
}
