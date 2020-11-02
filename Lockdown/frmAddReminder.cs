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
        private const string REMINDERS_FILE_PATH = @"C:\Program Files\Lockdown\Reminders\";
        public frmAddReminder()
        {
            InitializeComponent();
            PopulateDropdowns();
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

        private void PopulateDropdowns()
        {
            //How Often Dropdown
            /*
            for (int i = 5; i < 60; i += 5)
            {
                cboHowOften.Items.Add(i + " minutes");
            }
            for (int j = 60; j < 120; j += 5)
            {
                if (j > 60)
                {
                    cboHowOften.Items.Add("1 hour " + (j - 60) + " minutes");
                }
                else
                {
                    cboHowOften.Items.Add("1 hour");
                }
            }
            cboHowOften.Items.Add("2 hours");
            */
            for(int i = 15; i <= 240; i += 15)
            {
                if(i < 60)
                {
                    cboHowOften.Items.Add(i + " minutes");
                }
                else
                {
                    int hours = (i / 60);
                    int minutes = i - (hours * 60);
                    if(minutes == 0)
                    {
                        cboHowOften.Items.Add(hours + " hour(s)");
                    }
                    else
                    {
                        cboHowOften.Items.Add(hours + " hour(s) " + minutes + " minutes");
                    }
                }
            }
            
            //Reminder Type Dropdown
            var types = Enum.GetValues(typeof(Reminder.ReminderType));
            foreach (var type in types)
            {
                cboType.Items.Add(type);
            }
        }
    }
}
