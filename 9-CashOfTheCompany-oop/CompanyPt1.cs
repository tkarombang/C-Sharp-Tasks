using System;
using System.Collections.Generic;
namespace _9_CashOfTheCompany_oop
{

    // class Employee
    // {
    //     private string name;
    //     private string jobPosition;
    //     private int salary;

    //     public Employee(string name, string jobPosition, int salary)
    //     {
    //         this.name = name;
    //         this.jobPosition = jobPosition;
    //         this.salary = salary;
    //     }

    //     public int GetSalary
    //     {
    //         get { return salary; }
    //     }
    // }

    // class Company
    // {
    //     private string name;
    //     private string location;
    //     private int companyCash;
    //     private List<Employee> arrEmployee;
    //     private int month;

    //     public Company(string name, string location, int companyCash)
    //     {
    //         //Complete code here
    //         this.name = name;
    //         this.location = location;
    //         this.companyCash = companyCash;
    //         this.arrEmployee = new List<Employee>(); // Inisialisasi awal array dari object employee
    //         this.month = 0; // Inisialisasi awal nilai bulan menjadi 0
    //     }

    //     // Tambahkan 1 object employee ke dalam attribute array employee
    //     public void AddEmployee(Employee objEmployee)
    //     {
    //         //Complete code here
    //         this.arrEmployee.Add(objEmployee);
    //     }

    //     // Menambahkan bulan berjalan sesuai parameter yang dimasukkan
    //     public int SetMonth
    //     {
    //         set
    //         {

    //             // Menghtung total gaji bulanan dari semua karyawan saat ini
    //             int totalMonthSalary = 0;
    //             foreach (Employee employee in this.arrEmployee)
    //             {
    //                 totalMonthSalary += employee.GetSalary;
    //             }

    //             this.companyCash -= totalMonthSalary * value;
    //             CalculateCompanyCash();
    //             month += value;
    //         }

    //     }

    //     /*
    //         Print status company (ubah isi dari Console.WriteLine dan sesuaikan dengan expected output)
    //         Menghasilkan 1x print status perusahaan contoh : PT Coding.ID sudah berdiri selama 0 memiliki 0 orang karyawan dengan Cash sebesar Rp100000000
    //     */
    //     public void GetCompanyStatus()
    //     {
    //         Console.WriteLine($"{this.name} sudah berdiri selama {this.month} bulan memiliki {this.arrEmployee.Count} orang karyawan dengan Cash sebesar Rp{this.companyCash}");
    //     }

    //     // Menghitung ulang cash yang dimiliki perusahaan sesuai dengan bulan berjalan saat ini
    //     // Perusahaan diharuskan membayar gaji bulanan semua karyawan sesuai dengan jumlah bulan berjalan
    //     private void CalculateCompanyCash()
    //     {
    //         // Complete code here

    //     }
    // }

    // class CompanyPt1
    // {
    //     static void Main(string[] args)
    //     {
    //         // Membuat perusahaan baru
    //         Company objCompany = new Company("PT Coding.ID", "Tangerang", 100000000);

    //         // Print status perusahaan
    //         objCompany.GetCompanyStatus();

    //         // Menambahkan satu karyawan
    //         Employee objEmployeeBadrun = new Employee("Badrun", "Fullstack Developer", 5000000);
    //         objCompany.AddEmployee(objEmployeeBadrun);

    //         // Bulan pertama perusahaan berjalan
    //         objCompany.SetMonth = 1;

    //         // Print status perusahaan
    //         objCompany.GetCompanyStatus();

    //         // Menambahkan 2 karyawan lagi
    //         Employee objEmployeeAni = new Employee("Ani", "Finance", 4500000);
    //         objCompany.AddEmployee(objEmployeeAni);

    //         Employee objEmployeeMurni = new Employee("Murni", "HR", 4500000);
    //         objCompany.AddEmployee(objEmployeeMurni);

    //         // Bulan kedua perusahaan berjalan
    //         objCompany.SetMonth = 1;

    //         // Print status perusahaan
    //         objCompany.GetCompanyStatus();
    //     }
    // }





}
