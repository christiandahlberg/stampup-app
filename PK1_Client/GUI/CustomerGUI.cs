using PK1_Client.Controller;
using PK1_Client.GUI;
using PK1_Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PK1_Client
{
    public partial class CustomerGUI : Form
    {
        private CustomerController customerController;
        private StoreController storeController;
        private OfferController offerController;
        private Customer user;

        public CustomerGUI(Customer user)
        {
            InitializeComponent();
            this.user = user;
            Text = $"Stämpelkortify (Logged in as {user.Name})";

            customerController = new CustomerController();
            storeController = new StoreController();
            offerController = new OfferController();

            UpdateTableContent();
        }


        private void CustomerLogOut(object sender, EventArgs e)
        {
            // Byter bara till LoginGUI
            // TODO: Logga ut på riktigt? Någon funktionalitet som saknas?
            Hide();
            var login = new LoginGUI();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void UpdateTableContent()
        {
            // Sets name to logged in user. un-comment when fixed LoginGUI
            Text = $"Stämpelkortify (Logged in as: {user.Name})";

            // Fills table with all stores.
            foreach (Store store in storeController.GetAllStores())
            {
                dgv_CustStores.Rows.Add(store.ID, store.Name, store.Address, store.Created_at.ToString());
            }

            // Remove default selection on tables (funkar inte)
            dgv_CustStores.ClearSelection();
        }

        // Shows available offers for selected store.
        private void ShowSubscriptions(object sender, DataGridViewCellEventArgs e)
        {
            // Clear table before appending and closes details panel
            dgv_Offers.Rows.Clear();
            panel_Subscriptions.Visible = false;

            List<Offer> store_offers = offerController.GetOffersByStoreId((int)dgv_CustStores.Rows[e.RowIndex].Cells[0].Value);
            foreach (Offer o in store_offers)
            {
                dgv_Offers.Rows.Add(o.ID, o.Name, o.Store.Name, o.Store.ID);
            }

            // Remove default selection on tables (FUNKAR!)
            dgv_Offers.ClearSelection();
        }

        // Event raised when pressing a row from Offers table, showing details.
        private void ShowOfferProgress(object sender, DataGridViewCellEventArgs e)
        {
            // Selected row from Offers table
            DataGridViewRow selected_offer = dgv_Offers.Rows[e.RowIndex];
            bool hasOffer = false;

            foreach (Offer o in offerController.GetCustomerOffers(user.ID, (int)selected_offer.Cells[3].Value))
            {
                if (o.ID == (int)selected_offer.Cells[0].Value)
                {
                    panel_Subscriptions.Visible = true;
                    hasOffer = true;
                    int stamps_attained = customerController.GetStampsAttained(user.ID, o.ID);

                    // Set labels based on store and subscription
                    lbl_PanelStoreName.Text = storeController.GetStoreById((int)selected_offer.Cells[3].Value).Name;
                    lbl_PanelOfferName.Text = o.Name;
                    lbl_PanelDescriptionText.Text = o.Description;

                    if (stamps_attained == o.StampGoal)
                    {
                        lbl_PanelProgressNumber.Text = "Goal reached! Go get your offer.";
                    }
                    else
                    {
                        lbl_PanelProgressNumber.Text = $"Current progress: {stamps_attained} of {o.StampGoal}.";
                    }

                    // Set progressbar to correct value
                    progressBar_Stamps.Maximum = o.StampGoal;
                    progressBar_Stamps.Value = stamps_attained;
                }
            }
            if (!hasOffer)
            {
                panel_Subscriptions.Visible = false;

            }

        }
    }
}