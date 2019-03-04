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
            this.btn_WindowsFormClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_WindowsFormClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_WindowsFormClient.FlatAppearance.BorderSize = 0;
            this.btn_WindowsFormClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WindowsFormClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WindowsFormClient.ForeColor = System.Drawing.Color.White;
            this.btn_WindowsFormClient.Location = new System.Drawing.Point(46, 134);
            this.btn_WindowsFormClient.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_WindowsFormClient.Name = "btn_WindowsFormClient";
            this.btn_WindowsFormClient.Size = new System.Drawing.Size(617, 38);
            this.btn_WindowsFormClient.TabIndex = 0;
            this.btn_WindowsFormClient.TabStop = false;
            this.btn_WindowsFormClient.Text = "Windows Form Client";
            this.btn_WindowsFormClient.UseVisualStyleBackColor = false;
            this.btn_WindowsFormClient.Click += new System.EventHandler(this.btn_WindowsFormClient_Click);
            // 
            // btn_ConsoleClient
            // 
            this.btn_ConsoleClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ConsoleClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ConsoleClient.FlatAppearance.BorderSize = 0;
            this.btn_ConsoleClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsoleClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsoleClient.ForeColor = System.Drawing.Color.White;
            this.btn_ConsoleClient.Location = new System.Drawing.Point(46, 79);
            this.btn_ConsoleClient.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_ConsoleClient.Name = "btn_ConsoleClient";
            this.btn_ConsoleClient.Size = new System.Drawing.Size(617, 38);
            this.btn_ConsoleClient.TabIndex = 0;
            this.btn_ConsoleClient.TabStop = false;
            this.btn_ConsoleClient.Text = "Console Client";
            this.btn_ConsoleClient.UseVisualStyleBackColor = false;
            this.btn_ConsoleClient.Click += new System.EventHandler(this.btn_ConsoleClient_Click);
            // 
            // btn_JavaClient
            // 
            this.btn_JavaClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_JavaClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_JavaClient.FlatAppearance.BorderSize = 0;
            this.btn_JavaClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JavaClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JavaClient.ForeColor = System.Drawing.Color.White;
            this.btn_JavaClient.Location = new System.Drawing.Point(46, 191);
            this.btn_JavaClient.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_JavaClient.Name = "btn_JavaClient";
            this.btn_JavaClient.Size = new System.Drawing.Size(617, 38);
            this.btn_JavaClient.TabIndex = 0;
            this.btn_JavaClient.TabStop = false;
            this.btn_JavaClient.Text = "Java Client";
            this.btn_JavaClient.UseVisualStyleBackColor = false;
            this.btn_JavaClient.Click += new System.EventHandler(this.btn_JavaClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose client";
            // 
            // WS2_Client_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_JavaClient);
            this.Controls.Add(this.btn_ConsoleClient);
            this.Controls.Add(this.btn_WindowsFormClient);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WS2_Client_GUI";
            this.Text = "Web Service 2";
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