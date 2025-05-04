using BookingProcesses.Interfaces;

namespace BookingProcesses
{
    /// <summary>
    /// Получение строкового значения путем ввода через консоль.
    /// </summary>
    public class GetStringValueViaConsole : IGetStringValue
    {
        public String GetStringValue()
        {
            String inputStringValue = String.Empty;
            inputStringValue = Console.ReadLine()!;
            return inputStringValue;
        }
    }
}
