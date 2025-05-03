using BookingProcesses.Interfaces;

namespace BookingProcesses
{
    /// <summary>
    /// Санаторий.
    /// В этом классе хранится информация о санатории.
    /// </summary>
    public class Sanatorium : IResortComplex
    {
        /// <summary>Название санатория.</summary>
        private String? _sanatoriumName = default;
        /// <summary>Название санатория.</summary>
        public String ResortComplexName 
        {
            get { return _sanatoriumName!; }
            set { _sanatoriumName = value; }
        }
    }
}
