
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS1_Console_Client.ServiceReference;

namespace WS1_Console_Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WS1_Console_Client.ServiceReference.ReadFileSoapClient c = new ReadFileSoapClient();
            Console.WriteLine(c.OpenFile(args[0]));
            Console.Read();
        }
    }
}