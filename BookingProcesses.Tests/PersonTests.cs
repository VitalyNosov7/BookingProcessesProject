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
        public void LastName_ByDefault_ReturnsNull()
        {
            Person person = MakePerson();
            var result = person.LastName;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void LastName_NewLastName_ReturnsNotNull()
        {
            Person person = MakePerson();
            String newLastName = "New Last Name";
            var result = person.LastName == newLastName;
            Assert.That(result, !Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void FirstName_ByDefault_ReturnsNull()
        {
            Person person = MakePerson();
            var result = person.FirstName;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void FirstName_NewFirstName_ReturnsNotNull()
        {  
            Person person = MakePerson();
            String newFirstName = "New First Name";
            var result = person.FirstName == newFirstName;
            Assert.That(result, !Is.Null);
        }

        /// <summary>Тест значения поля по умолчанию(через свойство)</summary>
        [Test]
        public void Patronymic_ByDefault_ReturntNull()
        {
            Person person = MakePerson();
            var result = person.Patronymic;
            Assert.That(result, Is.Null);
        }

        /// <summary>Тест записи-чтения поля(через свойство)</summary>
        [Test]
        public void Patronymic_NewPatronymic_ReturnsNotNull()
        {
            Person person = MakePerson();
            String newPatronymic = "New Patronymic";
            var result = person.Patronymic == newPatronymic;
            Assert.That(result, !Is.Null);
        }
    }
}
