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
        public int remindInterval { get; set; } // "How Often" field on the AddReminder form
        public int reminderType { get; set; }
        public enum ReminderType
        {
            banner = 1,
            popup = 2
        }
        private System.Threading.Timer timer;

        #endregion

        #region Constructors
        //Empty Constructor
        public Reminder()
        {
            this.name = string.Empty;
            this.isReminderOn = false;
            this.remindInterval = 0;
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
            this.reminderType = reminderType;
        }

        public void ReminderTimer()
        {
            if (!this.isReminderOn)
            {
                return; // don't start reminder if not enabled duh
            }
            //start timer
            //got this from stack overflow
            var startTimeSpan = TimeSpan.FromMinutes(remindInterval);
            var interval = TimeSpan.FromMinutes(this.remindInterval);
            this.timer = new System.Threading.Timer((e) =>
            {
                if (isReminderOn)
                {
                    DisplayReminder();
                }
                else
                {
                    this.timer.Dispose();
                }
                
            }, null, startTimeSpan, interval);
        }
        private void DisplayReminder()
        {
            // from stackoverflow
            var notification = new System.Windows.Forms.NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                // optional - BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info,
                // optional - BalloonTipTitle = "My Title",
                BalloonTipText = this.name,
            };

            // Display for 5 seconds.
            notification.ShowBalloonTip(5000);

            // This will let the balloon close after it's 5 second timeout
            // for demonstration purposes. Comment this out to see what happens
            // when dispose is called while a balloon is still visible.
            System.Threading.Thread.Sleep(10000);

            // The notification should be disposed when you don't need it anymore,
            // but doing so will immediately close the balloon if it's visible.
            notification.Dispose();
        }

        public void StartStopReminder(System.Windows.Forms.CheckState newValue)
        {
            if (newValue == System.Windows.Forms.CheckState.Checked)
            {
                this.ReminderTimer();
            }
            else
            {
                if (this.timer != null)
                {
                    this.timer.Dispose();
                }
            }
        }


        #endregion
    }
}
