namespace Liskov
{
    public class EmployeeFullTime : Employee
    {
<<<<<<< Updated upstream
        public int ExtraHours {get;set;}
=======
        public int ExtraHours { get; set; }
>>>>>>> Stashed changes
        public EmployeeFullTime(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked)
        {
            this.ExtraHours = extrahours;
        }
        public  override decimal CalculateSalary()
        {
            decimal hourValue = 50;
            return hourValue * (HoursWorked + ExtraHours);
        }

        public override decimal CalculateSalary ()
        {   
            decimal hourValue = 50;
            return hourValue * (HoursWorked + ExtraHours);
        }

    }
}