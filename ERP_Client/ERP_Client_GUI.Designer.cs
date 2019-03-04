namespace ERP_Client
{
    partial class ERP_Client_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_JavaClient = new System.Windows.Forms.Button();
            this.btn_WindowsFormsClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose client:";
            // 
            // btn_JavaClient
            // 
            this.btn_JavaClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_JavaClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_JavaClient.FlatAppearance.BorderSize = 0;
            this.btn_JavaClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JavaClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JavaClient.ForeColor = System.Drawing.Color.White;
            this.btn_JavaClient.Location = new System.Drawing.Point(65, 130);
            this.btn_JavaClient.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_JavaClient.Name = "btn_JavaClient";
            this.btn_JavaClient.Size = new System.Drawing.Size(487, 36);
            this.btn_JavaClient.TabIndex = 0;
            this.btn_JavaClient.TabStop = false;
            this.btn_JavaClient.Text = "Java Client";
            this.btn_JavaClient.UseVisualStyleBackColor = false;
            this.btn_JavaClient.Click += new System.EventHandler(this.javaClient_Click);
            // 
            // btn_WindowsFormsClient
            // 
            this.btn_WindowsFormsClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_WindowsFormsClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_WindowsFormsClient.FlatAppearance.BorderSize = 0;
            this.btn_WindowsFormsClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WindowsFormsClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WindowsFormsClient.ForeColor = System.Drawing.Color.White;
            this.btn_WindowsFormsClient.Location = new System.Drawing.Point(65, 76);
            this.btn_WindowsFormsClient.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_WindowsFormsClient.Name = "btn_WindowsFormsClient";
            this.btn_WindowsFormsClient.Size = new System.Drawing.Size(487, 36);
            this.btn_WindowsFormsClient.TabIndex = 0;
            this.btn_WindowsFormsClient.TabStop = false;
            this.btn_WindowsFormsClient.Text = "Windows Forms Client";
            this.btn_WindowsFormsClient.UseVisualStyleBackColor = false;
            this.btn_WindowsFormsClient.Click += new System.EventHandler(this.windowsFormsClient_Click);
            // 
            // ERP_Client_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 211);
            this.Controls.Add(this.btn_WindowsFormsClient);
            this.Controls.Add(this.btn_JavaClient);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ERP_Client_GUI";
            this.Text = "ERP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_JavaClient;
        private System.Windows.Forms.Button btn_WindowsFormsClient;
    }
}

