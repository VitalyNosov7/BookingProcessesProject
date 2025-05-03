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
        private Person? _currentPerson = default;
        public Person CurrentPerson
        {
            get { return _currentPerson!; }
            set { _currentPerson = value; }
        }

        private IGetStringValue? _getStringValue = default;

        public void EnterLastNamePerson()
        {
            if (CurrentPerson != null)
            {
                _getStringValue = new EnterStringValue();
                CurrentPerson.LastName = _getStringValue.GetStringValue();
            }
        }


    }
}
