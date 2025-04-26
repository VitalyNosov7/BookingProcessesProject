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

        // TODO: Информация о госте (на которого оформляется бронь) вынести в отдельный класс.

        // TODO: Информация о санатории(название, категория номера, период проживания, расчет и т.п.)
        // вынести в отдельный класс.

    }
}
