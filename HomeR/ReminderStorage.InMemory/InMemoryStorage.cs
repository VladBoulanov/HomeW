using Reminder.Storage.Core;
using System;
using System.Collections.Generic;

namespace ReminderStorage.InMemory
{
    public class InMemoryStorage : IReminderStorage
    {
        internal readonly Dictionary<Guid, ReminderItem> reminders = new Dictionary<Guid, ReminderItem>();
        
        public void Add(Guid guid, ReminderItem item)
        {
            reminders.Add(guid, item);
        }

        public ReminderItem Get(Guid id)
        {
            if (reminders[id] == null) throw new Exception("НЕ элемента с таким ID");
            return reminders[id];
        }

        public Dictionary<Guid, ReminderItem> GetList()
        {
            return reminders;
        }


        public void Display()
        {

            if (reminders.Count > 0) { 
                string msg = "";

                foreach (KeyValuePair<Guid, ReminderItem> pair in reminders)
                    msg += $"{pair.Key.ToString()}. Отправить \"{pair.Value.Message}\" через {pair.Value._timeToAlarm.TotalSeconds}\n";
                Console.WriteLine(msg);
            }
            else
            {
                Console.WriteLine("Нет задач для выполнения");
            }

        }

        List<ReminderItem> IReminderStorage.GetList()
        {
            this.Id = id;
            this.date = date;
            this.Message = message;
            this.contactId = contactId;
            _thread = new Thread(StartReminder);
            _thread.Start();
        }
    }
}
