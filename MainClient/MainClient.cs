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
using Resources;

namespace MainClient
{
    public partial class MainClient : Form
    {
        public MainClient()
        {
            InitializeComponent();
        }

        private void btnPK1_Click(object sender, EventArgs e)
        {
            ClientRunner.Start("PK1_Client.exe");
        }

        private void btnPK2_Click(object sender, EventArgs e)
        {
            ClientRunner.Start("PK2_Client.exe");
        }

        private void btnWS1_Click(object sender, EventArgs e)
        {
            ClientRunner.Start("WS1_Client.exe");
        }

        private void btnWS2_Click(object sender, EventArgs e)
        {
            ClientRunner.Start("WS2_Client.exe");
        }

        private void btnERP_Click(object sender, EventArgs e)
        {
            ClientRunner.Start("ERP_Client.exe");
        }
    }
}
