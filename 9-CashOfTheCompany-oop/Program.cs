using System;
namespace _9_CashOfTheCompany_oop
{
  class Program
  {
    public static void Main(string[] args)
    {
      Company objCompany = new Company("PT Codingid", "Tangerang", 100000000);

      objCompany.GetCompanyStatus();


      Employee objEmployeeShodiq = new Employee("Shodiq", "Graphic Design", 5000000);
      objCompany.AddEmployee(objEmployeeShodiq);
      
      objCompany.SetMonth = 1;

      objCompany.GetCompanyStatus();

      Employee objEmployeeDayat = new Employee("Dayat", "IT", 5000000);
      objCompany.AddEmployee(objEmployeeDayat);
      Employee objEmployeeAnwar = new Employee("Anwar", "Lead", 8000000);
      objCompany.AddEmployee(objEmployeeDayat);

      objCompany.SetMonth = 1;

      objCompany.GetCompanyStatus();


    }
  }
}