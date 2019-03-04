namespace PK2_Client
{
    partial class View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_Tables = new System.Windows.Forms.ComboBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.lbl_Table = new System.Windows.Forms.Label();
            this.dgv_ResultTable = new System.Windows.Forms.DataGridView();
            this.lbl_Rows = new System.Windows.Forms.Label();
            this.lbl_RowCount = new System.Windows.Forms.Label();
            this.lbl_ErrorMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Tables
            // 
            this.cb_Tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tables.FormattingEnabled = true;
            this.cb_Tables.Location = new System.Drawing.Point(98, 59);
            this.cb_Tables.Name = "cb_Tables";
            this.cb_Tables.Size = new System.Drawing.Size(168, 24);
            this.cb_Tables.TabIndex = 0;
            // 
            // btn_Select
            // 
            this.btn_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Select.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Select.FlatAppearance.BorderSize = 0;
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Select.ForeColor = System.Drawing.Color.White;
            this.btn_Select.Location = new System.Drawing.Point(286, 59);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(125, 24);
            this.btn_Select.TabIndex = 0;
            this.btn_Select.TabStop = false;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.ShowInformationEvent);
            // 
            // lbl_Table
            // 
            this.lbl_Table.AutoSize = true;
            this.lbl_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Table.Location = new System.Drawing.Point(25, 59);
            this.lbl_Table.Name = "lbl_Table";
            this.lbl_Table.Size = new System.Drawing.Size(49, 17);
            this.lbl_Table.TabIndex = 2;
            this.lbl_Table.Text = "Table";
            // 
            // dgv_ResultTable
            // 
            this.dgv_ResultTable.AllowUserToAddRows = false;
            this.dgv_ResultTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ResultTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_ResultTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ResultTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ResultTable.Location = new System.Drawing.Point(434, 42);
            this.dgv_ResultTable.Name = "dgv_ResultTable";
            this.dgv_ResultTable.ReadOnly = true;
            this.dgv_ResultTable.RowHeadersVisible = false;
            this.dgv_ResultTable.RowTemplate.Height = 24;
            this.dgv_ResultTable.Size = new System.Drawing.Size(209, 190);
            this.dgv_ResultTable.TabIndex = 3;
            // 
            // lbl_Rows
            // 
            this.lbl_Rows.AutoSize = true;
            this.lbl_Rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rows.Location = new System.Drawing.Point(28, 103);
            this.lbl_Rows.Name = "lbl_Rows";
            this.lbl_Rows.Size = new System.Drawing.Size(46, 17);
            this.lbl_Rows.TabIndex = 4;
            this.lbl_Rows.Text = "Rows";
            // 
            // lbl_RowCount
            // 
            this.lbl_RowCount.AutoSize = true;
            this.lbl_RowCount.Location = new System.Drawing.Point(95, 103);
            this.lbl_RowCount.Name = "lbl_RowCount";
            this.lbl_RowCount.Size = new System.Drawing.Size(0, 17);
            this.lbl_RowCount.TabIndex = 5;
            // 
            // lbl_ErrorMessage
            // 
            this.lbl_ErrorMessage.AutoSize = true;
            this.lbl_ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage.Location = new System.Drawing.Point(30, 190);
            this.lbl_ErrorMessage.Name = "lbl_ErrorMessage";
            this.lbl_ErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.lbl_ErrorMessage.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose a table";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ErrorMessage);
            this.Controls.Add(this.lbl_RowCount);
            this.Controls.Add(this.lbl_Rows);
            this.Controls.Add(this.dgv_ResultTable);
            this.Controls.Add(this.lbl_Table);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.cb_Tables);
            this.Name = "View";
            this.Text = "Programkonstruktion 2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Tables;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Label lbl_Table;
        private System.Windows.Forms.DataGridView dgv_ResultTable;
        private System.Windows.Forms.Label lbl_Rows;
        private System.Windows.Forms.Label lbl_RowCount;
        private System.Windows.Forms.Label lbl_ErrorMessage;
        private System.Windows.Forms.Label label1;
    }
}