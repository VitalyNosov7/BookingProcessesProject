namespace BookingProcesses
{
    /// <summary>
    /// Информация о госте.
    /// В этом Классе хранится информация о госте.
    /// </summary>
    public class Guest
    {
        /// <summary>Информация о госте.</summary>
        private Person? _currentPerson = default;
        /// <summary>Информация о госте.</summary>
        public Person CurrentPerson
        {
            get { return _currentPerson!; }
            set { _currentPerson = value; }
        }
    }
}
