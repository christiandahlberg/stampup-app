using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WS2_WindowsForms_Client.ServiceReference;


namespace WS2_WindowsForms_Client
{
    public partial class WS2_WindowsForms_Client_GUI : Form
    {
        private WS2_WindowsForms_Client.ServiceReference.GetEntitiesSoapClient proxy;


        public WS2_WindowsForms_Client_GUI()
        {
            InitializeComponent();
            proxy = new WS2_WindowsForms_Client.ServiceReference.GetEntitiesSoapClient();
        }

        private void ClearTable()
        {
            dgv_table.Columns.Clear();
            dgv_table.Rows.Clear();
        }

        private void btn_GetAllStores_Click(object sender, EventArgs e)
        {
            ClearTable();

            dgv_table.Columns.Add(" ", "ID");
            dgv_table.Columns.Add(" ", "Name");
            dgv_table.Columns.Add(" ", "Address");
            dgv_table.Columns.Add(" ", "Created at");

            foreach (Store store in proxy.GetStores())
            {
                dgv_table.Rows.Add(store.ID, store.Name, store.Address, store.Created_at);
            }
            dgv_table.ClearSelection();
        }

        private void btn_GetAllCustomers_Click(object sender, EventArgs e)
        {
            ClearTable();

            dgv_table.Columns.Add(" ", "ID");
            dgv_table.Columns.Add(" ", "Name");
            dgv_table.Columns.Add(" ", "Email");
            dgv_table.Columns.Add(" ", "Phone");

            foreach (Customer customer in proxy.GetCustomers())
            {
                dgv_table.Rows.Add(customer.ID, customer.Name, customer.Email, customer.Phone);
            }
            dgv_table.ClearSelection();
        }

        private void btn_GetAllOffers_Click(object sender, EventArgs e)
        {
            ClearTable();

            dgv_table.Columns.Add(" ", "ID");
            dgv_table.Columns.Add(" ", "Name");
            dgv_table.Columns.Add(" ", "Description");
            dgv_table.Columns.Add(" ", "Stampgoal");
            dgv_table.Columns.Add(" ", "Store-id");
            dgv_table.Columns.Add(" ", "Created at");

            foreach (Offer offers in proxy.GetOffers())
            {
                dgv_table.Rows.Add(offers.ID, offers.Name, offers.Description, offers.StampGoal, offers.Store.Name, offers.Created_at);
            }
            dgv_table.ClearSelection();
        }

        private void btn_GetAllSubscriptions_Click(object sender, EventArgs e)
        {
            ClearTable();

            dgv_table.Columns.Add(" ", "Customer ID");
            dgv_table.Columns.Add(" ", "Offer ID");
            dgv_table.Columns.Add(" ", "Stamps attained");
            dgv_table.Columns.Add(" ", "Created at");

            foreach (Subscription subscription in proxy.GetSubscriptions())
            {
                dgv_table.Rows.Add(subscription.customer_Id, subscription.offer_Id, subscription.stamps_attained, subscription.created_at);
            }
            dgv_table.ClearSelection();
        }
    }
}