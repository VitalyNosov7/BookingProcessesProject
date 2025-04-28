namespace BookingProcesses
{
    /// <summary>
    /// Конструктор сообщений.
    /// В этом классе собирается готовое сообщение по передаваемому шаблону.
    /// 
    /// </summary>
    public class ConstructorMessage
    {
        public ConstructorMessage(BookingOperation? bookingOperation, TemplateMessage? templateMessage)
        {
            CurrentBookingOperation = bookingOperation!;
            CurrentTemplateMessage = templateMessage!;
        }

        #region СВОЙСТВА
        /// <summary>Текущая операция бронирования.</summary>
        private BookingOperation? _currentBookingOperation = default;
        public BookingOperation CurrentBookingOperation
        {
            get { return _currentBookingOperation!; }
            set { _currentBookingOperation = value; }
        }

        /// <summary>Сформированное сообщение.</summary>
        private String? _constructoredMessage = default;
        /// <summary>Сформированное сообщение.</summary>
        public String ConstructoredMessage
        {
            get { return _constructoredMessage!; }
            set { _constructoredMessage = value; }
        }
        /// <summary>Шаблон сообщения</summary>
        private TemplateMessage? _currentTemplateMessage = default;
        /// <summary>Шаблон сообщения</summary>
        public TemplateMessage CurrentTemplateMessage
        {
            get { return _currentTemplateMessage!; }
            set { _currentTemplateMessage = value; }
        }
        #endregion

    }
}
