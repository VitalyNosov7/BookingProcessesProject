namespace BookingProcesses
{
    /// <summary>
    /// Операция, которая учавствуют в бронировании.
    /// В этом классе хранятся данные определенной операции бронирования.
    /// </summary>
    public class BookingOperation
    {
        /// <summary>Название операции бронирования.</summary>
        private String _operationName = String.Empty;
        /// <summary>Название операции бронирования.</summary>
        public String OperationName
        { 
            get { return _operationName; }
            set { _operationName = value; } 
        }
    }
}
