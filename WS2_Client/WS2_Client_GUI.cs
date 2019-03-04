using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WS2_Client
{
    public partial class WS2_Client_GUI : Form
    {

        public string FilePath { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ConsoleClient_Click(object sender, EventArgs e)
        {
            Process process = new Process()
            {
                StartInfo =
               {
                   FileName = "ConsoleClientWS2.exe"
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
                    FileName = "WindowsFormsClientWS2.exe"
                }
            };

            process.Start();



        }

        private void btn_JavaClient_Click(object sender, EventArgs e)
        {





        }
    }
}