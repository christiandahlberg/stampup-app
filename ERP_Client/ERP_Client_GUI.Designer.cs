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
            this.btnJavaClient = new System.Windows.Forms.Button();
            this.btnWindowsForms = new System.Windows.Forms.Button();
            this.Ch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJavaClient
            // 
            this.btnJavaClient.Location = new System.Drawing.Point(38, 161);
            this.btnJavaClient.Name = "btnJavaClient";
            this.btnJavaClient.Size = new System.Drawing.Size(372, 23);
            this.btnJavaClient.TabIndex = 0;
            this.btnJavaClient.Text = "Java Client";
            this.btnJavaClient.UseVisualStyleBackColor = true;
            this.btnJavaClient.Click += new System.EventHandler(this.btnJavaClient_Click);
            // 
            // btnWindowsForms
            // 
            this.btnWindowsForms.Location = new System.Drawing.Point(38, 116);
            this.btnWindowsForms.Name = "btnWindowsForms";
            this.btnWindowsForms.Size = new System.Drawing.Size(372, 23);
            this.btnWindowsForms.TabIndex = 1;
            this.btnWindowsForms.Text = "Windows Forms Client";
            this.btnWindowsForms.UseVisualStyleBackColor = true;
            this.btnWindowsForms.Click += new System.EventHandler(this.btnWindowsForms_Click);
            // 
            // Ch
            // 
            this.Ch.AutoSize = true;
            this.Ch.Location = new System.Drawing.Point(186, 52);
            this.Ch.Name = "Ch";
            this.Ch.Size = new System.Drawing.Size(71, 13);
            this.Ch.TabIndex = 2;
            this.Ch.Text = "Choose client";
            // 
            // ERP_Client_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 267);
            this.Controls.Add(this.Ch);
            this.Controls.Add(this.btnWindowsForms);
            this.Controls.Add(this.btnJavaClient);
            this.Name = "ERP_Client_GUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJavaClient;
        private System.Windows.Forms.Button btnWindowsForms;
        private System.Windows.Forms.Label Ch;
    }
}

