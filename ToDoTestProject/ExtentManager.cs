using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTestProject
{
    public class ExtentManager
    {

        private ExtentManager()
        {

        }

        private static ExtentReports extent;


        public static ExtentReports getInstance()
        {
            if (extent == null)
            {

                string filename = DateTime.Now.ToString().Replace(" ","").Replace("/","").Replace(":","") + ".html";
                extent = new ExtentReports("G:\\Reports\\" + filename, true);
                         
               
            }
            return extent;
        }
    }
}
