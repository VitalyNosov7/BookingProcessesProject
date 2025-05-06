using BookingProcesses.Interfaces;

namespace BookingProcesses.Services
{
    /// <summary>
    /// Получение строкового значения путем ввода через консоль.
    /// </summary>
    public class GetStringValueViaConsole : IGetStringValue
    {
        public string GetStringValue()
        {
            string inputStringValue = string.Empty;
            inputStringValue = Console.ReadLine()!;
            return inputStringValue;
        }
    }
}
