using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lockdown
{
    public partial class frmReminders : Form
    {
        public Form pForm;
        private List<Reminder> _defaultReminders = new List<Reminder>();
        private List<Reminder> _myReminders = new List<Reminder>();
        private const string REMINDERS_FILE_PATH = @"C:\Program Files\Lockdown\Reminders\Reminders.json";
        public frmReminders()
        {
            InitializeComponent();
            UpdateMyRemindersList();
            TheTimer();
        }

        public void UpdateMyRemindersList()
        {
            LoadMyReminders();
            foreach (var reminder in _myReminders)
            {
                clbMyReminders.Items.Add(reminder.name);
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.pForm.Show();
            this.Hide();
        }

        private void lblAddReminder_Click(object sender, EventArgs e)
        {
            frmAddReminder addReminder = new frmAddReminder();
            addReminder.parentForm = this;
            addReminder.Show();
        }

        private void LoadMyReminders()
        {
            _myReminders.Clear();
            string[] jsonArray = System.IO.File.ReadAllLines(REMINDERS_FILE_PATH);
            foreach (var line in jsonArray)
            {
                Reminder tempReminder = JsonSerializer.Deserialize<Reminder>(line);
                _myReminders.Add(tempReminder);
            }
        }

        private void DisplayReminder()
        {

            // from stackoverflow
            var notification = new System.Windows.Forms.NotifyIcon()
            {
                Visible = true,
                Icon = Properties.Resources.LockdownIcon,//System.Drawing.SystemIcons.Application,
                // optional - BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info,
                // optional - BalloonTipTitle = "My Title",
                BalloonTipText = "Take a walk fatty",
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

        private void ReminderTimer()
        {
            int time = DateTime.Now.Minute;
            int[] fifteenMinuteIntervals = { 0, 15, 30, 45 };
            if (fifteenMinuteIntervals.Contains(time))
            {
                DisplayReminder();
            }
        }

        private void TheTimer()
        {
            double currentSecond = 60 - DateTime.Now.Second;
            var startTimeSpan = TimeSpan.FromSeconds(currentSecond);
            var interval = TimeSpan.FromMinutes(1);
            var timer = new System.Threading.Timer((e) =>
            {
                ReminderTimer();
            }, null, startTimeSpan, interval);
        }
    }
}
