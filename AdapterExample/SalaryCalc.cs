using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    internal class SalaryCalc
    {
        public double Calc(Employee emp) 
        {
            emp.basic_salary = emp.basic_salary * 1.85;
            return emp.basic_salary;
        }
    }
        }
