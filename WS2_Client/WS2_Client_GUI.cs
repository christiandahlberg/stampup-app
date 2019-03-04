using System;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace WS2_Client
{
    public partial class WS2_Client_GUI : Form
    {

        public string FilePath { get; set; }
        public WS2_Client_GUI()
        {
            InitializeComponent();
        }

        private void btn_ConsoleClient_Click(object sender, EventArgs e)
        {
            Process process = new Process()
            {
                StartInfo =
               {
                   FileName = "WS2_Console_Client.exe"
               }

            };

            process.Start();


        }

        private void btn_WindowsFormClient_Click(object sender, EventArgs e)
        {

            Process process = new Process()
            {
                StartInfo =
                {
                    FileName = "WS2_WindowsForms_Client.exe"
                }
            };

            process.Start();
        }

        private void btn_JavaClient_Click(object sender, EventArgs e)
        {
            string args = "\"" +  Directory.GetParent(Directory.GetCurrentDirectory())
                .Parent.Parent.FullName + @"\Resources\Resources\WS2_Java_Client.jar" + "\"";
            args = args.Insert(0, "-jar ");

            Process process = new Process()
            {
                StartInfo =
                {
                    FileName = "java.exe",
                    Arguments = args
                }
            };

            process.Start();
        }
    }
}