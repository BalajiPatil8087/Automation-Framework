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

        public static object[] EmployeeData()
        {

            string[] dataset1 = new string[6];
            dataset1[0] = "Admin";
            dataset1[1] = "admin123";
            dataset1[2] = "John";
            dataset1[3] = "W";
            dataset1[4] = "wick";
            dataset1[5] = "John wick";



            string[] dataset2 = new string[6];
            
            dataset2[0] = "Admin";
            dataset2[1] = "admin123";
            dataset2[2] = "saul";
            dataset2[3] = "g";
            dataset2[4] = "goodman";
            dataset2[5] = "saul goodman";

          
            object[] alldataset = new object[2];//no of testcase

            alldataset[0] = dataset1;
            alldataset[1] = dataset2;
         

            return alldataset;
        }
    }
}
