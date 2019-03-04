using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPK1_Click(object sender, EventArgs e)
        {
            Process process = new Process()
            {
                StartInfo =
                {
                    FileName = "PK1_Client.exe"
                }
            };

            process.Start();
        }

        private void btnPK2_Click(object sender, EventArgs e)
        {
            Process process = new Process()
            {
                StartInfo =
                {
                    FileName = "PK2_Client.exe"
                }
            };

            process.Start();

        }

        private void btnWS1_Click(object sender, EventArgs e)
        {
            //logic here 
        }

        private void btnWS2_Click(object sender, EventArgs e)
        {
            //logic here 
        }

        private void btnERP_Click(object sender, EventArgs e)
        {
            //logic here 
        }
    }
}
