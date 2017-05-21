using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RelevantCodes.ExtentReports;

namespace ToDoTestProject
{
    [TestFixture]
    public class ToDoTest : BaseClass
    {

        public static ExcelReaderFile xls = null;
        public static string testCaseName = "ToDoTest";

        [Test, TestCaseSource("GetData")]
        public void TestToDo(Dictionary<String, String> data)
        {
            test = report.StartTest("ToDoTest", "Verifying the items have been added successfully functionality");

            try
            {
                //OpenBrowser(data["BROWSER"]);
                OpenBrowser("ie");
                NavigateTo("http://todomvc.com");
                
                
            }

            catch (Exception e)
            {
                ReportFail("Error while executing the test case : " + e.Message);
                Assert.Fail(e.Message);
            }

        }

        public static Object[] GetData()
        {
            xls = new ExcelReaderFile(FileLocation.TestDataFile);
            return DataUtil.getTestData(xls, testCaseName);
        }


        [TearDown]
        public void CloseAll()
        {
            report.EndTest(test);
            report.Flush();
            CloseBrowser();
        }


    }
}
