namespace BookingProcesses.Data
{
    /// <summary>
    /// Информация о человеке.
    /// В этом классе содержится основная информация о человеке.
    /// </summary>
    public class Person
    {
        #region СВОЙСТВА
        /// <summary>Фамилия человека.</summary>
        private string _lastName = string.Empty;
        /// <summary>Фамилия человека.</summary>
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>Имя человека.</summary>
        private string? _firstName = string.Empty;
        /// <summary>Имя человека.</summary>
        public string FirstName
        {
            get { return _firstName!; }
            set { _firstName = value; }
        }

        /// <summary>Оочество человека.</summary>
        private string? _patronymic = string.Empty;
        /// <summary>Оочество человека.</summary>
        public string Patronymic
        {
            get { return _patronymic!; }
            set { _patronymic = value; }
        }

        private DateTime _birthday = default;
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        #endregion

        #region МЕТОДЫ



        #endregion
    }
}
