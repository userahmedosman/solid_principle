using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_Open_Closed_Principle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace SOLID._2_Open_Closed_Principle
    {
        public class Logging_Service_ORB
        {

            private readonly ILogger _logger;

            public Logging_Service_ORB(ILogger logger)
            {
                this._logger = logger;
            }
            public enum enLogService { File, EventLog, Database }

            public void SendErrorLog(string error)
            {
                _logger.Log(error);
            }
        }

        public interface ILogger
        {
            void Log(string error);
        }

        public class ToFile_OCP: ILogger
        {
            public void Log(string error)
            {
                Console.WriteLine($"\n{error}");
            }
        }

        public class ToEventLog_OCP: ILogger
        {
            public void Log(string error)
            {
                Console.WriteLine($"\n{error}");
            }
        }

        public class ToDatabase_OCP: ILogger
        {
            public  void Log(string error)
            {
                Console.WriteLine($"\n{error}");
            }
        }

        public class ToExcel_OCP : ILogger
        {
            public void Log(string error)
            {
                Console.WriteLine($"\n{error}");
            }
        }
    }

}
