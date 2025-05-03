namespace BookingProcesses
{
    /// <summary>
    /// Информация о человеке.
    /// В этом классе содержится основная информация о человеке.
    /// </summary>
    public class Person
    {
        #region СВОЙСТВА
        /// <summary>Фамилия человека.</summary>
        private String? _lastName = default;
        /// <summary>Фамилия человека.</summary>
        public String LastName 
        { 
            get { return _lastName!; }
            set { _lastName = value; } 
        }

        /// <summary>Имя человека.</summary>
        private String? _firstName = default;
        /// <summary>Имя человека.</summary>
        public String FirstName
        {
            get { return _firstName!; }
            set { _firstName = value; }
        }

        /// <summary>Оочество человека.</summary>
        private String? _patronymic = default;
        /// <summary>Оочество человека.</summary>
        public String Patronymic
        {
            get { return _patronymic!; }
            set { _patronymic = value; }
        }

        //  TODO: добавить дату рождения. 
        #endregion
    }
}
