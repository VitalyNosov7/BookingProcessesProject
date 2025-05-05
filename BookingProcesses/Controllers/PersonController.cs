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

        public void AddFirstNamePerson()
        {
            CurrentPerson.FirstName = GetStringValue.GetStringValue();
        }


    }
}
