using PK1_Client.Controller;
using PK1_Client.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PK1_Client.GUI
{
    public partial class LoginGUI : Form
    {
        private CustomerController customerController;
        private OfferController offerController;

        public LoginGUI()
        {
            InitializeComponent();
            customerController = new CustomerController();
            offerController = new OfferController();

            // Sets autofocus to e-mail textbox when initiated.
            ActiveControl = tb_LoginEmail;
        }

        // Sign in
        private void SignInEvent(object sender, EventArgs e)
        {
            // Check if textboxes are empty and validates email
            if (string.IsNullOrWhiteSpace(tb_LoginEmail.Text) ||
                string.IsNullOrWhiteSpace(tb_LoginPassword.Text))
            {
                SetSignInSystemMessage("ERROR: Please enter values in all fields.");
            }
            else if (RegularExpressionHandler.IsValidEmail(tb_LoginEmail.Text) != true)
            {
                SetSignInSystemMessage("ERROR: Please check e-mail format.");
            }
            else
            {
                if (customerController.VerifyCustomer(tb_LoginEmail.Text, tb_LoginPassword.Text))
                {
                    if (tb_LoginEmail.Text.Contains("@admin.com"))
                    {
                        Hide();
                        var admin = new AdminGUI();
                        admin.Closed += (s, args) => this.Close();
                        admin.Show();
                    }
                    else
                    {
                        Hide();
                        var customer = new CustomerGUI(customerController.GetCustomerByEmail(tb_LoginEmail.Text));
                        customer.Closed += (s, args) => this.Close();
                        customer.Show();
                    }
                }
                else
                {
                    SetSignInSystemMessage("ERROR: Wrong username or password.");
                }
            }

        }

        // Register
        private void RegisterEvent(object sender, EventArgs e)
        {
            // Check textboxes and that password matches
            if (string.IsNullOrWhiteSpace(tb_RegisterName.Text) ||
                string.IsNullOrWhiteSpace(tb_RegisterEmail.Text) ||
                string.IsNullOrWhiteSpace(tb_RegisterPhone.Text) ||
                string.IsNullOrWhiteSpace(tb_RegisterPassword.Text) ||
                string.IsNullOrWhiteSpace(tb_RegisterPassword2.Text))
            {
                SetSignInSystemMessage("ERROR: Please enter values in all fields.");
            }
            else if (!tb_RegisterPassword.Text.Equals(tb_RegisterPassword2.Text))
            {
                SetSignInSystemMessage("ERROR: Passwords must match!");
            }
            else if (RegularExpressionHandler.IsValidPhone(tb_RegisterPhone.Text) != true)
            {
                SetSignInSystemMessage("ERROR: Check format of phone number!");
            }
            else if (RegularExpressionHandler.IsValidEmail(tb_RegisterEmail.Text) != true)
            {
                SetSignInSystemMessage("ERROR: Check format of e-mail address!");
            }
            else
            {
                if (customerController.CreateCustomer(tb_RegisterName.Text, tb_RegisterEmail.Text,
                                                  tb_RegisterPhone.Text, tb_RegisterPassword.Text))
                {
                    SetSignInSystemMessage("Registration was successfull! You can now log in.");
                    ClearTextBoxes();
                }
                else
                {
                    SetSignInSystemMessage("ERROR: An account with that e-mail is already registered.");
                }
            }
        }

        // ---------------------------------------------------------------------------
        // -------------------------------- MISC -------------------------------------
        // ---------------------------------------------------------------------------

        private void ClearTextBoxes()
        {
            tb_RegisterName.Text = null;
            tb_RegisterPhone.Text = null;
            tb_RegisterEmail.Text = null;
            tb_RegisterPassword.Text = null;
            tb_RegisterPassword2.Text = null;
        }

        public void SetSignInSystemMessage(string message)
        {
            if (message.Contains("ERROR:"))
            {
                lbl_SystemMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lbl_SystemMessage.ForeColor = System.Drawing.Color.Black;
            }
            lbl_SystemMessage.Text = message;
        }
    }
}
