using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resources;

namespace PK2_Client
{
    public partial class View : Form
    {
        private Controller controller;

        public View(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            SetContent();
        }

        private void ShowInformationEvent(object sender, EventArgs e)
        {
            SetScene();
            if (cb_Tables.SelectedItem == null)
            {
                lbl_ErrorMessage.Text = "ERROR: Please choose a table.";
            }
            else
            {
                // Try/Catch kan vara onödigt eftersom val av tabell aldrig kan resultera i att valet är null.
                try
                {
                    setColumnHeader("tableColumn", (string)cb_Tables.SelectedItem);
                    foreach (string column in controller.getColumnNames(cb_Tables.SelectedItem))
                    {
                        dgv_ResultTable.Rows.Add(column);
                    }
                    lbl_RowCount.Text = controller.getRowCount(cb_Tables.SelectedItem);

                    dgv_ResultTable.CurrentCell.Selected = false;
                }
                catch (Exception ex)
                {
                    ExceptionHandler.HandleErrorException(ex);
                }
            }

        }
        // Fix content
        private void SetContent()
        {
            foreach (TableObject o in controller.GetTableObjects())
            {
                cb_Tables.Items.Add(o.TableName);
            }
        }

        // Used to remove error messages when method succeeds.
        private void SetScene()
        {
            dgv_ResultTable.Columns.Clear();
            lbl_ErrorMessage.Text = "";
        }

        // Adjusts columnheader for resulttable when selecting table to show.
        private void setColumnHeader(string varName, string comboBox)
        {
            dgv_ResultTable.Columns.Add(varName, comboBox);
            dgv_ResultTable.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.Highlight;
            dgv_ResultTable.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            dgv_ResultTable.EnableHeadersVisualStyles = false;
            dgv_ResultTable.ColumnHeadersHeight = 24;
            dgv_ResultTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

        }
    }
}

