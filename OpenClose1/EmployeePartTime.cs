namespace OpenClose
{
<<<<<<< Updated upstream
    public class EmployeePartTime : Employee
    {
=======
    public class EmployeePartTime : IEmployee
    {

        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
>>>>>>> Stashed changes
        public EmployeePartTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

<<<<<<< Updated upstream
        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 20000M;
            decimal salary = hourValue * HoursWorked;
=======
        public decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 20000M;
            decimal salary = hourValue * HoursWorked;
            if (HoursWorked > 160) {
                decimal effortCompensation = 5000M;
                int extraDays = HoursWorked - 160;
                salary += effortCompensation * extraDays;
            }

>>>>>>> Stashed changes
            return salary;
        }
    }
}