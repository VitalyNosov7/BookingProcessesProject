using BookingProcesses.Interfaces;

namespace BookingProcesses.Data
{
    /// <summary>
    /// Данные брони.
    /// В этом классе хранятся данные о брони.
    /// </summary>
    public class Booking : IBookingDetails
    {
        #region СВОЙСТВА
        /// <summary>Номер брони.</summary>
        private uint _bookingNumber = default;
        /// <summary>Номер брони.</summary>
        public uint BookingNumber
        {
            get { return _bookingNumber; }
            set { _bookingNumber = value; }
        }

        /// <summary>Информация о госте(гостях).</summary>
        private List<Guest>? _currentListGuest = default;
        /// <summary>Информация о госте(гостях).</summary>
        public List<Guest> CurrentListGuest
        {
            get { return _currentListGuest!; }
            set { _currentListGuest = value; }
        }

        /// <summary>Курортный комплекс.</summary>
        private IResortComplex? _currentResortComplex = default;
        /// <summary>Курортный комплекс.</summary>
        public IResortComplex CurrentResortComplex
        {
            get { return _currentResortComplex!; }
            set { _currentResortComplex = value; }
        }

        /// <summary>Лечение включено в стоимость.</summary>
        private bool _treatmentIncluded = default;
        /// <summary>Лечение включено в стоимость.</summary>
        public bool TreatmentIncluded
        {
            get { return _treatmentIncluded; }
            set { _treatmentIncluded = value; }
        }
        #endregion
    }
}
