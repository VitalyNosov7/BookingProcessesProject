namespace BookingProcesses
{
    /// <summary>
    /// Конструктор сообщений.
    /// В этом классе собирается готовое сообщение по передаваемому шаблону.
    /// 
    /// </summary>
    public class ConstructorMessage
    {
        private BookingOperation _currentBookingOperation = null;
        public BookingOperation CurrentBookingOperation
        {
            get { return _currentBookingOperation; }
            set { _currentBookingOperation = value; }
        }

        /// <summary>Сформированное сообщение.</summary>
        private String _constructoredMessage = String.Empty;
        /// <summary>Сформированное сообщение.</summary>
        public String ConstructoredMessage
        {
            get { return _constructoredMessage; }
            set { _constructoredMessage = value; }
        }
        /// <summary>Шаблон сообщения</summary>
        private String _templateMessage = String.Empty;
        /// <summary>Шаблон сообщения</summary>
        public String TemplateMessage
        {
            get { return _templateMessage; }
            set { _templateMessage = value; }
        }
    }
}
