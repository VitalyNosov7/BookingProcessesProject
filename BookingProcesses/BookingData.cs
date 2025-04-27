namespace BookingProcesses
{
    /// <summary>
    /// Данные брони.
    /// В этом классе хранятся данные о брони.
    /// </summary>
    public class BookingData
    {
        /// <summary>Номер брони.</summary>
        private UInt32 _bookingNumber = default;
        /// <summary>Номер брони.</summary>
        public UInt32 BookingNumber
        {
            get { return _bookingNumber; }
            set { _bookingNumber = value; }
        }

        /// <summary>Информация о госте(гостях).</summary>
        private Guest[]?  _currentGuests = default;
        /// <summary>Информация о госте(гостях).</summary>
        public Guest[] CurrentGuests
        {
            get { return _currentGuests!; }
            set { _currentGuests = value; }
        }
        

        // TODO: Информация о санатории(название, категория номера, период проживания, расчет и т.п.)
        // вынести в отдельный класс.

    }
}
