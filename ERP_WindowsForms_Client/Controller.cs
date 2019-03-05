using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_WindowsForms_Client.ServiceReference;

namespace ERP_WindowsForms_Client
{
    class Controller
    {
        private ERP_WindowsForms_Client.ServiceReference.CronusSoapClient proxy;

        public Controller()
        {
            proxy = new ERP_WindowsForms_Client.ServiceReference.CronusSoapClient();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = proxy.GetEmployees().ToList();
            return employees;
        }

        public Boolean CreateEmployee(Employee employee)
        {
            return proxy.CreateEmployee(employee);
        }

        public Employee SearchEmployee(string no)
        {
            foreach (Employee employee in proxy.GetEmployees())
            {
                if (employee.No.Equals(no))
                {
                    return employee;
                }
            }
            return null;
        }

        public Boolean UpdateEmployee(Employee employee)
        {
            return proxy.UpdateEmployee(employee);
        }

        public Boolean RemoveEmployee(string no)
        {
            return proxy.RemoveEmployee(no);
        }

        public string GetSickestEmployee()
        {
            return proxy.GetEmployeeNameMostAbsence();
        }

        public Employee[] GetSickEmployeesByYear(string year)
        {
            return proxy.GetSickEmployeesByYear(year);
        }

        public List<List<string>> GetTableContent(string tableName)
        {
            List<List<string>> tableContent = proxy.GetTableContent(tableName).ToList<List<string>>();
            return tableContent;
        }

        public List<string> GetColumnNames(string tableName)
        {
            return proxy.GetColumnNames(tableName).ToList();
        }

        public List<string> GetTableNames()
        {
            return proxy.GetTableNames();
        }

        public MetadataItem[] GetConstraints(string tableName)
        {
            return proxy.GetConstraints(tableName);
        }

        public MetadataItem[] GetIndexes(string tableName)
        {
            return proxy.GetIndexes(tableName);
        }

        public Relative[] GetRelatives(string no)
        {
            return proxy.GetRelatives(no);
        }
    }
}
