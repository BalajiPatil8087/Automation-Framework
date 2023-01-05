using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public  class Demo3Excel
    {
        [Test]
        public void DemoExcelRead()
        {

            XLWorkbook book=new XLWorkbook(@"C:\Users\patilbs\Desktop\C#\Automationframework\EmployeeManagement\TestData\orange_data.xlsx");
            IXLWorksheet sheet = book.Worksheet("InvalidLoginTest");
            IXLRange range= sheet.RangeUsed();


            //object[] arr = new object[2];//no of testcase

           
            for (int r = 2; r <= 4; r++)
            {
                for(int c = 1; c <= 3; c++)
                {
                    string value = range.Cell(r,c).GetString();
                    Console.WriteLine(value);
                }
            }
            book.Dispose();
         }
    }
}
