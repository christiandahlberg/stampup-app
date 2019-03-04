namespace WS2_WindowsForms_Client
{
    partial class WS2_WindowsForms_Client_GUI
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
            this.btn_GetAllCustomers = new System.Windows.Forms.Button();
            this.btn_GetAllOffers = new System.Windows.Forms.Button();
            this.btn_GetAllStores = new System.Windows.Forms.Button();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GetAllCustomers
            // 
            this.btn_GetAllCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_GetAllCustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_GetAllCustomers.FlatAppearance.BorderSize = 0;
            this.btn_GetAllCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetAllCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetAllCustomers.ForeColor = System.Drawing.Color.White;
            this.btn_GetAllCustomers.Location = new System.Drawing.Point(31, 27);
            this.btn_GetAllCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GetAllCustomers.Name = "btn_GetAllCustomers";
            this.btn_GetAllCustomers.Size = new System.Drawing.Size(129, 34);
            this.btn_GetAllCustomers.TabIndex = 0;
            this.btn_GetAllCustomers.TabStop = false;
            this.btn_GetAllCustomers.Text = "Get Customers";
            this.btn_GetAllCustomers.UseVisualStyleBackColor = true;
            this.btn_GetAllCustomers.Click += new System.EventHandler(this.btn_GetAllCustomers_Click);
            // 
            // btn_GetAllOffers
            // 
            this.btn_GetAllOffers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_GetAllOffers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_GetAllOffers.FlatAppearance.BorderSize = 0;
            this.btn_GetAllOffers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetAllOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetAllOffers.ForeColor = System.Drawing.Color.White;
            this.btn_GetAllOffers.Location = new System.Drawing.Point(385, 27);
            this.btn_GetAllOffers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GetAllOffers.Name = "btn_GetAllOffers";
            this.btn_GetAllOffers.Size = new System.Drawing.Size(129, 34);
            this.btn_GetAllOffers.TabIndex = 0;
            this.btn_GetAllOffers.TabStop = false;
            this.btn_GetAllOffers.Text = "Get Offers";
            this.btn_GetAllOffers.UseVisualStyleBackColor = true;
            this.btn_GetAllOffers.Click += new System.EventHandler(this.btn_GetAllOffers_Click);
            // 
            // btn_GetAllStores
            // 
            this.btn_GetAllStores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_GetAllStores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_GetAllStores.FlatAppearance.BorderSize = 0;
            this.btn_GetAllStores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetAllStores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetAllStores.ForeColor = System.Drawing.Color.White;
            this.btn_GetAllStores.Location = new System.Drawing.Point(208, 27);
            this.btn_GetAllStores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GetAllStores.Name = "btn_GetAllStores";
            this.btn_GetAllStores.Size = new System.Drawing.Size(129, 34);
            this.btn_GetAllStores.TabIndex = 0;
            this.btn_GetAllStores.TabStop = false;
            this.btn_GetAllStores.Text = "Get Stores";
            this.btn_GetAllStores.UseVisualStyleBackColor = true;
            this.btn_GetAllStores.Click += new System.EventHandler(this.btn_GetAllStores_Click);
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToAddRows = false;
            this.dgv_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Location = new System.Drawing.Point(31, 76);
            this.dgv_table.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.RowHeadersVisible = false;
            this.dgv_table.Size = new System.Drawing.Size(693, 272);
            this.dgv_table.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(558, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 34);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "Get Subscriptions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_GetAllSubscriptions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.btn_GetAllStores);
            this.Controls.Add(this.btn_GetAllOffers);
            this.Controls.Add(this.btn_GetAllCustomers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Web Service 2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GetAllCustomers;
        private System.Windows.Forms.Button btn_GetAllOffers;
        private System.Windows.Forms.Button btn_GetAllStores;
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.Button button1;
    }
}

