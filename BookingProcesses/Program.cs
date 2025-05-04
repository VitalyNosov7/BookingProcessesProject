using BookingProcesses.Controllers;

namespace BookingProcesses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BOOKING PROCESSES");
            PersonController personController = new PersonController();
            personController.GetStringValue = new GetStringValueViaConsole();
            var lastNamePerson = personController.CurrentPerson.LastName;
            Console.WriteLine($"До вызова метода: {lastNamePerson}");
            Console.Write("Введите фамилию:");
            personController.AddLastNamePerson();
            lastNamePerson = personController.CurrentPerson.LastName;
            Console.WriteLine($"После вызова метода: {lastNamePerson}");
            Console.ReadLine();
        }
    }
}
