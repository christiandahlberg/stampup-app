using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resources; 


namespace ERP_Client
{
    public partial class ERP_Client_GUI : Form
    {
        public ERP_Client_GUI()
        {
            InitializeComponent();
        }

        private void btnWindowsForms_Click(object sender, EventArgs e)
        {
            ClientRunner.Start("ERP_Java_Client.exe");
        }

        private void btnJavaClient_Click(object sender, EventArgs e)
        {
            string args = "\"" + Directory.GetParent(Directory.GetCurrentDirectory())
    .Parent.Parent.FullName + @"\Resources\Resources\ERP_Java_Client.jar" + "\"";
            args = args.Insert(0, "-jar ");

            ClientRunner.Start("java.exe", args);
        }
    }
}
