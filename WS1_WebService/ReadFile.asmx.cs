using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;

namespace WS1_WebService
{
    /// <summary>
    /// Summary description for ReadFile
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ReadFile : System.Web.Services.WebService
    {

        [WebMethod]
        public string OpenFile(string filePath)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filePath, Encoding.Default, true))
                {
                    // Read the stream to a string, and write the string to the console.
                    return sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                return "The file could not be read:\n" + e.Message;
            }
            
        }
    }
}
