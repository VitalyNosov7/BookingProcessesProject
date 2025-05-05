using BookingProcesses.Interfaces;
using BookingProcesses.Models;

namespace BookingProcesses.Controllers
{
    /// <summary>
    /// Создание персоны.
    /// В этом классе обрабатываются данные персоны
    /// </summary>
    public class PersonController
    {
        /// <summary>Персона.</summary>
        private Person _currentPerson = new Person();
        /// <summary>Персона.</summary>
        public Person CurrentPerson
        {
            get { return _currentPerson; }
            set { _currentPerson = value; }
        }

        /// <summary>Получить строковое значение.</summary>
        private IGetStringValue? _getStringValue = default;
        /// <summary>Получить строковое значение.</summary>
        public IGetStringValue GetStringValue
        {
            get { return _getStringValue!; }
            set { _getStringValue = value; }
        }

        /// <summary>Добавить фамилию персоны.</summary>
        public void AddLastNamePerson()
        {
            CurrentPerson.LastName = GetStringValue.GetStringValue();
        }

        /// <summary>Добавить имя персоны.</summary>
        public void AddFirstNamePerson()
        {
            CurrentPerson.FirstName = GetStringValue.GetStringValue();
        }

        /// <summary>Добавить отчество персоны.</summary>
        public void AddPatronymicPerson()
        {
            CurrentPerson.Patronymic = GetStringValue.GetStringValue();
        }

        /// <summary>Добавить дату рождения персоны.</summary>
        public void AddBirthdayPerson()
        {
            CurrentPerson.Birthday = Convert.ToDateTime(GetStringValue.GetStringValue());
        }
    }
}
