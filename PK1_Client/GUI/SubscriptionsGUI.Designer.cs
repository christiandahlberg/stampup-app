namespace PK1_Client.GUI
{
    partial class SubscriptionsGUI
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
            this.lbl_Customers = new System.Windows.Forms.Label();
            this.comboBox_Customer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Store = new System.Windows.Forms.ComboBox();
            this.dgv_Offers = new System.Windows.Forms.DataGridView();
            this.c_OfferID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_OfferName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Subscribed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_SystemMessage = new System.Windows.Forms.Label();
            this.btnAddStamp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Offers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Customers
            // 
            this.lbl_Customers.AutoSize = true;
            this.lbl_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customers.Location = new System.Drawing.Point(20, 20);
            this.lbl_Customers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Customers.Name = "lbl_Customers";
            this.lbl_Customers.Size = new System.Drawing.Size(59, 13);
            this.lbl_Customers.TabIndex = 2;
            this.lbl_Customers.Text = "Customer";
            // 
            // comboBox_Customer
            // 
            this.comboBox_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Customer.FormattingEnabled = true;
            this.comboBox_Customer.Location = new System.Drawing.Point(98, 18);
            this.comboBox_Customer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Customer.Name = "comboBox_Customer";
            this.comboBox_Customer.Size = new System.Drawing.Size(146, 21);
            this.comboBox_Customer.TabIndex = 3;
            this.comboBox_Customer.SelectedIndexChanged += new System.EventHandler(this.refreshTable);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Store";
            // 
            // comboBox_Store
            // 
            this.comboBox_Store.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Store.FormattingEnabled = true;
            this.comboBox_Store.Location = new System.Drawing.Point(98, 51);
            this.comboBox_Store.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Store.Name = "comboBox_Store";
            this.comboBox_Store.Size = new System.Drawing.Size(146, 21);
            this.comboBox_Store.TabIndex = 5;
            this.comboBox_Store.SelectedIndexChanged += new System.EventHandler(this.selectedStore_Click);
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
            this.c_Desc,
            this.c_Subscribed});
            this.dgv_Offers.Location = new System.Drawing.Point(22, 87);
            this.dgv_Offers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Offers.Name = "dgv_Offers";
            this.dgv_Offers.RowHeadersVisible = false;
            this.dgv_Offers.RowTemplate.DividerHeight = 2;
            this.dgv_Offers.RowTemplate.Height = 24;
            this.dgv_Offers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Offers.Size = new System.Drawing.Size(422, 185);
            this.dgv_Offers.TabIndex = 10;
            this.dgv_Offers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.setAddStampTrue);
            this.dgv_Offers.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.subscribed_CellMouseUp);
            this.dgv_Offers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.subscribed_CellValueChanged);
            // 
            // c_OfferID
            // 
            this.c_OfferID.FillWeight = 40F;
            this.c_OfferID.HeaderText = "ID";
            this.c_OfferID.Name = "c_OfferID";
            this.c_OfferID.Visible = false;
            // 
            // c_OfferName
            // 
            this.c_OfferName.FillWeight = 50F;
            this.c_OfferName.HeaderText = "Name";
            this.c_OfferName.Name = "c_OfferName";
            // 
            // c_Desc
            // 
            this.c_Desc.HeaderText = "Description";
            this.c_Desc.Name = "c_Desc";
            // 
            // c_Subscribed
            // 
            this.c_Subscribed.FalseValue = "false";
            this.c_Subscribed.FillWeight = 50F;
            this.c_Subscribed.HeaderText = "Subscribed";
            this.c_Subscribed.Name = "c_Subscribed";
            this.c_Subscribed.TrueValue = "true";
            // 
            // lbl_SystemMessage
            // 
            this.lbl_SystemMessage.AutoSize = true;
            this.lbl_SystemMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SystemMessage.Location = new System.Drawing.Point(20, 288);
            this.lbl_SystemMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SystemMessage.Name = "lbl_SystemMessage";
            this.lbl_SystemMessage.Size = new System.Drawing.Size(0, 13);
            this.lbl_SystemMessage.TabIndex = 11;
            // 
            // btnAddStamp
            // 
            this.btnAddStamp.BackColor = System.Drawing.Color.Gray;
            this.btnAddStamp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddStamp.FlatAppearance.BorderSize = 0;
            this.btnAddStamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStamp.ForeColor = System.Drawing.Color.White;
            this.btnAddStamp.Location = new System.Drawing.Point(325, 46);
            this.btnAddStamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddStamp.Name = "btnAddStamp";
            this.btnAddStamp.Size = new System.Drawing.Size(119, 28);
            this.btnAddStamp.TabIndex = 0;
            this.btnAddStamp.TabStop = false;
            this.btnAddStamp.Text = "Add Stamp";
            this.btnAddStamp.UseVisualStyleBackColor = true;
            this.btnAddStamp.Enabled = false;
            this.btnAddStamp.Click += new System.EventHandler(this.btnAddStamp_Click);
            // 
            // SubscriptionsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 331);
            this.Controls.Add(this.btnAddStamp);
            this.Controls.Add(this.lbl_SystemMessage);
            this.Controls.Add(this.dgv_Offers);
            this.Controls.Add(this.comboBox_Store);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Customer);
            this.Controls.Add(this.lbl_Customers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SubscriptionsGUI";
            this.Text = "Stämpelkortify";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Offers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Customers;
        private System.Windows.Forms.ComboBox comboBox_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Store;
        private System.Windows.Forms.DataGridView dgv_Offers;
        private System.Windows.Forms.Label lbl_SystemMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_OfferID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_OfferName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Desc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c_Subscribed;
        private System.Windows.Forms.Button btnAddStamp;
    }
}