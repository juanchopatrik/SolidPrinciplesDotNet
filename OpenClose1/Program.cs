using OpenClose;

<<<<<<< Updated upstream
ShowSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Manuel perez", 200)
});


void ShowSalaryMonthly(List<Employee> employees) 
{
    foreach (var employee in employees)
    {
     Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C1} ");
=======
ShowSalaryMonthly(new List<IEmployee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Juan Silva", 130)
});


void ShowSalaryMonthly(List<IEmployee> employees) 
{
    foreach (var employee in employees)
    {
            Console.WriteLine($"Empleado:    {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C1} ");
>>>>>>> Stashed changes
    }

}