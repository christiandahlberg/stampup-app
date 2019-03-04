using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PK1_Client.Model;
using PK1_Client.Controller;
using PK1_Client.GUI;
using Resources;

namespace PK1_Client
{
    public partial class AdminGUI : Form
    {
        private CustomerController customerController;
        private StoreController storeController;
        private OfferController offerController;

        public AdminGUI()
        {
            InitializeComponent();

            customerController = new CustomerController();
            storeController = new StoreController();
            offerController = new OfferController();

            UpdateTableContent();
            ActiveControl = tb_CustName;

        }

        // ---------------------------------------------------------------------------
        // ------------------------------ CUSTOMER -----------------------------------
        // ---------------------------------------------------------------------------

        // CREATE CUSTOMER
        private void CustomerCreate(object sender, EventArgs e)
        {
            string name = tb_CustName.Text;
            string email = tb_CustMail.Text;
            string phone = tb_CustPhone.Text;
            string password = tb_CustPassword.Text;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(password))
            {
                SetCustomerSystemMessage("ERROR: Please enter values in all fields.");
            }
            else if (RegularExpressionHandler.IsValidEmail(tb_CustMail.Text) != true)
            {
                SetCustomerSystemMessage("ERROR: Please check format for e-mail.");
            }
            else if (RegularExpressionHandler.IsValidPhone(tb_CustPhone.Text) != true)
            {
                SetCustomerSystemMessage("ERROR: Please check format for phone.");
            }
            else
            {
                if (customerController.CreateCustomer(name, email, phone, password))
                {
                    SetCustomerSystemMessage("Customer " + name + " successfully created!");
                    ClearTextFields(sender, e);
                    UpdateTableContent();
                    dgv_Stores.ClearSelection();
                }
                else
                {
                    SetCustomerSystemMessage("ERROR: Customer with that e-mail already exists.");
                }
            }
        }

