using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;

namespace NCB
{
    class Core
    {
        public static void WriteLog(string log)
        { 
            Console.WriteLine(DateTime.Now.ToString() + " SYSLOG: " + log);
            return;
        }

        public static void handleException(Exception what)
        {
            WriteLog("Exception: " + what.ToString());
        }

        public static void LoadConf()
        { 
            
        }

        public static void Load()
        { 
            
        }
    }
}
