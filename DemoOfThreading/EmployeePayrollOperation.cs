using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoOfThreading
{
    public class EmployeePayrollOperation
    {
        public List<EmployeeDetails> employeepayrollDetailList = new List<EmployeeDetails>();
        private List<EmployeeDetails> employeeData;
        private bool employeepayrollDetaList;

        public void addEmployeePayroll(List<EmployeeDetails> employeepayrollDetaList)
        {
            employeepayrollDetailList.ForEach(employeeData =>
            {
                Console.WriteLine("Employee Being Added : " + employeeData.EmployeeName);
                this.addEmployeePayroll(employeeData);
                Console.WriteLine("Employee Added : " + employeeData.EmployeeName);
            });
            Console.WriteLine(this.employeepayrollDetaList.ToString());
        }
        public void AddEmployeeToPayrollWithThread(List<EmployeeDetails> employeepayrollDetaList)
        {
            employeepayrollDetaList.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                    {
                        Console.WriteLine("Employee Being Added : " + employeeData.EmployeeName);
                        this.addEmployeePayroll(employeeData);
                        Console.WriteLine("Employee Added : " + employeeData.EmployeeName);
                    });
                thread.Start();
            });
            Console.WriteLine(this.employeepayrollDetailList.Count);
        }
        public void addEmployeePayroll(EmployeeDetails emp)
        {
            employeepayrollDetailList.Add(emp);
        }
    }
}
