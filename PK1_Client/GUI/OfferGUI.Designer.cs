namespace PK1_Client.GUI
{
    partial class OfferGUI
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
            this.btn_OfferAdd = new System.Windows.Forms.Button();
            this.lbl_OfferName = new System.Windows.Forms.Label();
            this.lbl_OfferDesc = new System.Windows.Forms.Label();
            this.lbl_OfferStampGoal = new System.Windows.Forms.Label();
            this.trackBar_Stamps = new System.Windows.Forms.TrackBar();
            this.tb_OfferName = new System.Windows.Forms.TextBox();
            this.tb_Description = new System.Windows.Forms.RichTextBox();
            this.trackBar_Counter = new System.Windows.Forms.Label();
            this.lbl_OfferStoreName = new System.Windows.Forms.Label();
            this.lbl_OfferStore = new System.Windows.Forms.Label();
            this.lbl_OfferSystemMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Stamps)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OfferAdd
            // 
            this.btn_OfferAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_OfferAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_OfferAdd.FlatAppearance.BorderSize = 0;
            this.btn_OfferAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OfferAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OfferAdd.ForeColor = System.Drawing.Color.White;
            this.btn_OfferAdd.Location = new System.Drawing.Point(285, 267);
            this.btn_OfferAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OfferAdd.Name = "btn_OfferAdd";
            this.btn_OfferAdd.Size = new System.Drawing.Size(167, 31);
            this.btn_OfferAdd.TabIndex = 0;
            this.btn_OfferAdd.TabStop = false;
            this.btn_OfferAdd.Text = "Create";
            this.btn_OfferAdd.UseVisualStyleBackColor = false;
            this.btn_OfferAdd.Click += new System.EventHandler(this.CreateOffer);
            // 
            // lbl_OfferName
            // 
            this.lbl_OfferName.AutoSize = true;
            this.lbl_OfferName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OfferName.Location = new System.Drawing.Point(35, 60);
            this.lbl_OfferName.Name = "lbl_OfferName";
            this.lbl_OfferName.Size = new System.Drawing.Size(49, 17);
            this.lbl_OfferName.TabIndex = 1;
            this.lbl_OfferName.Text = "Name";
            // 
            // lbl_OfferDesc
            // 
            this.lbl_OfferDesc.AutoSize = true;
            this.lbl_OfferDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OfferDesc.Location = new System.Drawing.Point(35, 98);
            this.lbl_OfferDesc.Name = "lbl_OfferDesc";
            this.lbl_OfferDesc.Size = new System.Drawing.Size(90, 17);
            this.lbl_OfferDesc.TabIndex = 2;
            this.lbl_OfferDesc.Text = "Description";
            // 
            // lbl_OfferStampGoal
            // 
            this.lbl_OfferStampGoal.AutoSize = true;
            this.lbl_OfferStampGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OfferStampGoal.Location = new System.Drawing.Point(35, 219);
            this.lbl_OfferStampGoal.Name = "lbl_OfferStampGoal";
            this.lbl_OfferStampGoal.Size = new System.Drawing.Size(61, 17);
            this.lbl_OfferStampGoal.TabIndex = 3;
            this.lbl_OfferStampGoal.Text = "Stamps";
            // 
            // trackBar_Stamps
            // 
            this.trackBar_Stamps.Location = new System.Drawing.Point(145, 206);
            this.trackBar_Stamps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar_Stamps.Maximum = 20;
            this.trackBar_Stamps.Name = "trackBar_Stamps";
            this.trackBar_Stamps.Size = new System.Drawing.Size(283, 56);
            this.trackBar_Stamps.TabIndex = 4;
            this.trackBar_Stamps.ValueChanged += new System.EventHandler(this.SetCounterLabel);
            // 
            // tb_OfferName
            // 
            this.tb_OfferName.Location = new System.Drawing.Point(145, 60);
            this.tb_OfferName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_OfferName.Name = "tb_OfferName";
            this.tb_OfferName.Size = new System.Drawing.Size(133, 22);
            this.tb_OfferName.TabIndex = 5;
            // 
            // tb_Description
            // 
            this.tb_Description.Location = new System.Drawing.Point(145, 98);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(305, 96);
            this.tb_Description.TabIndex = 7;
            this.tb_Description.Text = "";
            // 
            // trackBar_Counter
            // 
            this.trackBar_Counter.AutoSize = true;
            this.trackBar_Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackBar_Counter.Location = new System.Drawing.Point(435, 206);
            this.trackBar_Counter.Name = "trackBar_Counter";
            this.trackBar_Counter.Size = new System.Drawing.Size(0, 17);
            this.trackBar_Counter.TabIndex = 8;
            // 
            // lbl_OfferStoreName
            // 
            this.lbl_OfferStoreName.AutoSize = true;
            this.lbl_OfferStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OfferStoreName.Location = new System.Drawing.Point(36, 25);
            this.lbl_OfferStoreName.Name = "lbl_OfferStoreName";
            this.lbl_OfferStoreName.Size = new System.Drawing.Size(47, 17);
            this.lbl_OfferStoreName.TabIndex = 9;
            this.lbl_OfferStoreName.Text = "Store";
            // 
            // lbl_OfferStore
            // 
            this.lbl_OfferStore.AutoSize = true;
            this.lbl_OfferStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OfferStore.Location = new System.Drawing.Point(141, 25);
            this.lbl_OfferStore.Name = "lbl_OfferStore";
            this.lbl_OfferStore.Size = new System.Drawing.Size(0, 17);
            this.lbl_OfferStore.TabIndex = 10;
            // 
            // lbl_OfferSystemMessage
            // 
            this.lbl_OfferSystemMessage.AutoSize = true;
            this.lbl_OfferSystemMessage.Location = new System.Drawing.Point(39, 280);
            this.lbl_OfferSystemMessage.Name = "lbl_OfferSystemMessage";
            this.lbl_OfferSystemMessage.Size = new System.Drawing.Size(0, 17);
            this.lbl_OfferSystemMessage.TabIndex = 11;
            // 
            // OfferGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 332);
            this.Controls.Add(this.lbl_OfferSystemMessage);
            this.Controls.Add(this.lbl_OfferStore);
            this.Controls.Add(this.lbl_OfferStoreName);
            this.Controls.Add(this.trackBar_Counter);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.tb_OfferName);
            this.Controls.Add(this.trackBar_Stamps);
            this.Controls.Add(this.lbl_OfferStampGoal);
            this.Controls.Add(this.lbl_OfferDesc);
            this.Controls.Add(this.lbl_OfferName);
            this.Controls.Add(this.btn_OfferAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OfferGUI";
            this.Text = "Stämpelkortify";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Stamps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OfferAdd;
        private System.Windows.Forms.Label lbl_OfferName;
        private System.Windows.Forms.Label lbl_OfferDesc;
        private System.Windows.Forms.Label lbl_OfferStampGoal;
        private System.Windows.Forms.TrackBar trackBar_Stamps;
        private System.Windows.Forms.TextBox tb_OfferName;
        private System.Windows.Forms.RichTextBox tb_Description;
        private System.Windows.Forms.Label trackBar_Counter;
        private System.Windows.Forms.Label lbl_OfferStoreName;
        private System.Windows.Forms.Label lbl_OfferStore;
        private System.Windows.Forms.Label lbl_OfferSystemMessage;
    }
}
