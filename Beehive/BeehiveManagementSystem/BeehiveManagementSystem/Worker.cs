﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class Worker
    {
        private string[] jobsICanDo;
        private int shiftsWorked;
        private int shiftsToWork;
        public string CurrentJob { get; private set; }
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
            private set;
        }

        public Worker(string[] jobs)
        {
            jobsICanDo = jobs;
            CurrentJob = "";
        }

        public bool DoThisJob(string job, int shifts)
        {
            if(!String.IsNullOrEmpty(CurrentJob))
                return false;
            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (jobsICanDo[i] == job)
                {
                    shiftsToWork = shifts;
                    shiftsWorked = 0;
                    CurrentJob = job;
                    return true;
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(CurrentJob))
                return false;
            shiftsWorked++;
            if(shiftsWorked > shiftsToWork)
            {
                CurrentJob = "";
                shiftsWorked = 0;
                shiftsToWork = 0;
                return true;
            }
            return false;
        }
    }
}
