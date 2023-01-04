using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public  class DemoTest
    {
        public static object[] DemoValidData()
        {
            string[] dataset1 = new string[2];
            dataset1[0] = "John";
            dataset1[1] = "John123";

            string[] dataset2 = new string[2];
            dataset1[0] = "peter";
            dataset1[1] = "peter123";

            string[] dataset3 = new string[2];
            dataset1[0] = "saul";
            dataset1[1] = "saul123";

            object[] alldataset=new object[3];//no of testcase

            alldataset[0] = dataset1;
            alldataset[1] = dataset2;
            alldataset[2] = dataset3;

            return alldataset;
        }
        [Test,TestCaseSource(nameof(DemoValidData))]
        public void DemoValidLogin(string username, string password)
        {
            Console.WriteLine("Hello " + username + password);
        }
    }
}
