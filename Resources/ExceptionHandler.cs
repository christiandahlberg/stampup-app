using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Resources
{
    public abstract class GeneralCodes
    {
        public const string E_ABORT = "0x80004004";
        public const string E_ACCESSDENIED = "0x80070005";
        public const string E_FAIL = "0x80004005";
        public const string E_HANDLE = "0x80070006";
        public const string E_INVALIDARG = "0x80070057";
        public const string E_NOINTERFACE = "0x80004002";
        public const string E_NOTIMPL = "0x80004001";
        public const string E_OUTOFMEMORY = "0x8007000E";
        public const string E_POINTER = "0x80004003";
        public const string E_UNEXPECTED = "0x8000FFFF";
    }

    public abstract class SqlCodes
    {
        public const int PRIMARY_KEY = 2627;
        public const int FOREIGN_KEY = 547;
        public const int TRUNCATION_ERROR = 8152;
        public const int NULL_ERROR = 515;
        public const int NETWORK_ISSUE = -1;
    }

    public class ExceptionHandler
    {
        public static void HandleErrorException(Exception e)
        {
            if (e.GetType() == typeof(SqlException))
            {
                HandleSqlException(e as SqlException);
            }
            else
            {
                HandleGeneralException(e);
            }
        }

        private static void HandleSqlException(SqlException e)
        {
            string message = "ERROR: ";
            switch (e.Number)
            {
                case SqlCodes.PRIMARY_KEY:
                    message += "Primary key violation.";
                    break;
                case SqlCodes.FOREIGN_KEY:
                    message += "Foreign key violation.";
                    break;
                case SqlCodes.TRUNCATION_ERROR:
                    message += "Truncation error.";
                    break;
                case SqlCodes.NULL_ERROR:
                    message += "Null exception.";
                    break;
                case SqlCodes.NETWORK_ISSUE:
                    message += "Network issue.";
                    break;
                default:
                    message += e.Message;
                    throw e;
            }
            LogException(message, e);
        }

        private static void HandleGeneralException(Exception e)
        {
            string message = "ERROR: ";
            switch (e.HResult.ToString())
            {
                case GeneralCodes.E_ABORT:
                    message += "Operation was aborted.";
                    break;
                case GeneralCodes.E_ACCESSDENIED:
                    message += "General access denied.";
                    break;
                case GeneralCodes.E_FAIL:
                    message += "Unspecified failure.";
                    break;
                case GeneralCodes.E_HANDLE:
                    message += "Handle is not valid.";
                    break;
                case GeneralCodes.E_INVALIDARG:
                    message += "One or more arguments are not valid.";
                    break;
                case GeneralCodes.E_NOINTERFACE:
                    message += "No such interface supported.";
                    break;
                case GeneralCodes.E_NOTIMPL:
                    message += "Not implemented.";
                    break;
                case GeneralCodes.E_OUTOFMEMORY:
                    message += "Failed to allocate necessary memory.";
                    break;
                case GeneralCodes.E_POINTER:
                    message += "Pointer is not valid.";
                    break;
                case GeneralCodes.E_UNEXPECTED:
                    message += "Unexpected failure.";
                    break;
                default:
                    message += e.Message;
                    throw e;
            }
            LogException(message, e);
        }

        public static void LogException(string message, Exception e)
        {
            // Include enterprise logic for logging exceptions   
            // Get the absolute path to the log file   
            string logFile = "~/../../../Resources/ErrorLog.txt";

            // Open the log file for append and write the log  
            StreamWriter sw = new StreamWriter(logFile, true);
            sw.WriteLine("********** {0} **********", DateTime.Now);
            sw.WriteLine(message);
            sw.WriteLine(e.Message);
            sw.Close();
        }
    }
}
