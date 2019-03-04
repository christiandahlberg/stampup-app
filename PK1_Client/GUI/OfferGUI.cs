using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PK1_Client.Controller;
using Resources.Models;

namespace PK1_Client.GUI

{
    public partial class OfferGUI : Form
    {
        private Store store;
        private OfferController offerController;
        private AdminGUI main;

        public OfferGUI(Store s, AdminGUI gui)
        {
            InitializeComponent();
            store = s;
            main = gui;
            SetStoreLabel();
            ActiveControl = tb_OfferName;
            offerController = new OfferController();
        }

        // CREATE OFFER
        private void CreateOffer(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_OfferName.Text))
            {
                SetSystemMessage("ERROR: Please enter a name.");
            }
            if (string.IsNullOrWhiteSpace(tb_Description.Text))
            {
                SetSystemMessage("ERROR: Please write a description.");
            }
            if (trackBar_Stamps.Value == 0)
            {
                SetSystemMessage("ERROR: Please set a stamp goal.");
            }
            else
            {
                if (offerController.CreateOffer(tb_OfferName.Text, tb_Description.Text, store, trackBar_Stamps.Value))
                {
                    Hide();
                    main.SetStoreSystemMessage("Offer was successfully created.");
                    main.UpdateTableContent();
                    ClearTextFields();
                }
                else
                {
                    SetSystemMessage("ERROR: Failed to create offer.");
                }
            }



        }

        // ---------------------------------------------------------------------------
        // ------------------------------- MISC --------------------------------------
        // ---------------------------------------------------------------------------

        // Adjusts counter depending on trackbar value
        private void SetCounterLabel(object sender, EventArgs e)
        {
            trackBar_Counter.Text = trackBar_Stamps.Value.ToString();
        }

        // Sets store when OfferGUI initiates.
        private void SetStoreLabel()
        {
            lbl_OfferStore.Text = store.Name;
        }

        // Sets system message depending on error or not.
        private void SetSystemMessage(string message)
        {
            if (message.Contains("ERROR:"))
            {
                lbl_OfferSystemMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lbl_OfferSystemMessage.ForeColor = System.Drawing.Color.Black;
            }
            lbl_OfferSystemMessage.Text = message;
        }

        private void ClearTextFields()
        {
            tb_Description.Clear();
            tb_OfferName.Clear();
            trackBar_Stamps.Value = 0;
        }
    }
}
