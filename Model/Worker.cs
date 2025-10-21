using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Worker:Person
    {
       private double salayPerFlightHour;
        private Roles workerRole;
        public double SalaryPerFlightHour { get => salayPerFlightHour; set => salayPerFlightHour = value; }
        public Roles WorkerRole { get=>workerRole; set => workerRole = value; }
        private bool isWorkerActive;
        public bool IsWorkerActive { get => isWorkerActive; set => isWorkerActive = value; }
    }
}
