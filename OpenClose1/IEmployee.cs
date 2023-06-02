using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    internal interface IEmployee
    {
        string Fullname { get; set; }
        int HoursWorked { get; set; }

        abstract decimal CalculateSalaryMonthly();
    }
}
