using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Employee
{
    private string employee_name;
    private double current_salary;
    public Employee(string employee_name, double current_salary)
    {
        this.employee_name = employee_name;
        this.current_salary = current_salary;
    }

    //Accessors
    public string getName()
    {
        return this.employee_name;
    }
    public double getSalary()
    {
        return this.current_salary;
    }

    //Mutators
    public void raiseSalary(double percentage)
    {
        double multiplier = (percentage / 100) + 1;
        this.current_salary = current_salary * multiplier;
    }

    //Tax
    public double Tax()
    {
        try
        {
            double remaining;
            remaining = this.current_salary;

            if (this.current_salary <= 18200)
            {
                return 0;
            }
            else if (this.current_salary <= 37000)
            {
                remaining -= 18200;
                return 0.19 * remaining;
            }
            else if (this.current_salary <= 90000)
            {
                remaining -= 37000;
                return (0.325 * remaining) + 3572;
            }
            else if (this.current_salary <= 180000)
            {
                remaining -= 90000;
                return (0.37 * remaining) + 20797;
            }
            else if (this.current_salary > 180000)
            {
                remaining -= 180000;
                return (0.45 * remaining) + 54096;
            }
            else
            {
                Console.WriteLine("Error");
                return 0;
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Error");
            return 0;
        }
        
    }
}
