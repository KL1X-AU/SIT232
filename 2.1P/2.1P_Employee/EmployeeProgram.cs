class EmployeeProgram
{
    public static void Main(string[] args)
    {
        EmployeeProgram pr = new EmployeeProgram();
        Employee employee_01 = new Employee("Alfred", 18000.0);
        Employee employee_02 = new Employee("Bob", 25000.0);
        Employee employee_03 = new Employee("Charlie", 45000.0);
        Employee employee_04 = new Employee("Daniel", 120000.0);
        Employee employee_05 = new Employee("Eulyses", 200000.0);

        pr.checkEmployee(employee_01);
        pr.checkEmployee(employee_02);
        pr.checkEmployee(employee_03);
        pr.checkEmployee(employee_04);
        pr.checkEmployee(employee_05);

        employee_01.raiseSalary(40);
        pr.checkEmployee(employee_01);
    }

    //Function Returns Employee Information.
    public void checkEmployee(Employee employee)
    {
        Console.WriteLine($"Employee Name: \t\t{employee.getName()}");
        Console.WriteLine($"Employee Salary: \t{employee.getSalary()}");
        Console.WriteLine($"Employee Tax: \t\t{employee.Tax()}");
        Console.ReadLine();
    }
}