﻿using Liskov;

CalculateSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160, 10),
<<<<<<< Updated upstream
    new EmployeeContractor("Manuel Lopera", 180)
=======
    new EmployeeContractor("Manuel Lopera", 180 )
>>>>>>> Stashed changes
});

void CalculateSalaryMonthly(List<Employee> employees) 
{
    foreach (var item in employees)
    {
        decimal salary = item.CalculateSalary();
        Console.WriteLine($"The {item.Fullname}'s salary is {salary}");
        
    }
}