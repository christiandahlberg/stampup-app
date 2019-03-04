using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PK1_Client.DAL;
using PK1_Client.GUI;
using PK1_Client.Model;

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

            CustomerDAL cDAL = new CustomerDAL();

            foreach (Customer cus in cDAL.GetAllCustomers())
            {
                Console.WriteLine("Name: " + cus.Name);
                Console.WriteLine("Email: " + cus.Email);
                Console.WriteLine("Phone: " + cus.Phone);
                Console.WriteLine("-------------------------");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginGUI());
        }
    }
}