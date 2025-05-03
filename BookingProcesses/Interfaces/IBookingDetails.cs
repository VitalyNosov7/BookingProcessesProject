using BookingProcesses.Models;

namespace BookingProcesses.Interfaces
{
    public interface IBookingDetails
    {
        public UInt32 BookingNumber { get; set; }
        public Guest CurrentGuest { get; set; }
        public IResortComplex CurrentResortComplex {  get; set; }
    }
}
