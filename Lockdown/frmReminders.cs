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
    public partial class frmReminders : Form
    {
        public Form pForm;
        private const string REMINDERS_FILE_PATH = @"C:\Users\Gunner\Source\Repos\Lockdown1\Lockdown\Resources\Data\Reminders\Reminders.txt";
        public frmReminders()
        {
            InitializeComponent();
            UpdateMyRemindersList();
        }

        public void UpdateMyRemindersList()
        {
            string[] reminders = System.IO.File.ReadAllLines(REMINDERS_FILE_PATH);
            clbMyReminders.Items.Clear();
            foreach (var line in reminders)
            {
                clbMyReminders.Items.Add(line);
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
    }
}
