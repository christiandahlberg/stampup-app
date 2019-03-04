using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.Models
{
    public class MetadataItem
    {

        public string ColumnName { get; set; }
        public string ConstraintName { get; set; }
        public string ConstraintType { get; set; }
        public string IndexName { get; set; }
        public string IndexType { get; set; }
        public bool IsUnique { get; set; }
        public string TableName { get; set; }

        public MetadataItem() { }

        public MetadataItem(string columnName, string constraintName, string constraintType)
        {
            ColumnName = columnName;
            ConstraintName = constraintName;
            ConstraintType = constraintType;
        }
    }
}
