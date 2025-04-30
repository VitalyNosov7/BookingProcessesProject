namespace BookingProcesses
{
    /// <summary>
    /// Шаблон сообщенияю
    /// В этом классе хранятся данные шаблона сообщения.
    /// </summary>
    public class TemplateMessage
    {
        #region СВОЙСТВА
        /// <summary>Название шаблона.</summary>
        private String? _templateMessageName = default;
        /// <summary>Название шаблона.</summary>
        public String TemplateMessageName
        {
            get { return _templateMessageName!; }
            set { _templateMessageName = value; }
        }

        /// <summary>Тело шаблона.</summary>
        private String? _cuttentTemplateMessage = default;
        /// <summary>Тело шаблона.</summary>
        public String CurrentTemplateMessage
        {
            get { return _cuttentTemplateMessage!; }
            set { _cuttentTemplateMessage = value; }
        }
        #endregion
    }
}
