// See https://aka.ms/new-console-template for more information
using RepJan25;

Console.WriteLine("Hello, World!");


//Employee e1 = new Employee(20000, 1, "Peter", "121212");
Console.WriteLine("Salary " + e1.CalculateSalary() );
Console.WriteLine(e1.ToString() );
Teacher t1 = new Teacher("Systemudvikling", 20000, 2, "Kurt", "13131313");
Console.WriteLine("Salary " + t1.CalculateSalary());
Console.WriteLine(t1.ToString() );
Secreatary s1 = new Secreatary(true, 20000, 3, "Jan", "34343434");
Console.WriteLine("Salary " + s1.CalculateSalary());
Console.WriteLine(s1.ToString());

//Polymorfi (Flere former)

//Erklæret type       Aktuelle type
//Employee ep = new Employee(23000, 7, "Jens", "343434");
Employee ep;
//Console.WriteLine(ep.CalculateSalary());
//Console.WriteLine($"Name {ep.Name}");
ep = new Teacher("Systemudvikling", 23000, 7, "Jens", "343434");
Console.WriteLine(ep.CalculateSalary()); //Den aktuelle type bestemmer hvilken virtual/overriden metode der kaldes
Console.WriteLine($"Name {ep.Name}");
//Console.WriteLine($"Subject {ep.Subject}"); //Den erklærede type bestemmer hvad der kan kaldes

List<Employee> employees = new List<Employee>();
//employees.Add(e1);
employees.Add(t1);
employees.Add(s1);
employees.Add(ep);

foreach(Employee emp in employees)
{
    //Console.WriteLine(emp.ToString());
    Console.WriteLine($"Pension {emp.CalculatePension()}");
}
