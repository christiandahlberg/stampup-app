namespace PK1_Client
{
    partial class CustomerGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CustomerLogout = new System.Windows.Forms.Button();
            this.lbl_CustAvailableStores = new System.Windows.Forms.Label();
            this.lbl_Subscriptions = new System.Windows.Forms.Label();
            this.dgv_CustStores = new System.Windows.Forms.DataGridView();
            this.c_StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_StoreAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar_Stamps = new System.Windows.Forms.ProgressBar();
            this.panel_Subscriptions = new System.Windows.Forms.Panel();
            this.lbl_PanelProgressNumber = new System.Windows.Forms.Label();
            this.lbl_PanelProgress = new System.Windows.Forms.Label();
            this.lbl_PanelDescriptionText = new System.Windows.Forms.Label();
            this.lbl_PanelOfferName = new System.Windows.Forms.Label();
            this.lbl_PanelDescription = new System.Windows.Forms.Label();
            this.lbl_PanelOffer = new System.Windows.Forms.Label();
            this.lbl_PanelStoreName = new System.Windows.Forms.Label();
            this.lbl_PanelStore = new System.Windows.Forms.Label();
            this.dgv_Offers = new System.Windows.Forms.DataGridView();
            this.c_OfferID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_OfferName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_OfferCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_CustomerStoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_CustomerOffers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustStores)).BeginInit();
            this.panel_Subscriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Offers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CustomerLogout
            // 
            this.btn_CustomerLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CustomerLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_CustomerLogout.FlatAppearance.BorderSize = 0;
            this.btn_CustomerLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CustomerLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerLogout.ForeColor = System.Drawing.Color.White;
            this.btn_CustomerLogout.Location = new System.Drawing.Point(452, 330);
            this.btn_CustomerLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CustomerLogout.Name = "btn_CustomerLogout";
            this.btn_CustomerLogout.Size = new System.Drawing.Size(119, 28);
            this.btn_CustomerLogout.TabIndex = 0;
            this.btn_CustomerLogout.TabStop = false;
            this.btn_CustomerLogout.Text = "LOG OUT";
            this.btn_CustomerLogout.UseVisualStyleBackColor = true;
            this.btn_CustomerLogout.Click += new System.EventHandler(this.CustomerLogOut);
            // 
            // lbl_CustAvailableStores
            // 
            this.lbl_CustAvailableStores.AutoSize = true;
            this.lbl_CustAvailableStores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustAvailableStores.Location = new System.Drawing.Point(14, 21);
            this.lbl_CustAvailableStores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CustAvailableStores.Name = "lbl_CustAvailableStores";
            this.lbl_CustAvailableStores.Size = new System.Drawing.Size(43, 13);
            this.lbl_CustAvailableStores.TabIndex = 3;
            this.lbl_CustAvailableStores.Text = "Stores";
            // 
            // lbl_Subscriptions
            // 
            this.lbl_Subscriptions.AutoSize = true;
            this.lbl_Subscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subscriptions.Location = new System.Drawing.Point(20, 11);
            this.lbl_Subscriptions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Subscriptions.Name = "lbl_Subscriptions";
            this.lbl_Subscriptions.Size = new System.Drawing.Size(77, 13);
            this.lbl_Subscriptions.TabIndex = 4;
            this.lbl_Subscriptions.Text = "Subscription";
            // 
            // dgv_CustStores
            // 
            this.dgv_CustStores.AllowUserToAddRows = false;
            this.dgv_CustStores.AllowUserToDeleteRows = false;
            this.dgv_CustStores.AllowUserToResizeRows = false;
            this.dgv_CustStores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CustStores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_CustStores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_CustStores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_CustStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustStores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_StoreID,
            this.c_StoreName,
            this.c_StoreAddress});
            this.dgv_CustStores.Location = new System.Drawing.Point(16, 49);
            this.dgv_CustStores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_CustStores.Name = "dgv_CustStores";
            this.dgv_CustStores.ReadOnly = true;
            this.dgv_CustStores.RowHeadersVisible = false;
            this.dgv_CustStores.RowTemplate.DividerHeight = 2;
            this.dgv_CustStores.RowTemplate.Height = 24;
            this.dgv_CustStores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CustStores.Size = new System.Drawing.Size(242, 164);
            this.dgv_CustStores.TabIndex = 6;
            this.dgv_CustStores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowSubscriptions);
            // 
            // c_StoreID
            // 
            this.c_StoreID.FillWeight = 40F;
            this.c_StoreID.HeaderText = "ID";
            this.c_StoreID.Name = "c_StoreID";
            this.c_StoreID.ReadOnly = true;
            // 
            // c_StoreName
            // 
            this.c_StoreName.FillWeight = 70F;
            this.c_StoreName.HeaderText = "Name";
            this.c_StoreName.Name = "c_StoreName";
            this.c_StoreName.ReadOnly = true;
            // 
            // c_StoreAddress
            // 
            this.c_StoreAddress.HeaderText = "Address";
            this.c_StoreAddress.Name = "c_StoreAddress";
            this.c_StoreAddress.ReadOnly = true;
            // 
            // progressBar_Stamps
            // 
            this.progressBar_Stamps.Location = new System.Drawing.Point(214, 43);
            this.progressBar_Stamps.Maximum = 10;
            this.progressBar_Stamps.Name = "progressBar_Stamps";
            this.progressBar_Stamps.Size = new System.Drawing.Size(197, 35);
            this.progressBar_Stamps.TabIndex = 7;
            // 
            // panel_Subscriptions
            // 
            this.panel_Subscriptions.Controls.Add(this.lbl_PanelProgressNumber);
            this.panel_Subscriptions.Controls.Add(this.lbl_PanelProgress);
            this.panel_Subscriptions.Controls.Add(this.lbl_PanelDescriptionText);
            this.panel_Subscriptions.Controls.Add(this.lbl_PanelOfferName);
            this.panel_Subscriptions.Controls.Add(this.lbl_PanelDescription);
            this.panel_Subscriptions.Controls.Add(this.lbl_Subscriptions);
            this.panel_Subscriptions.Controls.Add(this.lbl_PanelOffer);
            this.panel_Subscriptions.Controls.Add(this.lbl_PanelStoreName);
            this.panel_Subscriptions.Controls.Add(this.lbl_PanelStore);
            this.panel_Subscriptions.Controls.Add(this.progressBar_Stamps);
            this.panel_Subscriptions.Location = new System.Drawing.Point(-5, 218);
            this.panel_Subscriptions.Name = "panel_Subscriptions";
            this.panel_Subscriptions.Size = new System.Drawing.Size(452, 153);
            this.panel_Subscriptions.TabIndex = 8;
            this.panel_Subscriptions.Visible = false;
            // 
            // lbl_PanelProgressNumber
            // 
            this.lbl_PanelProgressNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PanelProgressNumber.Location = new System.Drawing.Point(285, 11);
            this.lbl_PanelProgressNumber.Name = "lbl_PanelProgressNumber";
            this.lbl_PanelProgressNumber.Size = new System.Drawing.Size(161, 23);
            this.lbl_PanelProgressNumber.TabIndex = 17;
            // 
            // lbl_PanelProgress
            // 
            this.lbl_PanelProgress.AutoSize = true;
            this.lbl_PanelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PanelProgress.Location = new System.Drawing.Point(211, 11);
            this.lbl_PanelProgress.Name = "lbl_PanelProgress";
            this.lbl_PanelProgress.Size = new System.Drawing.Size(56, 13);
            this.lbl_PanelProgress.TabIndex = 16;
            this.lbl_PanelProgress.Text = "Progress";
            // 
            // lbl_PanelDescriptionText
            // 
            this.lbl_PanelDescriptionText.Location = new System.Drawing.Point(100, 98);
            this.lbl_PanelDescriptionText.Name = "lbl_PanelDescriptionText";
            this.lbl_PanelDescriptionText.Size = new System.Drawing.Size(311, 32);
            this.lbl_PanelDescriptionText.TabIndex = 13;
            this.lbl_PanelDescriptionText.Text = "Köp nio sallader och få den tionde gratis! Pangdeal! Bara hos Grönt och Gott.";
            this.lbl_PanelDescriptionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PanelOfferName
            // 
            this.lbl_PanelOfferName.AutoSize = true;
            this.lbl_PanelOfferName.Location = new System.Drawing.Point(100, 75);
            this.lbl_PanelOfferName.Name = "lbl_PanelOfferName";
            this.lbl_PanelOfferName.Size = new System.Drawing.Size(48, 13);
            this.lbl_PanelOfferName.TabIndex = 12;
            this.lbl_PanelOfferName.Text = "Klippkort";
            // 
            // lbl_PanelDescription
            // 
            this.lbl_PanelDescription.AutoSize = true;
            this.lbl_PanelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PanelDescription.Location = new System.Drawing.Point(19, 108);
            this.lbl_PanelDescription.Name = "lbl_PanelDescription";
            this.lbl_PanelDescription.Size = new System.Drawing.Size(71, 13);
            this.lbl_PanelDescription.TabIndex = 11;
            this.lbl_PanelDescription.Text = "Description";
            // 
            // lbl_PanelOffer
            // 
            this.lbl_PanelOffer.AutoSize = true;
            this.lbl_PanelOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PanelOffer.Location = new System.Drawing.Point(19, 75);
            this.lbl_PanelOffer.Name = "lbl_PanelOffer";
            this.lbl_PanelOffer.Size = new System.Drawing.Size(35, 13);
            this.lbl_PanelOffer.TabIndex = 10;
            this.lbl_PanelOffer.Text = "Offer";
            // 
            // lbl_PanelStoreName
            // 
            this.lbl_PanelStoreName.AutoSize = true;
            this.lbl_PanelStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PanelStoreName.Location = new System.Drawing.Point(97, 43);
            this.lbl_PanelStoreName.Name = "lbl_PanelStoreName";
            this.lbl_PanelStoreName.Size = new System.Drawing.Size(77, 13);
            this.lbl_PanelStoreName.TabIndex = 9;
            this.lbl_PanelStoreName.Text = "Grönt och Gott";
            // 
            // lbl_PanelStore
            // 
            this.lbl_PanelStore.AutoSize = true;
            this.lbl_PanelStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PanelStore.Location = new System.Drawing.Point(19, 43);
            this.lbl_PanelStore.Name = "lbl_PanelStore";
            this.lbl_PanelStore.Size = new System.Drawing.Size(37, 13);
            this.lbl_PanelStore.TabIndex = 8;
            this.lbl_PanelStore.Text = "Store";
            // 
            // dgv_Offers
            // 
            this.dgv_Offers.AllowUserToAddRows = false;
            this.dgv_Offers.AllowUserToDeleteRows = false;
            this.dgv_Offers.AllowUserToResizeRows = false;
            this.dgv_Offers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Offers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Offers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Offers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Offers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Offers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_OfferID,
            this.c_OfferName,
            this.c_OfferCreated,
            this.c_CustomerStoreId});
            this.dgv_Offers.Location = new System.Drawing.Point(278, 49);
            this.dgv_Offers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Offers.Name = "dgv_Offers";
            this.dgv_Offers.ReadOnly = true;
            this.dgv_Offers.RowHeadersVisible = false;
            this.dgv_Offers.RowTemplate.DividerHeight = 2;
            this.dgv_Offers.RowTemplate.Height = 24;
            this.dgv_Offers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Offers.Size = new System.Drawing.Size(303, 164);
            this.dgv_Offers.TabIndex = 9;
            this.dgv_Offers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowOfferProgress);
            // 
            // c_OfferID
            // 
            this.c_OfferID.FillWeight = 40F;
            this.c_OfferID.HeaderText = "ID";
            this.c_OfferID.Name = "c_OfferID";
            this.c_OfferID.ReadOnly = true;
            this.c_OfferID.Visible = false;
            // 
            // c_OfferName
            // 
            this.c_OfferName.FillWeight = 80F;
            this.c_OfferName.HeaderText = "Name";
            this.c_OfferName.Name = "c_OfferName";
            this.c_OfferName.ReadOnly = true;
            // 
            // c_OfferCreated
            // 
            this.c_OfferCreated.HeaderText = "Store";
            this.c_OfferCreated.Name = "c_OfferCreated";
            this.c_OfferCreated.ReadOnly = true;
            // 
            // c_CustomerStoreId
            // 
            this.c_CustomerStoreId.FillWeight = 80F;
            this.c_CustomerStoreId.HeaderText = "Store ID";
            this.c_CustomerStoreId.Name = "c_CustomerStoreId";
            this.c_CustomerStoreId.ReadOnly = true;
            this.c_CustomerStoreId.Visible = false;
            // 
            // lbl_CustomerOffers
            // 
            this.lbl_CustomerOffers.AutoSize = true;
            this.lbl_CustomerOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerOffers.Location = new System.Drawing.Point(278, 21);
            this.lbl_CustomerOffers.Name = "lbl_CustomerOffers";
            this.lbl_CustomerOffers.Size = new System.Drawing.Size(41, 13);
            this.lbl_CustomerOffers.TabIndex = 10;
            this.lbl_CustomerOffers.Text = "Offers";
            // 
            // CustomerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.Controls.Add(this.btn_CustomerLogout);
            this.Controls.Add(this.lbl_CustomerOffers);
            this.Controls.Add(this.dgv_Offers);
            this.Controls.Add(this.panel_Subscriptions);
            this.Controls.Add(this.dgv_CustStores);
            this.Controls.Add(this.lbl_CustAvailableStores);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerGUI";
            this.Text = "Stämpelkortify";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustStores)).EndInit();
            this.panel_Subscriptions.ResumeLayout(false);
            this.panel_Subscriptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Offers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_CustomerLogout;
        private System.Windows.Forms.Label lbl_CustAvailableStores;
        private System.Windows.Forms.Label lbl_Subscriptions;
        private System.Windows.Forms.DataGridView dgv_CustStores;
        private System.Windows.Forms.ProgressBar progressBar_Stamps;
        private System.Windows.Forms.Panel panel_Subscriptions;
        private System.Windows.Forms.Label lbl_PanelStore;
        private System.Windows.Forms.Label lbl_PanelStoreName;
        private System.Windows.Forms.Label lbl_PanelDescription;
        private System.Windows.Forms.Label lbl_PanelOffer;
        private System.Windows.Forms.Label lbl_PanelDescriptionText;
        private System.Windows.Forms.Label lbl_PanelOfferName;
        private System.Windows.Forms.Label lbl_PanelProgress;
        private System.Windows.Forms.DataGridView dgv_Offers;
        private System.Windows.Forms.Label lbl_CustomerOffers;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_StoreAddress;
        private System.Windows.Forms.Label lbl_PanelProgressNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_OfferID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_OfferName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_OfferCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_CustomerStoreId;
    }
}