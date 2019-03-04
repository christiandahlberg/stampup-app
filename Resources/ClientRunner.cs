using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    public class ClientRunner
    {

        public static void Start(string clientFile, string args = null)
        {

            Process process = new Process
            {
                StartInfo =
                {
                  FileName = clientFile,
                  Arguments = args
                }
            };

            process.Start();
        }
    }
}
