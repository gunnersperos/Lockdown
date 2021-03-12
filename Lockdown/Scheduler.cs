using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lockdown
{
    public class Scheduler
    {
        public string profile { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }

        private const string SET_SCHEDULE_SCRIPT = @"C:\Program Files\Lockdown\Scripts\SetSchedule.ps1";

        public Scheduler()
        {
            profile = string.Empty;
            dateStart = new DateTime();
            dateEnd = new DateTime();
            timeStart = new DateTime();
            timeEnd = new DateTime();
        }
        
        public Scheduler(string pFile, DateTime dStart, DateTime dEnd, DateTime tStart, DateTime tEnd)
        {
            profile = pFile;
            dateStart = dStart;
            dateEnd = dEnd;
            timeStart = tStart;
            timeEnd = tEnd;
        }

        public void ScheduleTask()
        {
            string scheduleTime = timeStart.TimeOfDay.ToString();

            //check if this is the first time aka creating the schedule or just changing it

            bool isSchedulerEmpty = System.IO.File.ReadAllLines(SET_SCHEDULE_SCRIPT).Length > 0 ? false : true;

            if (isSchedulerEmpty)
            {
                //scheduler file is empty, so write script to create task schedule
                System.IO.File.WriteAllText(SET_SCHEDULE_SCRIPT,
                  "$action = New-ScheduledTaskAction -Execute 'notepad.exe'" + '\n'
                  + "$trigger = New-ScheduledTaskTrigger -Weekly -DaysOfWeek " + this.dateStart.DayOfWeek.ToString() + " -At " + scheduleTime + '\n'
                  + "Register-ScheduledTask -Action $action -Trigger $trigger -TaskPath \"Lockdown\" -TaskName \"ScheduleLockdown\" -Description \"This task schedules opening Lockdown to block your profile.\"" + '\n'
            );
            }
            else
            {
                //scheduler file isn't empty, so write script to change task schedule
                System.IO.File.WriteAllText(SET_SCHEDULE_SCRIPT,
                  "$trigger = New-ScheduledTaskTrigger -Weekly -DaysOfWeek " + this.dateStart.DayOfWeek.ToString() + " -At " + scheduleTime + '\n'
                  + "Set-ScheduledTask -Trigger $trigger -TaskPath \"Lockdown\" -TaskName \"ScheduleLockdown\""
            );
            }
            

            //run ps script
            var runScript = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-window minimize -NoProfile -ExecutionPolicy bypass -file \"{SET_SCHEDULE_SCRIPT}\"",
                UseShellExecute = false
            };
            Process.Start(runScript);
        }

        public void DeleteTaskSchedule()
        {
            //write to ps file to delete task schedule
            System.IO.File.WriteAllText(SET_SCHEDULE_SCRIPT,
                  "Unregister-ScheduledTask -TaskName \"ScheduleLockdown\" -Confirm:$false"
            );

            //run ps script
            var runScript = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-window minimize -NoProfile -ExecutionPolicy bypass -file \"{SET_SCHEDULE_SCRIPT}\"",
                UseShellExecute = false
            };
            Process.Start(runScript);

            //last thing to do so that the SetSchedule method will create the task next time it's ran
            //System.IO.File.WriteAllText(SET_SCHEDULE_SCRIPT, string.Empty);
        }
    }
}
