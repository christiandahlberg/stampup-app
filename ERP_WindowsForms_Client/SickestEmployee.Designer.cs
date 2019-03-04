namespace ERP_WindowsForms_Client
{
    partial class SickestEmployee
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
            this.lbl_sickestEmployee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_sickestEmployee
            // 
            this.lbl_sickestEmployee.BackColor = System.Drawing.Color.White;
            this.lbl_sickestEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sickestEmployee.Location = new System.Drawing.Point(0, -1);
            this.lbl_sickestEmployee.Name = "lbl_sickestEmployee";
            this.lbl_sickestEmployee.Size = new System.Drawing.Size(392, 153);
            this.lbl_sickestEmployee.TabIndex = 0;
            this.lbl_sickestEmployee.Text = "First name";
            this.lbl_sickestEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SickestEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 152);
            this.Controls.Add(this.lbl_sickestEmployee);
            this.Name = "SickestEmployee";
            this.Text = "Sickest employee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_sickestEmployee;
    }
}