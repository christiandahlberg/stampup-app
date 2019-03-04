using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK2_Client
{
    public class TableObject
    {
        public string TableName { get; set; }
        public int NumberOfRows { get; set; }
        public List<string> ColumnNames { get; set; }

        public TableObject(string tableName, int numOfRows, List<string> columnNames)
        {
            TableName = tableName;
            NumberOfRows = numOfRows;
            ColumnNames = columnNames;
        }

    }
}
