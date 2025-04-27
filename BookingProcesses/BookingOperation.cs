namespace BookingProcesses
{
    /// <summary>
    /// Операция бронирования.
    /// В этом классе хранятся данные и методы определенной операции бронирования.
    /// </summary>
    /*
     Например: формирование счета, формирование заявки, аннуляция брони, коррекция заявки и т.п.
     */
    public class BookingOperation
    {
        public BookingOperation(Booking? booking)
        {
            CurrentBooking = booking!;
        }

        #region СВОЙСТВА
        /// <summary>Название операции бронирования.</summary>
        private String? _operationName = default;
        /// <summary>Название операции бронирования.</summary>
        public String OperationName
        { 
            get { return _operationName!; }
            set { _operationName = value; } 
        }

        /// <summary>Текущая бронь.</summary>
        private Booking? _currentBooking = default;
        /// <summary>Текущая бронь.</summary>
        public Booking CurrentBooking
        {
            get { return _currentBooking!; }
            set { _currentBooking = value; }
        }
        #endregion

    }
}
