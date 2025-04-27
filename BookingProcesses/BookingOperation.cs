namespace BookingProcesses
{
    /// <summary>
    /// Операция бронирования.
    /// В этом классе хранятся данные определенной операции бронирования.
    /// </summary>
    /*
     Например: формирование счета, формирование заявки, аннуляция брони, коррекция заявки и т.п.
     */
    public class BookingOperation
    {
        /// <summary>Название операции бронирования.</summary>
        private String? _operationName = default;
        /// <summary>Название операции бронирования.</summary>
        public String OperationName
        { 
            get { return _operationName!; }
            set { _operationName = value; } 
        }
    }
}
