using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Lab 10 Code");

    Employee unknown = new Employee();
    unknown.Intro();

    Employee robert = new Employee("Robert", "Downey", "12321", 12, 100, true);
    robert.Intro();

    Employee john = new Employee("John", "Smith", "S0089", 38, 50000, true);
    john.IncreaseSalary();
    john.RemoveEmployee();

    Employee maria = new Employee("Maria", "Lambert", "S0100", 26, 80000, true);
    maria.Intro();
    maria.IncreaseSalary();
    maria.RemoveEmployee();
    maria.RemoveEmployee();
  }
}