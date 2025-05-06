using BookingProcesses.Data;

namespace BookingProcesses.Interfaces
{
    public interface IBookingDetails
    {
        public UInt32 BookingNumber { get; set; }
        public List<Guest> CurrentListGuest { get; set; }
        public IResortComplex CurrentResortComplex {  get; set; }
    }
}
