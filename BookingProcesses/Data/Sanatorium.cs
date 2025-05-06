using BookingProcesses.Interfaces;

namespace BookingProcesses.Data
{
    /// <summary>
    /// Санаторий.
    /// В этом классе хранится информация о санатории.
    /// </summary>
    public class Sanatorium : IResortComplex
    {
        /// <summary>Название санатория.</summary>
        private string? _sanatoriumName = default;
        /// <summary>Название санатория.</summary>
        public string ResortComplexName 
        {
            get { return _sanatoriumName!; }
            set { _sanatoriumName = value; }
        }
    }
}
