using ChallangeApp;

Employee employee1 = new Employee("Michał", "Walencik", 32, 0);
Employee employee2 = new Employee("Adam", "Kamizelich", 40, 0);
Employee employee3 = new Employee("Bartek", "Karski", 33, 0);

employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(8);

employee2.AddScore(8);
employee2.AddScore(9);
employee2.AddScore(4);
employee2.AddScore(6);

employee3.AddScore(4);
employee3.AddScore(10);
employee3.AddScore(8);
employee3.AddScore(2);

List<Employee> employees = new List<Employee>()
{employee1, employee2, employee3};
 
int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee; 
    }
}

Console.WriteLine("Imię:" + employeeWithMaxResult.Name);
Console.WriteLine("Nazwisko:" + employeeWithMaxResult.Surname);
Console.WriteLine("wiek:" + employeeWithMaxResult.Age);
Console.WriteLine("wynik:" + employeeWithMaxResult.Result); 