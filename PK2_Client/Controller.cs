using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PK2_Client
{
    public class Controller
    {
        // Initilize attributes
        private TableReader tableReader;

        public Controller(string tableName)
        {
            tableReader = new TableReader(tableName);
        }

        public List<TableObject> GetTableObjects()
        {
            return tableReader.TableObjects;
        }

        public string getRowCount(object selectedItem)
        {
            TableObject tableObject = tableReader.GetTableObjectByName((string)selectedItem);

            string numberOfRows;
            if (tableObject == null)
                numberOfRows = "0";
            else
                numberOfRows = tableObject.NumberOfRows.ToString();

            return numberOfRows;
        }

        public List<string> getColumnNames(object selectedItem)
        {
            List<string> columnNames;
            TableObject tableObject = tableReader.GetTableObjectByName((string)selectedItem);
            if (tableObject == null)
                return new List<string>();
            else
                columnNames = tableObject.ColumnNames;
            return columnNames;
        }

    }
}
