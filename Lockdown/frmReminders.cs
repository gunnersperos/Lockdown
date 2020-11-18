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
        private bool isLoading = true;
        private bool isListClicked = false;

        public Form pForm;
        private List<Reminder> _defaultReminders = new List<Reminder>();
        public List<Reminder> _myReminders = new List<Reminder>();
        private const string REMINDERS_FILE_PATH = @"C:\Program Files\Lockdown\Reminders\Reminders.json";
        public frmReminders()
        {
            InitializeComponent();
            UpdateMyRemindersList();
            StartReminders();
        }

        private void frmReminders_Load(object sender, EventArgs e)
        {
            UpdateMyRemindersList();
            this.isLoading = false;
            
        }

        public void UpdateMyRemindersList()
        {
            LoadMyReminders();
            clbMyReminders.Items.Clear();
            foreach (var reminder in _myReminders)
            {
                clbMyReminders.Items.Add(reminder.name);
            }

            //annoyingly long amount of code to make sure reminder checkstate is correct
            int reminderListCount = clbMyReminders.Items.Count;
            for (int i = 0; i < reminderListCount; i++)
            {
                clbMyReminders.SetItemCheckState(i, BoolToCheckState(_myReminders[i].isReminderOn));
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

        private void StartReminders()
        {
            foreach (var reminder in _myReminders)
            {
                if (reminder.isReminderOn)
                {
                    reminder.ReminderTimer();
                }
            }
        }

        private void UpdateReminderOnOff(int reminderIndex, CheckState reminderSwitch)
        {
            //changes the reminder object enabled field then updates the clbMyReminders
            _myReminders[reminderIndex].isReminderOn = CheckStateToBool(reminderSwitch);
            //need to save over the reminders file
            List<string> jsonStringArray = new List<string>();
            System.IO.File.WriteAllText(REMINDERS_FILE_PATH, string.Empty);
            foreach (var reminder in _myReminders)
            {
                string jsonString = JsonSerializer.Serialize(reminder);
                jsonStringArray.Add(jsonString);
            }
            foreach (var jsonString in jsonStringArray)
            {
                System.IO.File.AppendAllText(REMINDERS_FILE_PATH, jsonString + '\n');
            }
        }

        private void clbMyReminders_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (isLoading || !isListClicked)
            {
                return; // don't want to double do this when loading the app or checkstate not actually changing
            }
            UpdateReminderOnOff(e.Index, e.NewValue);
            _myReminders[e.Index].StartStopReminder(e.NewValue);
            isListClicked = false;
        }

        private bool CheckStateToBool(CheckState checkState)
        {
            // just converting CheckState object to bool
            bool onOff = checkState is CheckState.Checked ? true : false;
            return onOff;
        }

        private CheckState BoolToCheckState(bool checkState)
        {
            // just converting bool object to CheckState
            CheckState onOff = checkState is true ? CheckState.Checked : CheckState.Unchecked;
            return onOff;
        }


        #region moved this to reminder class
        //private void DisplayReminder(string reminderText)
        //{

        //    // from stackoverflow
        //    var notification = new System.Windows.Forms.NotifyIcon()
        //    {
        //        Visible = true,
        //        Icon = Properties.Resources.LockdownIcon,//System.Drawing.SystemIcons.Application,
        //        // optional - BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info,
        //        // optional - BalloonTipTitle = "My Title",
        //        BalloonTipText = reminderText,
        //    };

        //    // Display for 5 seconds.
        //    notification.ShowBalloonTip(5000);

        //    // This will let the balloon close after it's 5 second timeout
        //    // for demonstration purposes. Comment this out to see what happens
        //    // when dispose is called while a balloon is still visible.
        //    System.Threading.Thread.Sleep(10000);

        //    // The notification should be disposed when you don't need it anymore,
        //    // but doing so will immediately close the balloon if it's visible.
        //    notification.Dispose();
        //}

        //private void ReminderTimer() // this is going to be needed for each reminder
        //{
        //    int time = DateTime.Now.Minute;
        //    int[] fifteenMinuteIntervals = { 0, 15, 30, 40, 45 };
        //    if (fifteenMinuteIntervals.Contains(time))
        //    {
        //        //DisplayReminder();
        //    }
        //}

        //private void TheTimer()
        //{
        //    //double currentSecond = 60 - DateTime.Now.Second;
        //    var startTimeSpan = TimeSpan.Zero;//FromSeconds(currentSecond);
        //    var interval = TimeSpan.FromMinutes(1);
        //    var timer = new System.Threading.Timer((e) =>
        //    {
        //        ReminderTimer();
        //    }, null, startTimeSpan, interval);
        //}
        #endregion

        private void clbMyReminders_Click(object sender, EventArgs e)
        {
            this.isListClicked = true;
            
        }

        private void clbMyReminders_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.isListClicked = false;
        }
    }
}
