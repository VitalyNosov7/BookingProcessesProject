using BookingProcesses.Interfaces;

namespace BookingProcesses
{
    /// <summary>
    /// Данные брони.
    /// В этом классе хранятся данные о брони.
    /// </summary>
    public class Booking
    {
        //  TODO: Заменить поле и свойство Sanatorium на обобщенный интерфейс!

        #region СВОЙСТВА
        /// <summary>Номер брони.</summary>
        private UInt32 _bookingNumber = default;
        /// <summary>Номер брони.</summary>
        public UInt32 BookingNumber
        {
            get { return _bookingNumber; }
            set { _bookingNumber = value; }
        }

        /// <summary>Информация о госте(гостях).</summary>
        private List<Guest>? _currentGuests = default;
        /// <summary>Информация о госте(гостях).</summary>
        public List<Guest> CurrentGuests
        {
            get { return _currentGuests!; }
            set { _currentGuests = value; }
        }

        /// <summary>Курортный комплекс.</summary>
        private IResortComplex? _currentResortComplex = default;
        /// <summary>Курортный комплекс.</summary>
        public IResortComplex CurrentResortComplex
        {
            get { return _currentResortComplex!; }
            set { _currentResortComplex = value; }
        }
        #endregion
    }
}
