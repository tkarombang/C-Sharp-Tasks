using System;

class Employee
{
  private string Name;
  private string JobPosition;
  private int Salary;

  public Employee(string name, string jobPosition, int salary)
  {
    this.Name = name;
    this.JobPosition = jobPosition;
    this.Salary = salary;
  }

  public int GetSalary
  {
    get { return Salary; }
  }
}

class Company
{
  private string Name;
  private string Location;
  private int CompanyCash;
  private List<Employee> ArrEmployee;
  private int Month;

  public Company(string name, string location, int companyCash)
  {
    this.Name = name;
    this.Location = location;
    this.CompanyCash = companyCash;
    this.ArrEmployee = new List<Employee>();
    this.Month = 0;
  }

  public void AddEmployee(Employee objEmployee)
  {
    this.ArrEmployee.Add(objEmployee);
  }

  public int SetMonth
  {
    set
    {
      int totalMonthSalary = 0;
      foreach (Employee employee in this.ArrEmployee)
      {
        totalMonthSalary += employee.GetSalary;
      }

      this.CompanyCash -= totalMonthSalary * value;
      this.Month += value;

    }
  }


  public void GetCompanyStatus()
  {
    Console.WriteLine($"{this.Name} Sudah Berdiri Selama {this.Month} Bulan memiliki {this.ArrEmployee.Count} orang karyawan dengan Cash sebesar Rp{this.CompanyCash}");
  }
}


// class RecreateCompanyPt1
// {
//   static void Main(string[] args)
//   {
//     Company objCompany = new Company("PT Codingid", "Tangerang", 100000000);
// objCompany.SetMonth = 1;

//     objCompany.GetCompanyStatus();

//     Employee objEmployeeShodiq = new Employee("Shodiq", "Graphic Design", 5000000);
//     objCompany.AddEmployee(objEmployeeShodiq);

//     objCompany.GetCompanyStatus();

//     Employee objEmployeeDayat = new Employee("Dayat", "IT", 5000000);
//     objCompany.AddEmployee(objEmployeeDayat);
//     Employee objEmployeeAnwar = new Employee("Anwar", "Lead", 8000000);
//     objCompany.AddEmployee(objEmployeeDayat);

//     objCompany.SetMonth = 1;

//     objCompany.GetCompanyStatus();




//   }

// }