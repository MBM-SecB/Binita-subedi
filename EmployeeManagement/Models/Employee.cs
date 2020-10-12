
using System.Collections.Generic;

public class Employee
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; }
    public double Salary { get; set; }

    public static List<Employee> GetEmployees()
    {
        // Object initializer
        var employee1 = new Employee { FirstName = "Binita", Surname = "Subedi", Address = "Kathmandu", Salary = 10000.0 };
        var employee2 = new Employee { FirstName = "Hari", Surname = "K.c", Address = "Bhaktapur", Salary = 10000.0 };
        var employee3 = new Employee { FirstName = "Sushant", Surname = "Sharma", Address = "Thankot", Salary = 13000.0 };
        var employee4 = new Employee { FirstName = "Saurav", Surname = "Bhusal", Address = "Lalitpur", Salary = 12000.0 };
        var employee5 = new Employee { FirstName = "Binay", Surname = "Subedi", Address = "Ktm", Salary = 100.0 };
        var employee6 = new Employee { FirstName = "Sabita", Surname = "Sitaula", Address = "Jhapa", Salary = 15000.0 };

        var employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6 };
        return employees;     
    }
}