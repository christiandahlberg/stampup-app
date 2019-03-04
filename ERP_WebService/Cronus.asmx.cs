using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Resources.DAL;
using Resources.Models;

namespace ERP_WebService
{
    /// <summary>
    /// Summary description for Cronus
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Cronus : System.Web.Services.WebService
    {

        private CronusDAL cronusDAL;
        private EmployeeDAL employeeDAL;

        public Cronus()
        {
            cronusDAL = new CronusDAL();
            employeeDAL = new EmployeeDAL();
        }

        [WebMethod]
        public List<Employee> GetEmployees()
        {
            return employeeDAL.GetEmployees();
        }

        [WebMethod]
        public Boolean RemoveEmployee(string no)
        {
            return employeeDAL.RemoveEmployee(no);
        }

        [WebMethod]
        public Boolean CreateEmployee(Employee emp)
        {
            return employeeDAL.CreateEmployee(emp);
        }

        [WebMethod]
        public List<Employee> GetSickEmployeesByYear(string year)
        {
            return employeeDAL.GetSickEmployeesByYear(year);
        }

        [WebMethod]
        public List<Relative> GetRelatives(string empNo)
        {
            return employeeDAL.GetRelatives(empNo);
        }

        [WebMethod]
        public Boolean UpdateEmployee(Employee emp)
        {
            return employeeDAL.UpdateEmployee(emp);
        }

        [WebMethod]
        public List<string> GetColumnNames(string tableName)
        {
            return cronusDAL.GetColumnNames(tableName);
        }

        [WebMethod]
        public List<string> GetTableNames()
        {
            return cronusDAL.GetTableNames();
        }

        [WebMethod]
        public List<MetadataItem> GetIndexes(string tableName)
        {
            return cronusDAL.GetIndexes(tableName);
        }

        [WebMethod]
        public List<MetadataItem> GetConstraints(string tableName)
        {
            return cronusDAL.GetConstraints(tableName);
        }

        [WebMethod]
        public string GetEmployeeNameMostAbsence()
        {
            return employeeDAL.GetEmployeeNameMostAbsence();
        }

        [WebMethod]
        public List<string[]> GetTableContent(string tableName)
        {
            return cronusDAL.GetTableContent(tableName);
        }
    }
}
