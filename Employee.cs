using System;

class Employee
{
  private int age;
  private double yearlysalary;
  private bool EmployeeStatus;

  public string FirstName{get; set;}
  public string LastName{get; set;}
  public string Id{get; set;}


  public int Age
  {
    get{return age;}
    set
    {
      if (value <= 18)
      {
        age = 18;
      }
      else
      {
        age = value;
      }
    }
  }

  public double YearlySalary
  {
    get{return yearlysalary;}
    set
    {
      if (value <= 1000)
      {
        yearlysalary = 1000;
      }
      else
      {
        yearlysalary = value;
      }
    }
  }

  public Employee()
  {
    FirstName = "Unknown";
    LastName = "Unknown";
    Id = Convert.ToString("Unknown");
    age = 0;
    Console.WriteLine("A new employee has been created");
  }

  public Employee(string employeefirstname, string employeelastname, string employeeid, int employeeage, double employeesalary, bool employmentstatus)
  {
    FirstName = employeefirstname;
    LastName = employeelastname;
    Id = employeeid;
    Age = employeeage;
    YearlySalary = employeesalary;
    EmployeeStatus = employmentstatus;
  }

  public void IncreaseSalary()
  {
    Console.WriteLine("Enter Salary Increase Percentage");
    double percent = Convert.ToDouble(Console.ReadLine());

    if (percent <= 0)
    {
      Console.WriteLine("Invalid or 0 Percent Increase - Salary Not Updated");
    }
    else
    {
      double newsalary = (percent * yearlysalary * .01) + yearlysalary;
      Console.WriteLine("Salary Updated To - " + newsalary);
    }
  }

  public void Intro()
  {
    Console.WriteLine("First Name - " + FirstName);
    Console.WriteLine("Last Name - " + LastName);
    Console.WriteLine("ID - " + Id);
    Console.WriteLine("Age - " + age);
    Console.WriteLine("Salary - " + YearlySalary);
    if (EmployeeStatus == true)
    {
      Console.WriteLine("Employment Status - Active");
    }
    else
    {
      Console.WriteLine("Employment Status - Inactive");
    }
  }

  public void RemoveEmployee()
  {
    if (EmployeeStatus == false)
    {
      Console.WriteLine("Employee already inactive");
    }
    if (EmployeeStatus == true)
    {
      Console.WriteLine("Employee removed");
      EmployeeStatus = false;
    }
  }
}