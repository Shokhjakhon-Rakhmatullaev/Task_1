using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Parser
{
    
    public static class Logger {
        public static void Log(string message)
        {
            string logPath = "C:\\Users\\Asus\\source\\repos\\CSV_Parser\\CSV_Parser\\"  + "Log.txt"; 

            //Use this variable if you want to test this application on your local machine.
            //string logPath = Directory.GetCurrentDirectory() + "/" + "Log.txt"; 

            using(StreamWriter sw = new StreamWriter(logPath,true))
            {
                sw.WriteLine(message);
            }
        }
    
    }
}
