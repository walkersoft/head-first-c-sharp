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
        public void WorkTheNextShift() 
        {
            shiftNumber++;
        }

    }
}
