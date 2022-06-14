using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOfThreading
{
    public class EmployeePayrollOperation
    {
        public List<EmployeeDetails> employeepayrollDetailList= new List<EmployeeDetails>();

        public void addEmployeePayroll(List<EmployeeDetails> employeepayrollDetaList)
        {
            employeepayrollDetailList.ForEach(employeeData =>
            {
                Console.WriteLine("Employee Being Added : " + employeeData.EmployeeName);
                this.addEmployeePayroll(employeeData);
                Console.WriteLine("Employee Added : " + employeeData.EmployeeName);
            });
        }

        public void addEmployeePayroll(EmployeeDetails emp)
        {
            employeepayrollDetailList.Add(emp);
        }
    }
}
