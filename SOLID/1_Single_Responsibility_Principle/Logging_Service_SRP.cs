using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Single_Responsibility_Principle
{
    public class Logging_Service_SRP
    {
        public enum enLogService { File, EventLog, Database }

        public void SendErrorLog(string error, enLogService logservice)
        {

            if (logservice == enLogService.Database)
            {
                ToDatabase.DataBase(error);
            }
            else if (logservice == enLogService.EventLog)
            {
                ToEventLog.EventLog(error);
            }
            else if (logservice == enLogService.File)
            {
                ToFile.File(error);
            }
        }
    }

    public class ToFile
    {
        public static void File(string error)
        {
            Console.WriteLine($"\n{error}");
        }
    }

    public class ToEventLog
    {
        public static void EventLog(string error)
        {
            Console.WriteLine($"\n{error}");
        }
    }

    public class ToDatabase
    {
        public static void DataBase(string error)
        {
            Console.WriteLine($"\n{error}");
        }
    }
}
