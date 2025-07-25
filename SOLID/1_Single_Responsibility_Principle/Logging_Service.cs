using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Single_Responsibility_Principle
{
    public class Logging_Service
    {
        public enum enLogService { File, EventLog, Database }

        public void SendErrorLog(string error, enLogService logservice)
        {

            if (logservice == enLogService.Database)
            {
                ToDataBase(error);
            }
            else if (logservice == enLogService.EventLog)
            {
                ToEventLog(error);
            }
            else if (logservice == enLogService.File)
            {
                ToFile(error);
            }
        }
     
        private void ToFile(string error)
        {
            Console.WriteLine($"\n{error}");
        }

  
        private void ToEventLog(string error)
        {
            Console.WriteLine($"\n{error}");
        }

  
        private void ToDataBase(string error)
        {
            Console.WriteLine($"\n{error}");
        }
}
}
