namespace BookingProcesses.Data
{
    /// <summary>
    /// Информация о госте.
    /// В этом Классе хранится информация о госте.
    /// </summary>
    public class Guest
    {
        #region СВОЙСТВА
        /// <summary>Информация о госте.</summary>
        private Person? _currentPerson = default;
        /// <summary>Информация о госте.</summary>
        public Person CurrentPerson
        {
            get { return _currentPerson!; }
            set { _currentPerson = value; }
        }

        /// <summary>Дата начала проживания.</summary>
        private DateTime _startPeriodResidence = default;
        /// <summary>Дата начала проживания.</summary>
        public DateTime StartPeriodResidence
        {
            get { return _startPeriodResidence; }
            set { _startPeriodResidence = value; }
        }

        /// <summary>Дата окончания проживания.</summary>
        private DateTime _endPeriodResidence = default;
        /// <summary>Дата окончания проживания.</summary>
        public DateTime EndPeriodResidence
        {
            get { return _endPeriodResidence; }
            set { _endPeriodResidence = value; }
        }

        /// <summary>Главный гость.</summary>
        private bool _chiefGuest = default;
        /// <summary>Главный гость.</summary>
        public bool ChiefGuest
        {
            get { return _chiefGuest; }
            set { _chiefGuest = value; }
        }

        #endregion
    }
}
