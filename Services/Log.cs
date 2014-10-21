using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Log
    {
        private static Log LOG;
        private static StreamWriter logs;

        private Log()
        {
            logs = File.CreateText(@"Logs\" + DateTime.Now + ".log");
        }

        public static Log getInstance()
        {
            if (LOG == null)
            {
                LOG = new Log();
            }
            return LOG;
        }

        public void info(string text)
        {
            logs.Write("-- INFO " + DateTime.Now + " --> ");
            logs.WriteLine(text);
        }

        public void error(string text, Exception e)
        {
            logs.Write("-- ERROR " + DateTime.Now + " --> ");
            logs.Write(text + " : ");
            logs.WriteLine(e.Message);
        }

        public void handle (Exception e)
        {
            ;
        }
    }
}
