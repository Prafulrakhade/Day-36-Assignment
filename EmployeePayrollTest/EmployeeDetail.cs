using DemoOfThreading;

namespace EmployeePayrollTest
{
    internal class EmployeeDetail : EmployeeDetails
    {
        public EmployeeDetail(int EmployeeID, string EmployeeName, string PhoneNumber, string Address, string Department, char Gender, double BasicPay, double Salary, double Deduction, double TaxablePay, double Tax, double NetPay, string City, string Country) : base(EmployeeID, EmployeeName, PhoneNumber, Address, Department, Gender, BasicPay, Salary, Deduction, TaxablePay, Tax, NetPay, City, Country)
        {
        }
    }
}