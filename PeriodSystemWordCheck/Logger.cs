using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodSystemWordCheck
{
    public static class Logger
    {

        public static void Log(string msg) => Write(msg);
        public static void Log(string format, object arg0) => Write(string.Format(format, arg0));
        public static void Log(string format, object arg0, object arg1) => Write(string.Format(format, arg0, arg1));
        public static void Log(string format, params object[] args) => Write(string.Format(format, args));

        public static void Write(string message)
        {
            Console.WriteLine(DateTime.Now.ToString("[H:mm:ss] ") + message);
        }

    }
}
