// using System;
// namespace _10_CashOfTheCompany_oop2
// {
//   class Employee
//   {
//     private string Name;
//     private int Salary;

//     public Employee(string name, int salary)
//     {
//       this.Name = name;
//       this.Salary = salary;
//     }

//     public virtual int GetTotalSalary()
//     {
//       return Salary;
//     }
//   }


//   class Manager : Employee
//   {
//     private int Bonus;

//     public Manager(string name, int salary, int bonus) : base(name, salary)
//     {
//       this.Bonus = bonus;
//     }

//     public override int GetTotalSalary()
//     {
//       return base.GetTotalSalary() + Bonus;
//     }
//   }


//   class Company
//   {
//     // ... properti lainnya
//     private List<Employee> employees;

//     public Company()
//     {
//       this.employees = new List<Employee>();
//     }

//     public void AddEmployee(Employee employee)
//     {
//       this.employees.Add(employee);
//     }

//     // ...method dan properti lainya
//   }

// }