namespace Liskov
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked) : base(fullname, hoursWorked)
        {
        }
<<<<<<< Updated upstream

        public override decimal CalculateSalary ()
        {   
            decimal hourValue = 40;
            return hourValue * (HoursWorked);
        }
=======
        public  override decimal CalculateSalary()
        {
            decimal hourValue = 40;
            return hourValue * HoursWorked;
        }

>>>>>>> Stashed changes
    }
}