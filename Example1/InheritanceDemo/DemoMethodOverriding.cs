using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Base
    {
        public string FirstName { get; set; }
        public decimal hourlyRate { get; set; }

        public decimal total_salary;
        public virtual decimal employeeSalary(int workedHour)
        {
            total_salary = hourlyRate * workedHour;
            return total_salary;
        }
            
         
    }
    public class DemoMethodOverriding : Base
    {
        public decimal compensation = 3000;

        //we can not override base method intill base class declare as virtual
        public override decimal employeeSalary(int workedHour)
        {
            //to call base class method we need to use base keywork
            decimal actaulSalary = base.employeeSalary(workedHour) - compensation;
            return actaulSalary;
        }

    }
}
