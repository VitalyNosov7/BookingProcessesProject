using BookingProcesses.Interfaces;

namespace BookingProcesses
{
    /// <summary>
    /// Санаторий.
    /// В этом классе хранится информация о санатории.
    /// </summary>
    public class ResortComplex:IResortComplex
    {
        #region СВОЙСТВА
        /// <summary>Название санатория.</summary>
        private String? _sanatoriumName = default;

        //public string ResortComplex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>Название санатория.</summary>
        public String ResortComplexName
        {
            get { return _sanatoriumName!; }
            set { _sanatoriumName = value; }
        }
        #endregion
    }
}
