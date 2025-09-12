using System;
namespace _10_CashOfTheCompany_oop2
{

  class Program
  {
    public static void Main(string[] args)
    {
      // Membuat perusahaan baru
      Company objCompany = new Company("PT Coding.ID", "Tangerang", 100000000);

      // Menambahkan karyawan
      Employee objEmployeeBadrun = new Employee("Badrun", "Fullstack Developer", 5000000);
      objCompany.AddEmployee(objEmployeeBadrun);

      // Bulan pertama perusahaan berjalan
      objCompany.SetMonth = 1;

      // Print status perusahaan
      objCompany.GetCompanyStatus();

      Employee objEmployeeAni = new Employee("Ani", "Finance", 4500000);
      objCompany.AddEmployee(objEmployeeAni);

      Employee objEmployeeMurni = new Employee("Murni", "HR", 4500000);
      objCompany.AddEmployee(objEmployeeMurni);


      // Bulan kedua perusahaan berjalan
      objCompany.SetMonth = 1;

      // Print status perusahaan
      objCompany.GetCompanyStatus();

      // Pada Bulan kedua prusahaan mendapatkan project pertama
      Project objProject1 = new Project("Website Company Profile", 10000000);
      objCompany.AddProject(objProject1);

      // Print status perusahaan
      objCompany.GetCompanyStatus();

      // Perusahaan menambahkan 2 karyawan lagi
      Employee objEmployeeTechLead = new Employee("Rey", "Technical Lead", 15000000);
      objCompany.AddEmployee(objEmployeeTechLead);

      Employee objEmployeeQAEngineer = new Employee("Rosna", "QA Engineer", 5000000);
      objCompany.AddEmployee(objEmployeeQAEngineer);



      // Bulan ketiga perusahaan berjalan
      objCompany.SetMonth = 1;

      // print status perusahaan
      objCompany.GetCompanyStatus();

      // Satu orang karyawan resign pada bulan ke empat
      objCompany.EmployeeResignByName("Badrun");

      // Bulan keempat perusahaan berjalan
      objCompany.SetMonth = 1;

      // Print status perusahaan
      objCompany.GetCompanyStatus();
      objCompany.GetCompanyProject();
      objCompany.GetCompanyEmployee();

    }
  }

}