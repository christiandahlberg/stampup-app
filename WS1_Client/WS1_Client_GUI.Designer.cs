namespace WS1_Client
{
    partial class WS1_Client_GUI
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
            this.btnConsoleClient = new System.Windows.Forms.Button();
            this.btnWindowsFormsClient = new System.Windows.Forms.Button();
            this.btnJavaClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsoleClient
            // 
            this.btnConsoleClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsoleClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConsoleClient.FlatAppearance.BorderSize = 0;
            this.btnConsoleClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsoleClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsoleClient.ForeColor = System.Drawing.Color.White;
            this.btnConsoleClient.Location = new System.Drawing.Point(58, 111);
            this.btnConsoleClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsoleClient.Name = "btnConsoleClient";
            this.btnConsoleClient.Size = new System.Drawing.Size(668, 34);
            this.btnConsoleClient.TabIndex = 0;
            this.btnConsoleClient.TabStop = false;
            this.btnConsoleClient.Text = "Console Client";
            this.btnConsoleClient.UseVisualStyleBackColor = true;
            this.btnConsoleClient.Click += new System.EventHandler(this.ConsoleClient_Click);
            // 
            // btnWindowsFormsClient
            // 
            this.btnWindowsFormsClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnWindowsFormsClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnWindowsFormsClient.FlatAppearance.BorderSize = 0;
            this.btnWindowsFormsClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowsFormsClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindowsFormsClient.ForeColor = System.Drawing.Color.White;
            this.btnWindowsFormsClient.Location = new System.Drawing.Point(58, 165);
            this.btnWindowsFormsClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWindowsFormsClient.Name = "btnWindowsFormsClient";
            this.btnWindowsFormsClient.Size = new System.Drawing.Size(668, 34);
            this.btnWindowsFormsClient.TabIndex = 0;
            this.btnWindowsFormsClient.TabStop = false;
            this.btnWindowsFormsClient.Text = "Windows Forms Client";
            this.btnWindowsFormsClient.UseVisualStyleBackColor = true;
            this.btnWindowsFormsClient.Click += new System.EventHandler(this.WinFormsClient_Click);
            // 
            // btnJavaClient
            // 
            this.btnJavaClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnJavaClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnJavaClient.FlatAppearance.BorderSize = 0;
            this.btnJavaClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJavaClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJavaClient.ForeColor = System.Drawing.Color.White;
            this.btnJavaClient.Location = new System.Drawing.Point(58, 221);
            this.btnJavaClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJavaClient.Name = "btnJavaClient";
            this.btnJavaClient.Size = new System.Drawing.Size(668, 34);
            this.btnJavaClient.TabIndex = 0;
            this.btnJavaClient.TabStop = false;
            this.btnJavaClient.Text = "Java Client";
            this.btnJavaClient.UseVisualStyleBackColor = true;
            this.btnJavaClient.Click += new System.EventHandler(this.JavaClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upload file and choose client:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chooseFileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chooseFileButton.FlatAppearance.BorderSize = 0;
            this.chooseFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFileButton.ForeColor = System.Drawing.Color.White;
            this.chooseFileButton.Location = new System.Drawing.Point(581, 35);
            this.chooseFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(145, 34);
            this.chooseFileButton.TabIndex = 0;
            this.chooseFileButton.TabStop = false;
            this.chooseFileButton.Text = "Choose file...";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 274);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WS1_Client_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJavaClient);
            this.Controls.Add(this.btnWindowsFormsClient);
            this.Controls.Add(this.btnConsoleClient);
            this.Name = "WS1_Client_GUI";
            this.Text = "Web Service 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsoleClient;
        private System.Windows.Forms.Button btnWindowsFormsClient;
        private System.Windows.Forms.Button btnJavaClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Label label2;
    }
}