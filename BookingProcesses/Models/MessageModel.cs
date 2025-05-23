﻿using BookingProcesses.Data;
using BookingProcesses.Interfaces;

namespace BookingProcesses.Models
{
    //  TODO: Пересмотреть назначение этого класса - свойства и методы!

    /// <summary>
    /// Конструктор сообщений.
    /// В этом классе собирается готовое сообщение по передаваемому шаблону.
    /// 
    /// </summary>
    public class MessageModel
    {
        public MessageModel(BookingOperation? bookingOperation, TemplateMessage? templateMessage)
        {
            CurrentBookingOperation = bookingOperation!;
            CurrentTemplateMessage = templateMessage!;
        }

        #region СВОЙСТВА

        /// <summary>Текущие данные бронирования.</summary>
        private IBookingDetails? _currentBooking = default;
        /// <summary>Текущие данные бронирования.</summary>
        public IBookingDetails CurrentBooking
        {
            get { return _currentBooking!; }
            set { _currentBooking = value; }
        }

        /// <summary>Текущая операция бронирования.</summary>
        private BookingOperation? _currentBookingOperation = default;
        /// <summary>Текущая операция бронирования.</summary>
        public BookingOperation CurrentBookingOperation
        {
            get { return _currentBookingOperation!; }
            set { _currentBookingOperation = value; }
        }

        /// <summary>Сформированное сообщение.</summary>
        private string? _constructoredMessage = default;
        /// <summary>Сформированное сообщение.</summary>
        public string ConstructoredMessage
        {
            get { return _constructoredMessage!; }
            set { _constructoredMessage = value; }
        }
        /// <summary>Шаблон сообщения</summary>
        private TemplateMessage? _currentTemplateMessage = default;
        /// <summary>Шаблон сообщения</summary>
        public TemplateMessage CurrentTemplateMessage
        {
            get { return _currentTemplateMessage!; }
            set { _currentTemplateMessage = value; }
        }
        #endregion

    }
}
