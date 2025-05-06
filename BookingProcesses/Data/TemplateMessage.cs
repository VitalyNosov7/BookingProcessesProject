namespace BookingProcesses.Data
{
    /// <summary>
    /// Шаблон сообщенияю
    /// В этом классе хранятся данные шаблона сообщения.
    /// </summary>
    public class TemplateMessage
    {
        #region СВОЙСТВА
        /// <summary>Название шаблона.</summary>
        private string? _templateMessageName = default;
        /// <summary>Название шаблона.</summary>
        public string TemplateMessageName
        {
            get { return _templateMessageName!; }
            set { _templateMessageName = value; }
        }

        /// <summary>Тело шаблона.</summary>
        private string? _cuttentTemplateMessage = default;
        /// <summary>Тело шаблона.</summary>
        public string CurrentTemplateMessage
        {
            get { return _cuttentTemplateMessage!; }
            set { _cuttentTemplateMessage = value; }
        }
        #endregion
    }
}
