namespace MainClient
{
    partial class Form1
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
            this.btnPK1 = new System.Windows.Forms.Button();
            this.btnPK2 = new System.Windows.Forms.Button();
            this.btnWS1 = new System.Windows.Forms.Button();
            this.btnWS2 = new System.Windows.Forms.Button();
            this.btnERP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPK1
            // 
            this.btnPK1.Location = new System.Drawing.Point(30, 96);
            this.btnPK1.Name = "btnPK1";
            this.btnPK1.Size = new System.Drawing.Size(492, 23);
            this.btnPK1.TabIndex = 0;
            this.btnPK1.Text = "Programkonstruktion 1";
            this.btnPK1.UseVisualStyleBackColor = true;
            this.btnPK1.Click += new System.EventHandler(this.btnPK1_Click);
            // 
            // btnPK2
            // 
            this.btnPK2.Location = new System.Drawing.Point(30, 134);
            this.btnPK2.Name = "btnPK2";
            this.btnPK2.Size = new System.Drawing.Size(492, 23);
            this.btnPK2.TabIndex = 1;
            this.btnPK2.Text = "Programkonstruktion 2";
            this.btnPK2.UseVisualStyleBackColor = true;
            this.btnPK2.Click += new System.EventHandler(this.btnPK2_Click);
            // 
            // btnWS1
            // 
            this.btnWS1.Location = new System.Drawing.Point(30, 183);
            this.btnWS1.Name = "btnWS1";
            this.btnWS1.Size = new System.Drawing.Size(492, 23);
            this.btnWS1.TabIndex = 2;
            this.btnWS1.Text = "Web Service 1";
            this.btnWS1.UseVisualStyleBackColor = true;
            this.btnWS1.Click += new System.EventHandler(this.btnWS1_Click);
            // 
            // btnWS2
            // 
            this.btnWS2.Location = new System.Drawing.Point(30, 221);
            this.btnWS2.Name = "btnWS2";
            this.btnWS2.Size = new System.Drawing.Size(492, 23);
            this.btnWS2.TabIndex = 3;
            this.btnWS2.Text = "Web Service 2";
            this.btnWS2.UseVisualStyleBackColor = true;
            this.btnWS2.Click += new System.EventHandler(this.btnWS2_Click);
            // 
            // btnERP
            // 
            this.btnERP.Location = new System.Drawing.Point(30, 271);
            this.btnERP.Name = "btnERP";
            this.btnERP.Size = new System.Drawing.Size(492, 23);
            this.btnERP.TabIndex = 4;
            this.btnERP.Text = "ERP ";
            this.btnERP.UseVisualStyleBackColor = true;
            this.btnERP.Click += new System.EventHandler(this.btnERP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chooese an assignment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnERP);
            this.Controls.Add(this.btnWS2);
            this.Controls.Add(this.btnWS1);
            this.Controls.Add(this.btnPK2);
            this.Controls.Add(this.btnPK1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPK1;
        private System.Windows.Forms.Button btnPK2;
        private System.Windows.Forms.Button btnWS1;
        private System.Windows.Forms.Button btnWS2;
        private System.Windows.Forms.Button btnERP;
        private System.Windows.Forms.Label label1;
    }
}

