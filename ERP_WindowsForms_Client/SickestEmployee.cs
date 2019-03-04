using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_WindowsForms_Client
{
    public partial class SickestEmployee : Form
    {
        public SickestEmployee(Boolean blink)
        {
            InitializeComponent();
            if (blink)
            {
                BlinkLabel();
            }
        }

        public async void BlinkLabel()
        {
            while (true)
            {
                await Task.Delay(100);
                lbl_sickestEmployee.BackColor = lbl_sickestEmployee.BackColor == Color.Red ? Color.Yellow : Color.Red;
                lbl_sickestEmployee.ForeColor = lbl_sickestEmployee.ForeColor == Color.Yellow ? Color.Red : Color.Yellow;
            }
        }

        public void SetLblName(string name)
        {
            lbl_sickestEmployee.Text = name;
        }
    }
}
