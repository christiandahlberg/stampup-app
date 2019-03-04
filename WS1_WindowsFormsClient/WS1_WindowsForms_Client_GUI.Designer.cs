namespace WS1_WindowsForms_Client
{
    partial class WS1_WindowsForms_Client_GUI
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 60);
            this.label1.Name = "Read file";
            this.label1.Size = new System.Drawing.Size(697, 301);
            this.label1.TabIndex = 0;

            // Get Dynamic File name
            WS1_WindowsForms_Client.ServiceReference.ReadFileSoapClient c = new WS1_WindowsForms_Client.ServiceReference.ReadFileSoapClient();
            this.label1.Text = c.OpenFile(FilePath);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Name = "Windows Forms Client";
            this.Text = "Windows Forms Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}

