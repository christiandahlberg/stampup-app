using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PK1_Client.GUI;
using Resources;
using Resources.DAL;
using Resources.Models;

namespace PK1_Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string logFile = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName
                + @"\Resources\Resources\ErrorLog.txt";
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginGUI());
        }
    }
}