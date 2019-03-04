﻿using System;
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

            StartProcess("ConsoleClient.exe");
        }

        private void WinFormsClient_Click(object sender, EventArgs e)
        {
            if (FilePath == null)
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Please choose a valid file.";
                return;
            }

            StartProcess("WindowsFormsClient.exe");
        }

        private void JavaClient_Click(object sender, EventArgs e)
        {

            if (FilePath == null)
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Please choose a valid file.";
                return;
            }

            string args = "-jar ~/../../../Resources/JavaClient_WS1.jar";
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