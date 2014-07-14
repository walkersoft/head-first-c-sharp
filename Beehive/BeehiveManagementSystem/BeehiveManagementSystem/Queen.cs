using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int shifts) 
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(job, shifts))
                    return true;
            }
            return false;
        }
        public string WorkTheNextShift() 
        {
            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + ".\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    report += "Bee #" + (i + 1) + " has finished the job.\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Bee #" + (i + 1) + " is not working.\r\n";
                else 
                    if (workers[i].ShiftsLeft > 0)
                        report += "Bee #" + (i + 1) + " is working on " + workers[i].CurrentJob + 
                            " for " + workers[i].ShiftsLeft + " more shifts.\r\n";
                    else
                        report += "Bee #" + (i + 1) + " will finish after the next shift.\r\n";
            }
            return report;
        }

    }
}
