using BookingProcesses.Models;
using NUnit.Framework;

namespace BookingProcesses.Tests
{
    [TestFixture]
    public class PersonTests
    {
        private Person MakePerson()
        { 
            return new Person(); 
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void LastName_ByDefault_ReturnsEmpty()
        {
            Person currentPerson = MakePerson();
            var result = currentPerson.LastName;
            Assert.That(result, Is.Empty);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void LastName_NewLastName_ReturnsNotEmpty()
        {
            Person currentPerson = MakePerson();
            String newLastName = "New Last Name";
            currentPerson.LastName = newLastName;
            var result = currentPerson.LastName;
            Assert.That(result, !Is.Empty);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void FirstName_ByDefault_ReturnsNull()
        {
            Person currentPerson = MakePerson();
            var result = currentPerson.FirstName;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void FirstName_NewFirstName_ReturnsNotNull()
        {  
            Person currentPerson = MakePerson();
            String newFirstName = "New First Name";
            currentPerson.FirstName = newFirstName;
            var result = currentPerson.FirstName;
            Assert.That(result, !Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void Patronymic_ByDefault_ReturntNull()
        {
            Person currentPerson = MakePerson();
            var result = currentPerson.Patronymic;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void Patronymic_NewPatronymic_ReturnsNotNull()
        {
            Person currentPerson = MakePerson();
            String newPatronymic = "New Patronymic";
            currentPerson.Patronymic = newPatronymic;
            var result = currentPerson.Patronymic;
            Assert.That(result, !Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void Birthday_ByDefault_ReturnTrue()
        {
            Person currentPerson = MakePerson();
            DateTime defaultBirthday = new DateTime(0001, 01, 01, 0, 00, 00);
            var currentBirthday = currentPerson.Birthday;
            var result = defaultBirthday == currentBirthday;
            Assert.That(result, Is.True);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void Birthday_NewBirthday_ReturnsFalse()
        {
            Person currentPerson = MakePerson();
            DateTime defaultBirthday = new DateTime(0001, 01, 01, 0, 00, 00);
            var currentBirthday = DateTime.Now;
            var result = defaultBirthday == currentBirthday;
            Assert.That(result, Is.False);
        }
    }
}
