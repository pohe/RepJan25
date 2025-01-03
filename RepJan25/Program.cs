// See https://aka.ms/new-console-template for more information
using RepJan25;

Console.WriteLine("Hello, World!");


Employee e1 = new Employee(20000, 1, "Peter", "121212");
Console.WriteLine("Salary " + e1.CalculateSalary() );
Console.WriteLine(e1.ToString() );
Teacher t1 = new Teacher("Systemudvikling", 20000, 2, "Kurt", "13131313");
Console.WriteLine("Salary " + t1.CalculateSalary());
Console.WriteLine(t1.ToString() );
