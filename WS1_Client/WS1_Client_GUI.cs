using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WS1_Client
{
    public partial class WS1_Client_GUI : Form
    {
        public string FilePath { get; set; }

        public WS1_Client_GUI()
        {
            InitializeComponent();
        }

        private void ConsoleClient_Click(object sender, EventArgs e)
        {
            if (FilePath == null)
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Please choose a valid file.";
                return;
            }

            StartProcess("WS1_Console_Client.exe");
        }

        private void WinFormsClient_Click(object sender, EventArgs e)
        {
            if (FilePath == null)
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Please choose a valid file.";
                return;
            }

            StartProcess("WS1_WindowsForms_Client.exe");
        }

        private void JavaClient_Click(object sender, EventArgs e)
        {

            if (FilePath == null)
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Please choose a valid file.";
                return;
            }
            string args = "\"" + Directory.GetParent(Directory.GetCurrentDirectory())
                .Parent.Parent.FullName + @"\Resources\Resources\WS1_Java_Client.jar" + "\"";
            args = args.Insert(0, "-jar ");

            // string args = "-jar WS1_Java_Client.jar"; // "-jar ~/../../../Resources/Resources/WS1_Java_Client.jar";
            StartProcess("java.exe", args);
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FilePath = openFileDialog1.FileName;
                string ext = Path.GetExtension(FilePath);

                if (ext != ".txt")
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Please choose a valid textfile..";
                    FilePath = null;
                }
                else
                {
                    label2.ForeColor = Color.Black;
                    label2.Text = FilePath;
                }

            }
        }

        private void StartProcess(string clientFile, params string[] parameters)
        {

            string arguments = "";

            for (int i = 0; i < parameters.Length; i++)
            {
                arguments += " " + parameters[i];
            }

            arguments += " " + FilePath;

            Process process = new Process
            {
                StartInfo =
                {
                  FileName = clientFile,
                  Arguments = arguments
                }
            };

            process.Start();
        }
    }
}