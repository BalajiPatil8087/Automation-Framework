using ClosedXML.Excel;
using System;
using System.Collections.Generic;
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
            string value=range.Cell(1,2).GetString();
            Console.WriteLine(value); 
         }
    }
}
