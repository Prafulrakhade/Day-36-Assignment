using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using DemoOfThreading;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //public EmployeeDetails(int EmployeeID, string EmployeeName, string PhoneNumber, string Address,
        //string Department, char Gender, double BasicPay, double Salary, double Deduction,
        //     double TaxablePay, double Tax, string City, string Country)
        public void Given10Employee_WhenAdddedTOList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetail(EmployeeID: 1, EmployeeName: "Praful", PhoneNumber: "7894561235", Address: "Nagpur", Department: "HR", Gender: 'M', BasicPay: 100, Salary: 35000, Deduction: 2, TaxablePay: 20, NetPay: 400, Tax: 5, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetail(EmployeeID: 2, EmployeeName: "Mayur", PhoneNumber: "7894561235", Address: "Nagpur", Department: "HR", Gender: 'M', BasicPay: 100, Salary: 35000, Deduction: 2, TaxablePay: 20, NetPay: 400, Tax: 5, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetail(EmployeeID: 3, EmployeeName: "Trump", PhoneNumber: "7894561235", Address: "Nagpur", Department: "HR", Gender: 'M', BasicPay: 100, Salary: 35000, Deduction: 2, TaxablePay: 20, NetPay: 400, Tax: 5, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetail(EmployeeID: 4, EmployeeName: "Sagar", PhoneNumber: "7894561235", Address: "Nagpur", Department: "HR", Gender: 'M', BasicPay: 100, Salary: 35000, Deduction: 2, TaxablePay: 20, NetPay: 400, Tax: 5, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetail(EmployeeID: 5, EmployeeName: "Suraj", PhoneNumber: "7894561235", Address: "Nagpur", Department: "HR", Gender: 'M', BasicPay: 100, Salary: 35000, Deduction: 2, TaxablePay: 20, NetPay: 400, Tax: 5, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetail(EmployeeID: 6, EmployeeName: "Sonu", PhoneNumber: "7894561235", Address: "Nagpur", Department: "HR", Gender: 'M', BasicPay: 100, Salary: 35000, Deduction: 2, TaxablePay: 20, NetPay: 400, Tax: 5, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetail(EmployeeID: 7, EmployeeName: "Sonu", PhoneNumber: "7894561235", Address: "Nagpur", Department: "HR", Gender: 'M', BasicPay: 100, Salary: 35000, Deduction: 2, TaxablePay: 20, NetPay: 400, Tax: 5, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetail(EmployeeID: 8, EmployeeName: "Sonu", PhoneNumber: "7894561235", Address: "Nagpur", Department: "HR", Gender: 'M', BasicPay: 100, Salary: 35000, Deduction: 2, TaxablePay: 20, NetPay: 400, Tax: 5, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetail(EmployeeID: 9, EmployeeName: "Sonu", PhoneNumber: "7894561235", Address: "Nagpur", Department: "HR", Gender: 'M', BasicPay: 100, Salary: 35000, Deduction: 2, TaxablePay: 20, NetPay: 400, Tax: 5, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetail(EmployeeID: 10, EmployeeName: "Sonu", PhoneNumber: "7894561235", Address: "Nagpur", Department: "HR", Gender: 'M', BasicPay: 100, Salary: 35000, Deduction: 2, TaxablePay: 20, NetPay: 400, Tax: 5, City: "Banglore", Country: "India"));

            EmployeePayrollOperation employeePayrollOperation = new EmployeePayrollOperation();
            DateTime startDateTime = DateTime.Now;
            employeePayrollOperation.addEmployeePayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without Thread : " + (stopDateTime - startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            employeePayrollOperation.AddEmployeeToPayrollWithThread(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration With Thread" + (stopDateTimeThread - startDateTimeThread));
        }
    }
}