        // UPDATE CUSTOMER
        private void CustomerUpdate(object sender, EventArgs e)
        {
            if (RegularExpressionHandler.IsValidEmail(tb_CustMail.Text) != true)
            {
                SetCustomerSystemMessage("ERROR: Please check format for e-mail.");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.OK)
                {
                    int cId = (int)dgv_Customers.Rows[dgv_Customers.CurrentCell.RowIndex].Cells[0].Value;

                    Customer customer = customerController.GetCustomerById(cId);

                    string name = tb_CustName.Text;
                    string email = tb_CustMail.Text;
                    string phone = tb_CustPhone.Text;
                    string password = tb_CustPassword.Text;

                    // if any field is empty, the previous value should be kept
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        name = customer.Name;
                    }

                    if (string.IsNullOrWhiteSpace(email))
                    {
                        email = customer.Email;
                    }

                    if (string.IsNullOrWhiteSpace(phone))
                    {
                        phone = customer.Phone;
                    }

                    // if password is empty, don't change password. Overloaded methods in controller and DAL solves this. 
                    if (string.IsNullOrWhiteSpace(password))
                    {
                        customerController.UpdateCustomer(cId, name, email, phone);
                    }
                    else
                    {
                        customerController.UpdateCustomer(cId, name, email, phone, password);
                    }

                    UpdateTableContent();
                    ClearTextFields(sender, e); // Varför ha metoden som ett event?
                    SetCustomerSystemMessage("Customer " + name + " successfully updated.");
                }
                else { SetCustomerSystemMessage("Customer update cancelled."); }
            }
        }

        // DELETE CUSTOMER
        private void CustomerDelete(object sender, EventArgs e)
        {
            // Stores Customer ID for selected row
            int cId = (int)dgv_Customers.Rows[dgv_Customers.CurrentCell.RowIndex].Cells[0].Value;

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete customer " + cId + "? All data will be removed.", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                if (customerController.RemoveCustomer(cId))
                {
                    SetCustomerSystemMessage("Successfully deleted customer.");
                }
                else
                {
                    SetCustomerSystemMessage("ERROR: Something went wrong.");
                }
            }
            else
            {
                SetCustomerSystemMessage("Customer " + cId + " was not deleted.");
            }

            UpdateTableContent();
            ClearTextFields(sender, e);
        }

        // ---------------------------------------------------------------------------
        // -------------------------------- STORE ------------------------------------
        // ---------------------------------------------------------------------------

        // CREATE STORE
        private void StoreCreate(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_StoreName.Text) ||
                string.IsNullOrWhiteSpace(tb_StoreAddress.Text))
            {
                SetStoreSystemMessage("ERROR: Please enter both fields.");
            }
            else
            {
                if (storeController.CreateStore(tb_StoreName.Text, tb_StoreAddress.Text))
                {
                    SetStoreSystemMessage("Store was successfully created.");
                }
                else
                {
                    SetStoreSystemMessage("ERROR: Failed to create store.");
                }
            }
            UpdateTableContent();

        }

        // UPDATE STORE OR OFFER
        private void UpdateStoreOrOffer(object sender, EventArgs e)
        {

            if (panel_Stores.Visible == true)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to update store?", "Update store?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.OK)
                {
                    UpdateStore(tb_StoreName.Text, tb_StoreAddress.Text);
                    SetStoreSystemMessage("Store updated!");
                }
                else
                {
                    SetStoreSystemMessage("Store was not updated.");
                }
            }

            if (panel_Offers.Visible == true)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to update offer?", "Update offer?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.OK)
                {
                    UpdateOffer();
                    SetStoreSystemMessage("Offer updated!");
                }
                else
                {
                    SetStoreSystemMessage("Offer was not updated.");
                }

            }

        }

        /// <summary>
        /// Updates store
        /// </summary>
        public void UpdateStore(string newName, string newAddress)
        {
            int sId = (int)dgv_Stores.Rows[dgv_Stores.CurrentCell.RowIndex].Cells[0].Value;


            if (string.IsNullOrWhiteSpace(tb_StoreName.Text))
            {
                newName = storeController.GetStoreById(sId).Name;
            }
            if (string.IsNullOrWhiteSpace(tb_StoreAddress.Text))
            {
                newAddress = storeController.GetStoreById(sId).Address;
            }

            storeController.UpdateStore(sId, newName, newAddress);

            UpdateTableContent();
        }

        /// <summary>
        /// Updates Offer
        /// </summary>
        public void UpdateOffer()
        {
            int offerId = (int)dgv_Offers.Rows[dgv_Offers.CurrentCell.RowIndex].Cells[0].Value;
            Offer offer = offerController.GetOfferByOfferID(offerId);

            string name = tb_offerName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                name = offer.Name;
            }

            string description = tb_offerDesc.Text;
            if (string.IsNullOrWhiteSpace(description))
            {
                description = offer.Description;
            }

            string stamps = tb_offerStampGoal.Text;
            int stampsInt;
            if (string.IsNullOrWhiteSpace(stamps))
            {
                stampsInt = offer.StampGoal;
            }
            else
            {
                stampsInt = int.Parse(tb_offerStampGoal.Text);
            }

            Offer updatedOffer = new Offer(offerId, name, description, offer.Store, stampsInt, offer.Created_at);

            offerController.UpdateOffer(updatedOffer);

            UpdateTableContent();
        }

        /// <summary>
        /// Deletes Store
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreDelete(object sender, EventArgs e)
        {
            // TODO: "Are you sure?"

            int sId = (int)dgv_Stores.Rows[dgv_Stores.CurrentCell.RowIndex].Cells[0].Value;

            storeController.RemoveStore(sId);

            UpdateTableContent();
        }

        // ---------------------------------------------------------------------------
        // -------------------------------- Offer ------------------------------------
        // ---------------------------------------------------------------------------

        /// <summary>
        /// Adds offer for specific store, opens add offer window for specific store.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOfferEvent(object sender, EventArgs e)
        {
            var offerGUI = new OfferGUI(storeController.GetStoreById((int)dgv_Stores.SelectedCells[0].Value), this);
            offerGUI.Show();
        }

        private void manageSubscriptions_Click(object sender, EventArgs e)
        {
            var subsGUI = new SubscriptionsGUI();
            subsGUI.Show();
        }

        // ---------------------------------------------------------------------------
        // ------------------------------- EVENTS ------------------------------------
        // ---------------------------------------------------------------------------

        // Event raised when selecting a row in Store table.
        private void StoreSelectedRowDataHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (panel_Offers.Visible == true)
            {
                panel_Offers.Visible = false;
            }
            panel_Stores.Visible = true;
            // Set textboxes values to selected rows values.
            DataGridViewRow row = dgv_Stores.Rows[e.RowIndex];
            tb_StoreName.Text = row.Cells[1].Value.ToString();
            tb_StoreAddress.Text = row.Cells[2].Value.ToString();
        }

        // Event raised when selecting a row in Offer table.
        private void OfferSelectedDataHandler(object sender, DataGridViewCellEventArgs e)
        {

            if (panel_Stores.Visible == true)
            {
                panel_Stores.Visible = false;
            }
            panel_Offers.Visible = true;
            // Set textboxes values to selected rows values.
            DataGridViewRow row = dgv_Offers.Rows[e.RowIndex];
            tb_offerName.Text = row.Cells[1].Value.ToString();
            tb_offerDesc.Text = row.Cells[2].Value.ToString();
            tb_offerStampGoal.Text = offerController.GetOfferByOfferID((int)row.Cells[0].Value).StampGoal.ToString();

        }

        // Event raised when selecting a row in Customer table. 
        private void CustomerSelectedRowDataHandler(object sender, DataGridViewCellEventArgs e)
        {
            // Set textboxes values to selected rows values.
            DataGridViewRow row = dgv_Customers.Rows[e.RowIndex];
            tb_CustName.Text = row.Cells[1].Value.ToString();
            tb_CustMail.Text = row.Cells[2].Value.ToString();
            tb_CustPhone.Text = row.Cells[3].Value.ToString();
        }

        // Puts user back to LoginGUI page
        private void AdminLogout(object sender, EventArgs e)
        {
            Hide();
            var login = new LoginGUI();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        // Set customer and store message. If message starts with 'ERROR: ' set message forecolor to red.
        public void SetCustomerSystemMessage(string message)
        {
            if (message.Contains("ERROR:"))
            {
                lbl_CustSystemMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lbl_CustSystemMessage.ForeColor = System.Drawing.Color.Black;
            }
            lbl_CustSystemMessage.Text = message;
        }

        public void SetStoreSystemMessage(string message)
        {
            if (message.Contains("ERROR:"))
            {
                lbl_StoreSystemMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lbl_StoreSystemMessage.ForeColor = System.Drawing.Color.Black;
            }
            lbl_StoreSystemMessage.Text = message;
        }

        // Clears all textfields preventively. 
        private void ClearTextFields(object sender, EventArgs e)
        {
            tb_CustMail.Clear();
            tb_CustName.Clear();
            tb_CustPhone.Clear();
            tb_CustPassword.Clear();
        }

        // Used when GUI is initiated and when updated. Sets content of tables.
        public void UpdateTableContent()
        {
            dgv_Stores.Rows.Clear();
            dgv_Customers.Rows.Clear();
            dgv_Offers.Rows.Clear();

            foreach (Store store in storeController.GetAllStores())
            {
                dgv_Stores.Rows.Add(store.ID, store.Name, store.Address, store.Created_at.ToString());
            }

            foreach (Customer customer in customerController.GetAllCustomers())
            {
                dgv_Customers.Rows.Add(customer.ID, customer.Name, customer.Email, customer.Phone, customer.Created_at.ToString());
            }

            foreach (Offer offer in offerController.GetAllOffers())
            {
                dgv_Offers.Rows.Add(offer.ID, offer.Name, offer.Description, offer.Store.Name, offer.Created_at.ToString());
            }
        }


    }
}