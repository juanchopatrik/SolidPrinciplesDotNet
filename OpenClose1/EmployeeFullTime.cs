namespace OpenClose
{
<<<<<<< Updated upstream
    public class EmployeeFullTime : Employee
    {
=======
    public class EmployeeFullTime : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
>>>>>>> Stashed changes
        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

<<<<<<< Updated upstream
        public override decimal CalculateSalaryMonthly()
=======
        public  decimal CalculateSalaryMonthly()
>>>>>>> Stashed changes
        {
            decimal hourValue = 30000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}