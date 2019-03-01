namespace PK1_Client
{
    partial class AdminGUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.customersPage = new System.Windows.Forms.TabPage();
            this.btn_ClearTB = new System.Windows.Forms.Button();
            this.tb_CustPassword = new System.Windows.Forms.TextBox();
            this.lbl_CustPassword = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_CustSystemMessage = new System.Windows.Forms.Label();
            this.tb_CustPhone = new System.Windows.Forms.TextBox();
            this.tb_CustMail = new System.Windows.Forms.TextBox();
            this.tb_CustName = new System.Windows.Forms.TextBox();
            this.lbl_CustPhone = new System.Windows.Forms.Label();
            this.lbl_CustMail = new System.Windows.Forms.Label();
            this.lbl_CustName = new System.Windows.Forms.Label();
            this.btn_CustDelete = new System.Windows.Forms.Button();
            this.btn_CustUpdate = new System.Windows.Forms.Button();
            this.btn_CustCreate = new System.Windows.Forms.Button();
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.c_CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_CustMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_CustPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_CustTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storesPage = new System.Windows.Forms.TabPage();
            this.btn_Subscriptions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Offers = new System.Windows.Forms.Panel();
            this.tb_offerStampGoal = new System.Windows.Forms.TextBox();
            this.lbl_StampGoal = new System.Windows.Forms.Label();
            this.tb_offerDesc = new System.Windows.Forms.TextBox();
            this.tb_offerName = new System.Windows.Forms.TextBox();
            this.lbl_OfferDesc = new System.Windows.Forms.Label();
            this.lbl_OfferName = new System.Windows.Forms.Label();
            this.panel_Stores = new System.Windows.Forms.Panel();
            this.tb_StoreAddress = new System.Windows.Forms.TextBox();
            this.tb_StoreName = new System.Windows.Forms.TextBox();
            this.lbl_StoreAddress = new System.Windows.Forms.Label();
            this.lbl_StoreName = new System.Windows.Forms.Label();
            this.lbl_StoreSystemMessage = new System.Windows.Forms.Label();
            this.lbl_StoresSubsNumber = new System.Windows.Forms.Label();
            this.lbl_Offer = new System.Windows.Forms.Label();
            this.lbl_Stores = new System.Windows.Forms.Label();
            this.btn_AddOffer = new System.Windows.Forms.Button();
            this.btn_StoreOfferDelete = new System.Windows.Forms.Button();
            this.btn_StoreOfferUpdate = new System.Windows.Forms.Button();
            this.btn_Logout2 = new System.Windows.Forms.Button();
            this.dgv_Offers = new System.Windows.Forms.DataGridView();
            this.c_OfferID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_OfferName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_OfferDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_OfferStoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_OfferCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_StoreCreate = new System.Windows.Forms.Button();
            this.dgv_Stores = new System.Windows.Forms.DataGridView();
            this.c_StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_StoreAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_StoreCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.customersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            this.storesPage.SuspendLayout();
            this.panel_Offers.SuspendLayout();
            this.panel_Stores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Offers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.customersPage);
            this.tabControl1.Controls.Add(this.storesPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 621);
            this.tabControl1.TabIndex = 0;
            // 
            // customersPage
            // 
            this.customersPage.Controls.Add(this.btn_ClearTB);
            this.customersPage.Controls.Add(this.tb_CustPassword);
            this.customersPage.Controls.Add(this.lbl_CustPassword);
            this.customersPage.Controls.Add(this.btn_Logout);
            this.customersPage.Controls.Add(this.lbl_CustSystemMessage);
            this.customersPage.Controls.Add(this.tb_CustPhone);
            this.customersPage.Controls.Add(this.tb_CustMail);
            this.customersPage.Controls.Add(this.tb_CustName);
            this.customersPage.Controls.Add(this.lbl_CustPhone);
            this.customersPage.Controls.Add(this.lbl_CustMail);
            this.customersPage.Controls.Add(this.lbl_CustName);
            this.customersPage.Controls.Add(this.btn_CustDelete);
            this.customersPage.Controls.Add(this.btn_CustUpdate);
            this.customersPage.Controls.Add(this.btn_CustCreate);
            this.customersPage.Controls.Add(this.dgv_Customers);
            this.customersPage.Location = new System.Drawing.Point(4, 34);
            this.customersPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersPage.Name = "customersPage";
            this.customersPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersPage.Size = new System.Drawing.Size(788, 583);
            this.customersPage.TabIndex = 0;
            this.customersPage.Text = "   Customers   ";
            this.customersPage.UseVisualStyleBackColor = true;
            // 
            // btn_ClearTB
            // 
            this.btn_ClearTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ClearTB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ClearTB.FlatAppearance.BorderSize = 0;
            this.btn_ClearTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearTB.ForeColor = System.Drawing.Color.White;
            this.btn_ClearTB.Location = new System.Drawing.Point(553, 196);
            this.btn_ClearTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ClearTB.Name = "btn_ClearTB";
            this.btn_ClearTB.Size = new System.Drawing.Size(209, 31);
            this.btn_ClearTB.TabIndex = 10;
            this.btn_ClearTB.TabStop = false;
            this.btn_ClearTB.Text = "Clear text fields";
            this.btn_ClearTB.UseVisualStyleBackColor = false;
            this.btn_ClearTB.Click += new System.EventHandler(this.ClearTextFields);
            // 
            // tb_CustPassword
            // 
            this.tb_CustPassword.Location = new System.Drawing.Point(619, 151);
            this.tb_CustPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CustPassword.Name = "tb_CustPassword";
            this.tb_CustPassword.PasswordChar = '*';
            this.tb_CustPassword.Size = new System.Drawing.Size(143, 22);
            this.tb_CustPassword.TabIndex = 9;
            // 
            // lbl_CustPassword
            // 
            this.lbl_CustPassword.AutoSize = true;
            this.lbl_CustPassword.Location = new System.Drawing.Point(551, 154);
            this.lbl_CustPassword.Name = "lbl_CustPassword";
            this.lbl_CustPassword.Size = new System.Drawing.Size(53, 17);
            this.lbl_CustPassword.TabIndex = 8;
            this.lbl_CustPassword.Text = "Passw";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(553, 532);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(209, 31);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.TabStop = false;
            this.btn_Logout.Text = "LOG OUT";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.AdminLogout);
            // 
            // lbl_CustSystemMessage
            // 
            this.lbl_CustSystemMessage.AutoSize = true;
            this.lbl_CustSystemMessage.ForeColor = System.Drawing.Color.Black;
            this.lbl_CustSystemMessage.Location = new System.Drawing.Point(24, 543);
            this.lbl_CustSystemMessage.Name = "lbl_CustSystemMessage";
            this.lbl_CustSystemMessage.Size = new System.Drawing.Size(0, 17);
            this.lbl_CustSystemMessage.TabIndex = 7;
            // 
            // tb_CustPhone
            // 
            this.tb_CustPhone.Location = new System.Drawing.Point(619, 111);
            this.tb_CustPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CustPhone.Name = "tb_CustPhone";
            this.tb_CustPhone.Size = new System.Drawing.Size(144, 22);
            this.tb_CustPhone.TabIndex = 6;
            // 
            // tb_CustMail
            // 
            this.tb_CustMail.Location = new System.Drawing.Point(619, 70);
            this.tb_CustMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CustMail.Name = "tb_CustMail";
            this.tb_CustMail.Size = new System.Drawing.Size(144, 22);
            this.tb_CustMail.TabIndex = 5;
            // 
            // tb_CustName
            // 
            this.tb_CustName.Location = new System.Drawing.Point(619, 33);
            this.tb_CustName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CustName.Name = "tb_CustName";
            this.tb_CustName.Size = new System.Drawing.Size(144, 22);
            this.tb_CustName.TabIndex = 4;
            // 
            // lbl_CustPhone
            // 
            this.lbl_CustPhone.AutoSize = true;
            this.lbl_CustPhone.Location = new System.Drawing.Point(551, 114);
            this.lbl_CustPhone.Name = "lbl_CustPhone";
            this.lbl_CustPhone.Size = new System.Drawing.Size(54, 17);
            this.lbl_CustPhone.TabIndex = 3;
            this.lbl_CustPhone.Text = "Phone";
            // 
            // lbl_CustMail
            // 
            this.lbl_CustMail.AutoSize = true;
            this.lbl_CustMail.Location = new System.Drawing.Point(551, 70);
            this.lbl_CustMail.Name = "lbl_CustMail";
            this.lbl_CustMail.Size = new System.Drawing.Size(53, 17);
            this.lbl_CustMail.TabIndex = 2;
            this.lbl_CustMail.Text = "E-mail";
            // 
            // lbl_CustName
            // 
            this.lbl_CustName.AutoSize = true;
            this.lbl_CustName.Location = new System.Drawing.Point(551, 36);
            this.lbl_CustName.Name = "lbl_CustName";
            this.lbl_CustName.Size = new System.Drawing.Size(49, 17);
            this.lbl_CustName.TabIndex = 1;
            this.lbl_CustName.Text = "Name";
            // 
            // btn_CustDelete
            // 
            this.btn_CustDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CustDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_CustDelete.FlatAppearance.BorderSize = 0;
            this.btn_CustDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CustDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustDelete.ForeColor = System.Drawing.Color.White;
            this.btn_CustDelete.Location = new System.Drawing.Point(553, 337);
            this.btn_CustDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CustDelete.Name = "btn_CustDelete";
            this.btn_CustDelete.Size = new System.Drawing.Size(209, 31);
            this.btn_CustDelete.TabIndex = 0;
            this.btn_CustDelete.TabStop = false;
            this.btn_CustDelete.Text = "Delete";
            this.btn_CustDelete.UseVisualStyleBackColor = false;
            this.btn_CustDelete.Click += new System.EventHandler(this.CustomerDelete);
            // 
            // btn_CustUpdate
            // 
            this.btn_CustUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CustUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_CustUpdate.FlatAppearance.BorderSize = 0;
            this.btn_CustUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CustUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustUpdate.ForeColor = System.Drawing.Color.White;
            this.btn_CustUpdate.Location = new System.Drawing.Point(553, 290);
            this.btn_CustUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CustUpdate.Name = "btn_CustUpdate";
            this.btn_CustUpdate.Size = new System.Drawing.Size(209, 31);
            this.btn_CustUpdate.TabIndex = 0;
            this.btn_CustUpdate.TabStop = false;
            this.btn_CustUpdate.Text = "Update";
            this.btn_CustUpdate.UseVisualStyleBackColor = false;
            this.btn_CustUpdate.Click += new System.EventHandler(this.CustomerUpdate);
            // 
            // btn_CustCreate
            // 
            this.btn_CustCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CustCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_CustCreate.FlatAppearance.BorderSize = 0;
            this.btn_CustCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CustCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustCreate.ForeColor = System.Drawing.Color.White;
            this.btn_CustCreate.Location = new System.Drawing.Point(553, 244);
            this.btn_CustCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CustCreate.Name = "btn_CustCreate";
            this.btn_CustCreate.Size = new System.Drawing.Size(209, 31);
            this.btn_CustCreate.TabIndex = 0;
            this.btn_CustCreate.TabStop = false;
            this.btn_CustCreate.Text = "Create";
            this.btn_CustCreate.UseVisualStyleBackColor = false;
            this.btn_CustCreate.Click += new System.EventHandler(this.CustomerCreate);
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.AllowUserToAddRows = false;
            this.dgv_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Customers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_CustID,
            this.c_CustName,
            this.c_CustMail,
            this.c_CustPhone,
            this.c_CustTime});
            this.dgv_Customers.Location = new System.Drawing.Point(27, 34);
            this.dgv_Customers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.ReadOnly = true;
            this.dgv_Customers.RowHeadersVisible = false;
            this.dgv_Customers.RowTemplate.Height = 24;
            this.dgv_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Customers.Size = new System.Drawing.Size(491, 474);
            this.dgv_Customers.TabIndex = 0;
            this.dgv_Customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerSelectedRowDataHandler);
            // 
            // c_CustID
            // 
            this.c_CustID.FillWeight = 40F;
            this.c_CustID.HeaderText = "ID";
            this.c_CustID.Name = "c_CustID";
            this.c_CustID.ReadOnly = true;
            // 
            // c_CustName
            // 
            this.c_CustName.HeaderText = "Name";
            this.c_CustName.Name = "c_CustName";
            this.c_CustName.ReadOnly = true;
            // 
            // c_CustMail
            // 
            this.c_CustMail.HeaderText = "E-mail";
            this.c_CustMail.Name = "c_CustMail";
            this.c_CustMail.ReadOnly = true;
            // 
            // c_CustPhone
            // 
            this.c_CustPhone.HeaderText = "Phone";
            this.c_CustPhone.Name = "c_CustPhone";
            this.c_CustPhone.ReadOnly = true;
            // 
            // c_CustTime
            // 
            this.c_CustTime.HeaderText = "Registered";
            this.c_CustTime.Name = "c_CustTime";
            this.c_CustTime.ReadOnly = true;
            // 
            // storesPage
            // 
            this.storesPage.Controls.Add(this.btn_Subscriptions);
            this.storesPage.Controls.Add(this.label1);
            this.storesPage.Controls.Add(this.panel_Offers);
            this.storesPage.Controls.Add(this.panel_Stores);
            this.storesPage.Controls.Add(this.lbl_StoreSystemMessage);
            this.storesPage.Controls.Add(this.lbl_StoresSubsNumber);
            this.storesPage.Controls.Add(this.lbl_Offer);
            this.storesPage.Controls.Add(this.lbl_Stores);
            this.storesPage.Controls.Add(this.btn_AddOffer);
            this.storesPage.Controls.Add(this.btn_StoreOfferDelete);
            this.storesPage.Controls.Add(this.btn_StoreOfferUpdate);
            this.storesPage.Controls.Add(this.btn_Logout2);
            this.storesPage.Controls.Add(this.dgv_Offers);
            this.storesPage.Controls.Add(this.btn_StoreCreate);
            this.storesPage.Controls.Add(this.dgv_Stores);
            this.storesPage.Location = new System.Drawing.Point(4, 34);
            this.storesPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.storesPage.Name = "storesPage";
            this.storesPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.storesPage.Size = new System.Drawing.Size(788, 583);
            this.storesPage.TabIndex = 1;
            this.storesPage.Text = "   Stores   ";
            this.storesPage.UseVisualStyleBackColor = true;
            // 
            // btn_Subscriptions
            // 
            this.btn_Subscriptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Subscriptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Subscriptions.FlatAppearance.BorderSize = 0;
            this.btn_Subscriptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Subscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subscriptions.ForeColor = System.Drawing.Color.White;
            this.btn_Subscriptions.Location = new System.Drawing.Point(172, 533);
            this.btn_Subscriptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Subscriptions.Name = "btn_Subscriptions";
            this.btn_Subscriptions.Size = new System.Drawing.Size(229, 31);
            this.btn_Subscriptions.TabIndex = 0;
            this.btn_Subscriptions.TabStop = false;
            this.btn_Subscriptions.Text = "Manage Subscriptions";
            this.btn_Subscriptions.UseVisualStyleBackColor = true;
            this.btn_Subscriptions.Click += new System.EventHandler(this.manageSubscriptions_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(532, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 3);
            this.label1.TabIndex = 13;
            // 
            // panel_Offers
            // 
            this.panel_Offers.Controls.Add(this.tb_offerStampGoal);
            this.panel_Offers.Controls.Add(this.lbl_StampGoal);
            this.panel_Offers.Controls.Add(this.tb_offerDesc);
            this.panel_Offers.Controls.Add(this.tb_offerName);
            this.panel_Offers.Controls.Add(this.lbl_OfferDesc);
            this.panel_Offers.Controls.Add(this.lbl_OfferName);
            this.panel_Offers.Location = new System.Drawing.Point(528, 29);
            this.panel_Offers.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Offers.Name = "panel_Offers";
            this.panel_Offers.Size = new System.Drawing.Size(253, 226);
            this.panel_Offers.TabIndex = 12;
            this.panel_Offers.Visible = false;
            // 
            // tb_offerStampGoal
            // 
            this.tb_offerStampGoal.Location = new System.Drawing.Point(97, 202);
            this.tb_offerStampGoal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_offerStampGoal.Name = "tb_offerStampGoal";
            this.tb_offerStampGoal.Size = new System.Drawing.Size(137, 22);
            this.tb_offerStampGoal.TabIndex = 8;
            // 
            // lbl_StampGoal
            // 
            this.lbl_StampGoal.AutoSize = true;
            this.lbl_StampGoal.Location = new System.Drawing.Point(3, 205);
            this.lbl_StampGoal.Name = "lbl_StampGoal";
            this.lbl_StampGoal.Size = new System.Drawing.Size(89, 17);
            this.lbl_StampGoal.TabIndex = 7;
            this.lbl_StampGoal.Text = "Stamp goal";
            // 
            // tb_offerDesc
            // 
            this.tb_offerDesc.Location = new System.Drawing.Point(98, 49);
            this.tb_offerDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_offerDesc.Multiline = true;
            this.tb_offerDesc.Name = "tb_offerDesc";
            this.tb_offerDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_offerDesc.Size = new System.Drawing.Size(137, 140);
            this.tb_offerDesc.TabIndex = 6;
            // 
            // tb_offerName
            // 
            this.tb_offerName.Location = new System.Drawing.Point(98, 14);
            this.tb_offerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_offerName.Name = "tb_offerName";
            this.tb_offerName.Size = new System.Drawing.Size(137, 22);
            this.tb_offerName.TabIndex = 5;
            // 
            // lbl_OfferDesc
            // 
            this.lbl_OfferDesc.AutoSize = true;
            this.lbl_OfferDesc.Location = new System.Drawing.Point(4, 52);
            this.lbl_OfferDesc.Name = "lbl_OfferDesc";
            this.lbl_OfferDesc.Size = new System.Drawing.Size(90, 17);
            this.lbl_OfferDesc.TabIndex = 4;
            this.lbl_OfferDesc.Text = "Description";
            // 
            // lbl_OfferName
            // 
            this.lbl_OfferName.AutoSize = true;
            this.lbl_OfferName.Location = new System.Drawing.Point(4, 19);
            this.lbl_OfferName.Name = "lbl_OfferName";
            this.lbl_OfferName.Size = new System.Drawing.Size(49, 17);
            this.lbl_OfferName.TabIndex = 3;
            this.lbl_OfferName.Text = "Name";
            // 
            // panel_Stores
            // 
            this.panel_Stores.Controls.Add(this.tb_StoreAddress);
            this.panel_Stores.Controls.Add(this.tb_StoreName);
            this.panel_Stores.Controls.Add(this.lbl_StoreAddress);
            this.panel_Stores.Controls.Add(this.lbl_StoreName);
            this.panel_Stores.Location = new System.Drawing.Point(528, 29);
            this.panel_Stores.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Stores.Name = "panel_Stores";
            this.panel_Stores.Size = new System.Drawing.Size(253, 102);
            this.panel_Stores.TabIndex = 11;
            this.panel_Stores.Visible = false;
            // 
            // tb_StoreAddress
            // 
            this.tb_StoreAddress.Location = new System.Drawing.Point(98, 49);
            this.tb_StoreAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_StoreAddress.Name = "tb_StoreAddress";
            this.tb_StoreAddress.Size = new System.Drawing.Size(137, 22);
            this.tb_StoreAddress.TabIndex = 6;
            // 
            // tb_StoreName
            // 
            this.tb_StoreName.Location = new System.Drawing.Point(98, 14);
            this.tb_StoreName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_StoreName.Name = "tb_StoreName";
            this.tb_StoreName.Size = new System.Drawing.Size(137, 22);
            this.tb_StoreName.TabIndex = 5;
            // 
            // lbl_StoreAddress
            // 
            this.lbl_StoreAddress.AutoSize = true;
            this.lbl_StoreAddress.Location = new System.Drawing.Point(4, 52);
            this.lbl_StoreAddress.Name = "lbl_StoreAddress";
            this.lbl_StoreAddress.Size = new System.Drawing.Size(67, 17);
            this.lbl_StoreAddress.TabIndex = 4;
            this.lbl_StoreAddress.Text = "Address";
            // 
            // lbl_StoreName
            // 
            this.lbl_StoreName.AutoSize = true;
            this.lbl_StoreName.Location = new System.Drawing.Point(4, 19);
            this.lbl_StoreName.Name = "lbl_StoreName";
            this.lbl_StoreName.Size = new System.Drawing.Size(49, 17);
            this.lbl_StoreName.TabIndex = 3;
            this.lbl_StoreName.Text = "Name";
            // 
            // lbl_StoreSystemMessage
            // 
            this.lbl_StoreSystemMessage.AutoSize = true;
            this.lbl_StoreSystemMessage.ForeColor = System.Drawing.Color.Red;
            this.lbl_StoreSystemMessage.Location = new System.Drawing.Point(166, 271);
            this.lbl_StoreSystemMessage.Name = "lbl_StoreSystemMessage";
            this.lbl_StoreSystemMessage.Size = new System.Drawing.Size(0, 17);
            this.lbl_StoreSystemMessage.TabIndex = 9;
            // 
            // lbl_StoresSubsNumber
            // 
            this.lbl_StoresSubsNumber.AutoSize = true;
            this.lbl_StoresSubsNumber.Location = new System.Drawing.Point(672, 489);
            this.lbl_StoresSubsNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StoresSubsNumber.Name = "lbl_StoresSubsNumber";
            this.lbl_StoresSubsNumber.Size = new System.Drawing.Size(0, 17);
            this.lbl_StoresSubsNumber.TabIndex = 10;
            // 
            // lbl_Offer
            // 
            this.lbl_Offer.AutoSize = true;
            this.lbl_Offer.Location = new System.Drawing.Point(27, 271);
            this.lbl_Offer.Name = "lbl_Offer";
            this.lbl_Offer.Size = new System.Drawing.Size(53, 17);
            this.lbl_Offer.TabIndex = 8;
            this.lbl_Offer.Text = "Offers";
            // 
            // lbl_Stores
            // 
            this.lbl_Stores.AutoSize = true;
            this.lbl_Stores.Location = new System.Drawing.Point(27, 20);
            this.lbl_Stores.Name = "lbl_Stores";
            this.lbl_Stores.Size = new System.Drawing.Size(55, 17);
            this.lbl_Stores.TabIndex = 7;
            this.lbl_Stores.Text = "Stores";
            // 
            // btn_AddOffer
            // 
            this.btn_AddOffer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_AddOffer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_AddOffer.FlatAppearance.BorderSize = 0;
            this.btn_AddOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddOffer.ForeColor = System.Drawing.Color.White;
            this.btn_AddOffer.Location = new System.Drawing.Point(27, 533);
            this.btn_AddOffer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddOffer.Name = "btn_AddOffer";
            this.btn_AddOffer.Size = new System.Drawing.Size(139, 31);
            this.btn_AddOffer.TabIndex = 0;
            this.btn_AddOffer.TabStop = false;
            this.btn_AddOffer.Text = "Add offer...";
            this.btn_AddOffer.UseVisualStyleBackColor = false;
            this.btn_AddOffer.Click += new System.EventHandler(this.AddOfferEvent);
            // 
            // btn_StoreOfferDelete
            // 
            this.btn_StoreOfferDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_StoreOfferDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_StoreOfferDelete.FlatAppearance.BorderSize = 0;
            this.btn_StoreOfferDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StoreOfferDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StoreOfferDelete.ForeColor = System.Drawing.Color.White;
            this.btn_StoreOfferDelete.Location = new System.Drawing.Point(532, 475);
            this.btn_StoreOfferDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_StoreOfferDelete.Name = "btn_StoreOfferDelete";
            this.btn_StoreOfferDelete.Size = new System.Drawing.Size(229, 31);
            this.btn_StoreOfferDelete.TabIndex = 0;
            this.btn_StoreOfferDelete.TabStop = false;
            this.btn_StoreOfferDelete.Text = "Delete";
            this.btn_StoreOfferDelete.UseVisualStyleBackColor = false;
            this.btn_StoreOfferDelete.Click += new System.EventHandler(this.StoreDelete);
            // 
            // btn_StoreOfferUpdate
            // 
            this.btn_StoreOfferUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_StoreOfferUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_StoreOfferUpdate.FlatAppearance.BorderSize = 0;
            this.btn_StoreOfferUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StoreOfferUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StoreOfferUpdate.ForeColor = System.Drawing.Color.White;
            this.btn_StoreOfferUpdate.Location = new System.Drawing.Point(532, 427);
            this.btn_StoreOfferUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_StoreOfferUpdate.Name = "btn_StoreOfferUpdate";
            this.btn_StoreOfferUpdate.Size = new System.Drawing.Size(229, 31);
            this.btn_StoreOfferUpdate.TabIndex = 0;
            this.btn_StoreOfferUpdate.TabStop = false;
            this.btn_StoreOfferUpdate.Text = "Update";
            this.btn_StoreOfferUpdate.UseVisualStyleBackColor = false;
            this.btn_StoreOfferUpdate.Click += new System.EventHandler(this.UpdateStoreOrOffer);
            // 
            // btn_Logout2
            // 
            this.btn_Logout2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Logout2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Logout2.FlatAppearance.BorderSize = 0;
            this.btn_Logout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout2.ForeColor = System.Drawing.Color.White;
            this.btn_Logout2.Location = new System.Drawing.Point(533, 533);
            this.btn_Logout2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Logout2.Name = "btn_Logout2";
            this.btn_Logout2.Size = new System.Drawing.Size(229, 31);
            this.btn_Logout2.TabIndex = 0;
            this.btn_Logout2.TabStop = false;
            this.btn_Logout2.Text = "LOG OUT";
            this.btn_Logout2.UseVisualStyleBackColor = false;
            this.btn_Logout2.Click += new System.EventHandler(this.AdminLogout);
            // 
            // dgv_Offers
            // 
            this.dgv_Offers.AllowUserToAddRows = false;
            this.dgv_Offers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Offers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Offers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Offers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Offers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Offers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_OfferID,
            this.c_OfferName,
            this.c_OfferDesc,
            this.c_OfferStoreName,
            this.c_OfferCreated});
            this.dgv_Offers.Location = new System.Drawing.Point(27, 306);
            this.dgv_Offers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Offers.Name = "dgv_Offers";
            this.dgv_Offers.ReadOnly = true;
            this.dgv_Offers.RowHeadersVisible = false;
            this.dgv_Offers.RowTemplate.Height = 24;
            this.dgv_Offers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Offers.Size = new System.Drawing.Size(491, 200);
            this.dgv_Offers.TabIndex = 1;
            this.dgv_Offers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OfferSelectedDataHandler);
            // 
            // c_OfferID
            // 
            this.c_OfferID.FillWeight = 40F;
            this.c_OfferID.HeaderText = "ID";
            this.c_OfferID.Name = "c_OfferID";
            this.c_OfferID.ReadOnly = true;
            // 
            // c_OfferName
            // 
            this.c_OfferName.HeaderText = "Name";
            this.c_OfferName.Name = "c_OfferName";
            this.c_OfferName.ReadOnly = true;
            // 
            // c_OfferDesc
            // 
            this.c_OfferDesc.HeaderText = "Description";
            this.c_OfferDesc.Name = "c_OfferDesc";
            this.c_OfferDesc.ReadOnly = true;
            // 
            // c_OfferStoreName
            // 
            this.c_OfferStoreName.HeaderText = "Store";
            this.c_OfferStoreName.Name = "c_OfferStoreName";
            this.c_OfferStoreName.ReadOnly = true;
            // 
            // c_OfferCreated
            // 
            this.c_OfferCreated.HeaderText = "Created";
            this.c_OfferCreated.Name = "c_OfferCreated";
            this.c_OfferCreated.ReadOnly = true;
            // 
            // btn_StoreCreate
            // 
            this.btn_StoreCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_StoreCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_StoreCreate.FlatAppearance.BorderSize = 0;
            this.btn_StoreCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StoreCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StoreCreate.ForeColor = System.Drawing.Color.White;
            this.btn_StoreCreate.Location = new System.Drawing.Point(532, 369);
            this.btn_StoreCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_StoreCreate.Name = "btn_StoreCreate";
            this.btn_StoreCreate.Size = new System.Drawing.Size(229, 31);
            this.btn_StoreCreate.TabIndex = 0;
            this.btn_StoreCreate.TabStop = false;
            this.btn_StoreCreate.Text = "Create Store";
            this.btn_StoreCreate.UseVisualStyleBackColor = false;
            this.btn_StoreCreate.Click += new System.EventHandler(this.StoreCreate);
            // 
            // dgv_Stores
            // 
            this.dgv_Stores.AllowUserToAddRows = false;
            this.dgv_Stores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Stores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Stores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Stores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Stores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_StoreID,
            this.c_StoreName,
            this.c_StoreAddress,
            this.c_StoreCreated});
            this.dgv_Stores.Location = new System.Drawing.Point(27, 53);
            this.dgv_Stores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Stores.Name = "dgv_Stores";
            this.dgv_Stores.ReadOnly = true;
            this.dgv_Stores.RowHeadersVisible = false;
            this.dgv_Stores.RowTemplate.Height = 24;
            this.dgv_Stores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Stores.Size = new System.Drawing.Size(491, 202);
            this.dgv_Stores.TabIndex = 0;
            this.dgv_Stores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StoreSelectedRowDataHandler);
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
            // c_StoreCreated
            // 
            this.c_StoreCreated.HeaderText = "Created";
            this.c_StoreCreated.Name = "c_StoreCreated";
            this.c_StoreCreated.ReadOnly = true;
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminGUI";
            this.Text = "Stämpelkortify (Admin)";
            this.tabControl1.ResumeLayout(false);
            this.customersPage.ResumeLayout(false);
            this.customersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            this.storesPage.ResumeLayout(false);
            this.storesPage.PerformLayout();
            this.panel_Offers.ResumeLayout(false);
            this.panel_Offers.PerformLayout();
            this.panel_Stores.ResumeLayout(false);
            this.panel_Stores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Offers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage customersPage;
        private System.Windows.Forms.TabPage storesPage;
        private System.Windows.Forms.Button btn_CustCreate;
        private System.Windows.Forms.Button btn_CustDelete;
        private System.Windows.Forms.Button btn_CustUpdate;
        private System.Windows.Forms.TextBox tb_CustPhone;
        private System.Windows.Forms.TextBox tb_CustMail;
        private System.Windows.Forms.TextBox tb_CustName;
        private System.Windows.Forms.Label lbl_CustPhone;
        private System.Windows.Forms.Label lbl_CustMail;
        private System.Windows.Forms.Label lbl_CustName;
        private System.Windows.Forms.DataGridView dgv_Customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_CustMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_CustPhone;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_CustSystemMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_CustTime;
        private System.Windows.Forms.DataGridView dgv_Stores;
        private System.Windows.Forms.Button btn_StoreCreate;
        private System.Windows.Forms.DataGridView dgv_Offers;
        private System.Windows.Forms.Button btn_Logout2;
        private System.Windows.Forms.Button btn_StoreOfferUpdate;
        private System.Windows.Forms.Button btn_StoreOfferDelete;
        private System.Windows.Forms.TextBox tb_CustPassword;
        private System.Windows.Forms.Label lbl_CustPassword;
        private System.Windows.Forms.TextBox tb_StoreAddress;
        private System.Windows.Forms.TextBox tb_StoreName;
        private System.Windows.Forms.Label lbl_StoreAddress;
        private System.Windows.Forms.Label lbl_StoreName;
        private System.Windows.Forms.Button btn_AddOffer;
        private System.Windows.Forms.Label lbl_Offer;
        private System.Windows.Forms.Label lbl_Stores;
        private System.Windows.Forms.Label lbl_StoreSystemMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_StoreAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_StoreCreated;
        private System.Windows.Forms.Label lbl_StoresSubsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_OfferID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_OfferName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_OfferDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_OfferStoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_OfferCreated;
        private System.Windows.Forms.Button btn_ClearTB;
        private System.Windows.Forms.Panel panel_Stores;
        private System.Windows.Forms.Panel panel_Offers;
        private System.Windows.Forms.TextBox tb_offerDesc;
        private System.Windows.Forms.TextBox tb_offerName;
        private System.Windows.Forms.Label lbl_OfferDesc;
        private System.Windows.Forms.Label lbl_OfferName;
        private System.Windows.Forms.TextBox tb_offerStampGoal;
        private System.Windows.Forms.Label lbl_StampGoal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Subscriptions;
    }
}