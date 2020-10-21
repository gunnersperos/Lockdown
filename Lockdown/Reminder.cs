using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lockdown
{
    public class Reminder
    {
        #region Class Members
        public string name { get; set; }
        public bool isReminderOn { get; set; }
        public int remindInterval { get; set; }
        public int repeatInterval { get; set; }
        public int reminderType { get; set; }
        private enum ReminderType
        {
            banner = 1,
            popup = 2
        }

        #endregion

        #region Constructors
        //Empty Constructor
        public Reminder()
        {
            this.name = string.Empty;
            this.isReminderOn = false;
            this.remindInterval = 0;
            this.repeatInterval = 0;
            this.reminderType = 0;
        }

        //override constructor - name
        public Reminder(string name)
        {
            this.name = name;
        }

        //override constructor - all fields
        public Reminder(string name, bool isReminderOn, int remindInterval, int repeatInterval, int reminderType)
        {
            this.name = name;
            this.isReminderOn = isReminderOn;
            this.remindInterval = remindInterval;
            this.repeatInterval = repeatInterval;
            this.reminderType = reminderType;
        }


        #endregion
    }
}
