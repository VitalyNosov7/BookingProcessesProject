namespace BookingProcesses
{
    /// <summary>
    /// Данные брони.
    /// В этом классе хранятся данные о брони.
    /// </summary>
    public class Booking
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
        private List<Guest>? _currentGuests = default;
        /// <summary>Информация о госте(гостях).</summary>
        public List<Guest> CurrentGuests
        {
            get { return _currentGuests!; }
            set { _currentGuests = value; }
        }

        /// <summary>Информация о санатории.</summary>
        private Sanatorium? _currentSanatorium = default;
        /// <summary>Информация о санатории.</summary>
        public Sanatorium CurrentSanatorium
        {
            get { return _currentSanatorium!; }
            set { _currentSanatorium = value; }
        }
    }
}
