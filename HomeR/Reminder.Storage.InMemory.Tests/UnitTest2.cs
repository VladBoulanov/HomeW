using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.Core;
using Reminder.Storage.InMemory;

namespace Reminder.Storage.InMemory.Tests
{
    [TestClass]
    public class InMemoryStorageUnitTest2
    {
        internal readonly Dictionary<Guid, ReminderItem> reminders = new Dictionary<Guid, ReminderItem>();
        [TestMethod]
        public void TestMethod1()
        {
            Guid id = Guid.NewGuid();
            reminders[id] = null;
            Assert.IsNotNull(reminders[id]);
        }
    }
}
