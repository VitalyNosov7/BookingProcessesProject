namespace BookingProcesses.Models
{
    /// <summary>
    /// Информация о человеке.
    /// В этом классе содержится основная информация о человеке.
    /// </summary>
    public class Person
    {
        #region СВОЙСТВА
        /// <summary>Фамилия человека.</summary>
        private string? _lastName = default;
        /// <summary>Фамилия человека.</summary>
        public string LastName 
        { 
            get { return _lastName!; }
            set { _lastName = value; } 
        }

        /// <summary>Имя человека.</summary>
        private string? _firstName = default;
        /// <summary>Имя человека.</summary>
        public string FirstName
        {
            get { return _firstName!; }
            set { _firstName = value; }
        }

        /// <summary>Оочество человека.</summary>
        private string? _patronymic = default;
        /// <summary>Оочество человека.</summary>
        public string Patronymic
        {
            get { return _patronymic!; }
            set { _patronymic = value; }
        }

        //  TODO: добавить дату рождения. 
        #endregion

        #region МЕТОДЫ

        

        #endregion
    }
}
