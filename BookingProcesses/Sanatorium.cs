namespace BookingProcesses
{
    /// <summary>
    /// Санаторий.
    /// В этом классе хранится информация о санатории.
    /// </summary>
    public class Sanatorium
    {
        #region СВОЙСТВА
        /// <summary>Название санатория.</summary>
        private String? _sanatoriumName = default;
        /// <summary>Название санатория.</summary>
        public String SanatoriumName
        {
            get { return _sanatoriumName!; }
            set { _sanatoriumName = value; }
        }
        #endregion
    }
}
