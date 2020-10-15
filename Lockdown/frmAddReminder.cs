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
        private const string REMINDERS_FILE_PATH = @"C:\Users\Gunner\Source\Repos\Lockdown1\Lockdown\Resources\Data\Reminders\Reminders.txt";
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
            Reminder newReminder = new Reminder(txtName.Text);
            System.IO.File.AppendAllText(REMINDERS_FILE_PATH, "\n");
            System.IO.File.AppendAllText(REMINDERS_FILE_PATH, newReminder.name);
        }
    }
}
