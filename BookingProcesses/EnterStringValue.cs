using BookingProcesses.Interfaces;

namespace BookingProcesses
{
    public class EnterStringValue : IGetStringValue
    {
        public String GetStringValue()
        {
            String? currentStringValue = default;
            currentStringValue = Console.ReadLine();
            return currentStringValue!;
        }
    }
}
