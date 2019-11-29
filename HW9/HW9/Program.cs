using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public interface IReminderItem
    {
        DateTimeOffset AlarmDate
        {
            get;
            set;
        }
        string AlarmMessage
        {
            get;
            set;
        }
        TimeSpan TimeToAlarm
        {
            get;
        }
        bool IsOutdated
        {
            get;
        }
        
    }
    public class Reminder : IReminderItem
    {
        public DateTimeOffset AlarmDate
        {
            get;
            set;
        }
        public string AlarmMessage
        {
            get;
            set;
        }
        public TimeSpan TimeToAlarm
        {
            get
            {
                return AlarmDate - DateTime.Now; // в задании ошибка, если из сейчас вычитать AlarmDate, то просроченные будильники будут показывать положительное TimeToAlarm
            }
        }
        public bool IsOutdated
        {
            get
            {
                return TimeToAlarm.TotalMilliseconds >= 0.0;
            }
        }
        public Reminder(DateTimeOffset alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }
        public void WriteProperties()
        {
            Console.WriteLine(nameof(AlarmDate) + ": {0}", AlarmDate);
            Console.WriteLine(nameof(AlarmMessage) + ": {0}", AlarmMessage);
            Console.WriteLine(nameof(TimeToAlarm) + ": {0}", TimeToAlarm);
            Console.WriteLine(nameof(IsOutdated) + ": {0}", IsOutdated);
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Reminder r1 = new Reminder(new DateTimeOffset(DateTime.Now.AddHours(-1.0)), "первый будильник");
            Reminder r2 = new Reminder(new DateTimeOffset(DateTime.Now.AddHours(1.0)), "первый будильник");
            r1.WriteProperties();
            Console.WriteLine("-------------------------------------------");
            r2.WriteProperties();
        }
    }
}
