using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class NLog
    {
        static Logger logger = LogManager.GetCurrentClassLogger();

        //Method to write success info to a Logfile
        public static void SuccessInfo(string message)
        {
            logger.Info(message);
        }

        //Method to write error info to a Logfile
        public static void ErrorInfo(string message)
        {
            logger.Error(message);
        }
    }
}
