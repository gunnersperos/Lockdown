using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lockdown
{
    public partial class frmAddReminder : Form
    {
        public Form parentForm;
        private const string REMINDERS_FILE_PATH = @"~\Lockdown\Resources\Data\Reminders\";
        public frmAddReminder()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddReminder();
            frmReminders sendTo = (frmReminders)Application.OpenForms["frmReminders"];
            sendTo.UpdateMyRemindersList();
            this.Close();
        }

        private void AddReminder()
        {
            //set all properties
            Reminder newReminder = new Reminder();
            newReminder.name = txtName.Text;
            newReminder.isReminderOn = false;
            newReminder.remindInterval = 0;// cboHowOften.SelectedValue;
            newReminder.repeatInterval = 0;// cboRepeat.SelectedValue;
            newReminder.reminderType = 0;// cboType.SelectedValue;

            //write to txt files to store data
            System.IO.File.AppendAllText(REMINDERS_FILE_PATH + "Reminders.txt", newReminder.name);
            System.IO.File.AppendAllText(REMINDERS_FILE_PATH + "Reminders.txt", "\n");

            System.IO.File.AppendAllText(REMINDERS_FILE_PATH + "isReminderOn.txt", newReminder.isReminderOn.ToString());
            System.IO.File.AppendAllText(REMINDERS_FILE_PATH + "isReminderOn.txt", "\n");

            System.IO.File.AppendAllText(REMINDERS_FILE_PATH + "remindInterval.txt", newReminder.remindInterval.ToString());
            System.IO.File.AppendAllText(REMINDERS_FILE_PATH + "remindInterval.txt", "\n");

            System.IO.File.AppendAllText(REMINDERS_FILE_PATH + "repeatInterval.txt", newReminder.repeatInterval.ToString());
            System.IO.File.AppendAllText(REMINDERS_FILE_PATH + "repeatInterval.txt", "\n");

            System.IO.File.AppendAllText(REMINDERS_FILE_PATH + "reminderType.txt", newReminder.reminderType.ToString());
            System.IO.File.AppendAllText(REMINDERS_FILE_PATH + "reminderType.txt", "\n");
        }
    }
}
