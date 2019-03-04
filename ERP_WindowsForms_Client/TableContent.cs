using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_WindowsForms_Client.ServiceReference;

namespace ERP_WindowsForms_Client
{
    public partial class TableContents : Form
    {
        private Controller controller;
        private string _tableName;
        private List<string> _columnNames;

        public TableContents(string tableName, string action)
        {
            InitializeComponent();

            controller = new Controller();

            _tableName = tableName;

            switch (action)
            {
                case "contents":
                    FillContent();
                    break;

                case "All keys":
                    FillMetadataContent("All keys");
                    break;

                case "All indexes":
                    FillMetadataContent("All indexes");
                    break;

                case "All constraints":
                    FillMetadataContent("All constraints");
                    break;
                case "Relatives":
                    FillRelatives();
                    break;
            }


            // SetColumns();
            // label1.Text = _tableName;
            // FillContent();

        }

        public void SetColumns()
        {
            foreach (string colName in _columnNames)
            {
                dataGridView1.Columns.Add(colName, colName);
            }
        }

        public void FillRelatives()
        {
            _columnNames = new List<string>() { "First name", "Last name", "Relative code" };
            SetColumns();
            label1.Text = String.Format("Relatives to employee no: {0}", _tableName);

            foreach (Relative relative in controller.GetRelatives(_tableName))
            {
                dataGridView1.Rows.Add(relative.FirstName, relative.LastName, relative.RelativeCode);
            }

        }

        public void FillContent()
        {
            _columnNames = controller.GetColumnNames(_tableName);
            SetColumns();
            label1.Text = _tableName;

            List<List<string>> contents = controller.GetTableContent(_tableName);

            int rowIndex = 0;
            foreach (List<string> row in contents)
            {
                dataGridView1.Rows.Add();
                int colIndex = 0;
                foreach (string column in row)
                {
                    dataGridView1.Rows[rowIndex].Cells[colIndex].Value = column;
                    colIndex++;
                }
                rowIndex++;
            }
        }

        public void FillMetadataContent(string action)
        {
            if (action.Equals("All indexes"))
            {
                _columnNames = new List<string>() { "Index_Name", "Index_Type", "Table_Name" };
                SetColumns();
                label1.Text = _tableName;

                MetadataItem[] data = controller.GetIndexes(_tableName);

                foreach (MetadataItem item in data)
                {
                    dataGridView1.Rows.Add(item.IndexName, item.IndexType, item.TableName);
                }
            }
            else if (action.Equals("All constraints") ||
                    action.Equals("All keys"))
            {
                _columnNames = new List<string>() { "COLUMN_NAME", "CONSTRAINT_NAME", "CONSTRAINT_TYPE" };
                SetColumns();
                label1.Text = _tableName;

                MetadataItem[] data = controller.GetConstraints(_tableName);

                foreach (MetadataItem item in data)
                {
                    dataGridView1.Rows.Add(item.ColumnName, item.ConstraintName, item.ConstraintType);
                }
            }

        }
    }
}
