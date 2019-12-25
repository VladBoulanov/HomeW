using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Reminder.Storage.Core
{
    public class ReminderItem
    {
        Thread _thread;
        public Guid Id { get; set; }
        public DateTimeOffset date { get; set; }
        public string Message { get; set; }
        private long contactId;
        public long contactID { get => contactId; 
            set {
                contactId = value < 0 ? 0 : value;
            }
        }
        public ReminderStatus _status { get; set; } = ReminderStatus.Awaiting;
        public TimeSpan _timeToAlarm => date-DateTime.UtcNow;



        public ReminderItem(Guid id, DateTimeOffset date, string message, long contactId) {
            this.Id = id;
            this.date = date;
            this.Message = message;
            this.contactId = contactId;
            _thread = new Thread(StartReminder);
            _thread.Start();
        }

        public override string ToString()
        {
            return $"До срабатывания осталось {_timeToAlarm.TotalSeconds}. Сообщение: {Message} ";
        }


        private void StartReminder()
        {
            while (true) {
                if (_timeToAlarm.TotalMilliseconds <= 0)
                {
                    Console.WriteLine($"Надо делать работу: {Message}");
                    break;
                }
                else Thread.Sleep(20);
                
            }
            _thread.Interrupt();
            
        }

    }
}
