using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Utilities
{
    public class DataSource
    {
        public static object[] InValidLogin()
        {

            string[] dataset1 = new string[3];
            dataset1[0] = "John";
            dataset1[1] = "John123";
            dataset1[2] = "Invalid credentials";

            string[] dataset2 = new string[3];
            dataset2[0] = "peter";
            dataset2[1] = "peter123";
            dataset2[2] = "Invalid credentials";

            string[] dataset3 = new string[3];
            dataset3[0] = "saul";
            dataset3[1] = "saul123";
            dataset3[2] = "Invalid credentials";

            object[] alldataset = new object[3];//no of testcase

            alldataset[0] = dataset1;
            alldataset[1] = dataset2;
            alldataset[2] = dataset3;

            return alldataset;
        }
    }
}
