namespace Liskov
{
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

<<<<<<< Updated upstream
        public  Employee(string fullname, int hoursWorked)
=======
        public  Employee(string fullname, int hoursWorked )
>>>>>>> Stashed changes
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public abstract decimal CalculateSalary();
    }
}