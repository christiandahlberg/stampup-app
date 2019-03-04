namespace WS2_Client
{
    partial class WS2_Client_GUI
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
            this.btn_WindowsFormClient = new System.Windows.Forms.Button();
            this.btn_ConsoleClient = new System.Windows.Forms.Button();
            this.btn_JavaClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_WindowsFormClient
            // 
            this.btn_WindowsFormClient.Location = new System.Drawing.Point(34, 140);
            this.btn_WindowsFormClient.Name = "btn_WindowsFormClient";
            this.btn_WindowsFormClient.Size = new System.Drawing.Size(463, 23);
            this.btn_WindowsFormClient.TabIndex = 0;
            this.btn_WindowsFormClient.Text = "Windows Form Client";
            this.btn_WindowsFormClient.UseVisualStyleBackColor = true;
            this.btn_WindowsFormClient.Click += new System.EventHandler(this.btn_WindowsFormClient_Click);
            // 
            // btn_ConsoleClient
            // 
            this.btn_ConsoleClient.Location = new System.Drawing.Point(34, 96);
            this.btn_ConsoleClient.Name = "btn_ConsoleClient";
            this.btn_ConsoleClient.Size = new System.Drawing.Size(463, 23);
            this.btn_ConsoleClient.TabIndex = 1;
            this.btn_ConsoleClient.Text = "Console Client";
            this.btn_ConsoleClient.UseVisualStyleBackColor = true;
            this.btn_ConsoleClient.Click += new System.EventHandler(this.btn_ConsoleClient_Click);
            // 
            // btn_JavaClient
            // 
            this.btn_JavaClient.Location = new System.Drawing.Point(34, 187);
            this.btn_JavaClient.Name = "btn_JavaClient";
            this.btn_JavaClient.Size = new System.Drawing.Size(463, 23);
            this.btn_JavaClient.TabIndex = 2;
            this.btn_JavaClient.Text = "Java Client";
            this.btn_JavaClient.UseVisualStyleBackColor = true;
            this.btn_JavaClient.Click += new System.EventHandler(this.btn_JavaClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose client";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_JavaClient);
            this.Controls.Add(this.btn_ConsoleClient);
            this.Controls.Add(this.btn_WindowsFormClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_WindowsFormClient;
        private System.Windows.Forms.Button btn_ConsoleClient;
        private System.Windows.Forms.Button btn_JavaClient;
        private System.Windows.Forms.Label label1;
    }
}