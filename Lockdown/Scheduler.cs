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
            //DateTime twelveHourTime = timeStart;
            string scheduleTime = timeStart.TimeOfDay.ToString();
            int minute = timeStart.Minute;
            string minuteString = timeStart.Minute.ToString();
            if (minute < 10)//if minute is less than 10, it's just one digit
            {
                minuteString = '0' + minute.ToString();
            }
            if (timeStart.Hour == 0) //12 something in the morning
            {
                scheduleTime = "12:" + minuteString + "am";    
            }
            else if(timeStart.Hour > 12) //1 or later in the afternoon
            {
                int newHour = timeStart.Hour - 12;
                scheduleTime = newHour + ':' + minuteString + "pm";
            }
            else
            {
                scheduleTime += "am";
            }
            System.IO.File.WriteAllText(SET_SCHEDULE_SCRIPT,
                  "$action = New-ScheduledTaskAction -Execute 'notepad.exe'" + '\n'
                  + "$trigger = New-ScheduledTaskTrigger -Weekly -DaysOfWeek " + this.dateStart.DayOfWeek.ToString() + " -At " + scheduleTime + '\n'
                  + "Register-ScheduledTask -Action $action -Trigger $trigger -TaskPath \"Lockdown\" -TaskName \"ScheduleLockdown\" -Description \"This task schedules opening Lockdown to block your profile.\"" + '\n'
            );

            //run ps script
            var runScript = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-window minimize -NoProfile -ExecutionPolicy bypass -file \"{SET_SCHEDULE_SCRIPT}\"",
                UseShellExecute = false
            };
            Process.Start(runScript);
        }
    }
}
