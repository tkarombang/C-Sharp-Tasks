using System;
namespace _10_CashOfTheCompany_oop2
{
  class Project
  {
    private string Name;
    private int Price;

    public Project(string name, int price)
    {
      // Completed the code
      this.Name = name;
      this.Price = price;
    }

    // Uncomment method GetPrice dibawah ini dan lengkapi
    public int GetPrice
    {
      // Completed the code
      get { return Price; }
    }
    public string GetName
    {
      get { return Name; }
    }
  }

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

    public string GetName
    {
      get { return Name; }
    }
    public string GetPosition
    {
      get { return JobPosition; }
    }

  }

  class Company
  {
    private string Name;
    private string Location;
    private int CompanyCash;
    private List<Employee> ArrEmployee;
    private List<Project> ArrProject;
    private int Month;

    public Company(string name, string location, int companyCash)
    {
      this.Name = name;
      this.Location = location;
      this.CompanyCash = companyCash;
      this.ArrEmployee = new List<Employee>();
      this.Month = 0; // Bulan berjalan di set ke bulan 0
      this.ArrProject = new List<Project>();
    }

    public void AddEmployee(Employee objEmployee)
    {
      ArrEmployee.Add(objEmployee);
    }

    // Menambahkan bulan berjalan sesuai parameter yang dimasukkan
    public int SetMonth
    {
      set
      {
        Month += value;
        CalculateCompanyCash();
      }

    }

    public void GetCompanyProject()
    {
      Console.WriteLine("=========");
      foreach (Project allProject in ArrProject)
      {
        Console.WriteLine($"Nama: {allProject.GetName}");
      }
      Console.WriteLine("=========");
    }

    public void GetCompanyEmployee()
    {
      Console.WriteLine("=========");
      foreach (Employee allEmployee in ArrEmployee)
      {
        Console.WriteLine($"Nama: {allEmployee.GetName} | Posisi: {allEmployee.GetPosition} | {allEmployee.GetSalary}");
      }
      Console.WriteLine("=========");
    }



    public void GetCompanyStatus()
    {
      Console.WriteLine($"{Name} sudah berdiri selama {Month} Bulan, memiliki {ArrEmployee.Count} orang karyawan dengan Cash sebesar Rp{CompanyCash}");
    }


    // Menghitung ulang cash yang dimiliki perusahaan sesuai dengan bulan berjalan saat ini
    // Perusahaan diharuskan membayar gaji bulanan semua karyawan sesuai dengan jumlah bulan berjalan
    private void CalculateCompanyCash()
    {
      // Menghitung semua total gaji karyawan
      int total = 0;
      foreach (Employee employee in ArrEmployee)
      {
        total += employee.GetSalary;
      }

      CompanyCash -= total;
    }

    // Add project to company and add cash based on price of the project
    public void AddProject(Project objProject)
    {
      // Completed the code
      ArrProject.Add(objProject);
      CompanyCash += objProject.GetPrice;
    }

    //Keluarkan karyawan dari arrayEmployee berdasarkan nama yang dimasukan
    public void EmployeeResignByName(string employeeName)
    {
      // Completed the code
      ArrEmployee.RemoveAll(e => e.GetName == employeeName);
    }
  }


  // class RecreateCompanyPt2
  // {

  // }

}