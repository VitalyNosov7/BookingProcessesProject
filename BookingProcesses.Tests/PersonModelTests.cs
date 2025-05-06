using BookingProcesses.Models;
using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public  class PersonModelTests
    {
        private PersonModel MakePersonController()
        {
            return new PersonModel();
        }

        [Test]
        public void CurrentPersonLastName_ByDefault_ReturnsEmpty()
        {
            PersonModel currentPersonController = MakePersonController();
            var currentPersonLastName  = currentPersonController.CurrentPerson.LastName;
            Assert.That(currentPersonLastName, Is.Empty);
        }

        [Test]
        public void AddLastNamePerson_AddLastName_ReturnsNotEmpty()
        {
            PersonModel currentPersonController = MakePersonController();
            //currentPersonController.EnterLastNamePerson();
            String fakeEnteredLastName = "FakeEnteredLastName";
            currentPersonController.CurrentPerson.LastName = fakeEnteredLastName;
            var currentPersonLastName = currentPersonController.CurrentPerson.LastName;
            Assert.That(currentPersonLastName, !Is.Empty);
        }

        [Test]
        public void CurrentFirstName_ByDefault_ReturnsEmpty()
        {
            PersonModel currentPersonController = MakePersonController();
            var currentFirstName = currentPersonController.CurrentPerson.FirstName;
            Assert.That(currentFirstName, Is.Empty);
        }

        [Test]
        public void AddFirtstNamePerson_AddFirstName_ReternsNotEmpty()
        {
            PersonModel currentPersonController = MakePersonController();
            String fakeEnteredFirstName = "FakeEnteredFirstNam";
            currentPersonController.CurrentPerson.FirstName = fakeEnteredFirstName;
            var currentPersonFitstName = currentPersonController.CurrentPerson.FirstName;
            Assert.That(currentPersonFitstName, !Is.Empty);
        }

        [Test]
        public void CurrentPatronymicPerson_ByDefault_ReturnsEmpty()
        {
            PersonModel currentPersonController = MakePersonController();
            var currentPatronymic = currentPersonController.CurrentPerson.Patronymic;
            Assert.That(currentPatronymic, Is.Empty);
        }

        [Test]
        public void AddPatronymicPerson_AddPatronymic_ReturnsNotEmpty()
        {
            PersonModel currentPersonController = MakePersonController();
            String fakeEnteredPatronymic = "FakeEnteredPatronymic";
            currentPersonController.CurrentPerson.Patronymic = fakeEnteredPatronymic;
            var currentPersonPatronymic = currentPersonController.CurrentPerson.Patronymic;
            Assert.That(currentPersonPatronymic, !Is.Empty);
        }

        [Test]
        public void CurrentBirthdayPerson_ByDefault_ReturnsTrue()
        {
            PersonModel currentPersonController = MakePersonController();
            DateTime currentBirthdayByDefault = default;
            var result = currentPersonController.CurrentPerson.Birthday == currentBirthdayByDefault;
            Assert.That(result, Is.True);
        }

        [Test]
        public void AddBirthdayPerson_AddBirthday_ReturnsFalse()
        {
            PersonModel currentPersonController = MakePersonController();
            DateTime currentBirthdayByDefault = default;
            DateTime fakeEnteredBirthday = new DateTime(1945, 05, 09);
            currentPersonController.CurrentPerson.Birthday = fakeEnteredBirthday;
            var result = currentBirthdayByDefault == currentPersonController.CurrentPerson.Birthday;
            Assert.That(result, Is.False);
        }
    }
}
