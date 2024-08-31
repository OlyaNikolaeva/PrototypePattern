namespace PrototypePattern;

class Program
{
    static void Main(string[] args)
    {
        // Создаем объекты
        Employee employee = new Employee("Alice", "Analyst", 50000);
        Manager manager = new Manager("Bob", "Project Manager", 80000, 10, "IT");
        Engineer engineer = new Engineer("Charlie", "Software Engineer", 70000, "Backend", "Senior");
        Intern intern = new Intern("Dave", "Intern", 20000, "MIT", 6);

        // Клонируем объекты
        Employee clonedEmployee = employee.MyClone();
        Manager clonedManager = (Manager)manager.MyClone();
        Engineer clonedEngineer = (Engineer)engineer.MyClone();
        Intern clonedIntern = (Intern)intern.MyClone();

        // Выводим результаты
        Console.WriteLine(clonedEmployee);
        Console.WriteLine(clonedManager);
        Console.WriteLine(clonedEngineer);
        Console.WriteLine(clonedIntern);
    }
}
