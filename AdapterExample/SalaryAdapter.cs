using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    internal class SalaryAdapter : SalaryCalc
    {
        private Employee emp;
        public double Calculate (Worker worker)
        {
            emp = new Employee();
            emp.basic_salary = worker.basic_salary;
            var result = base.Calc(emp);
            return result;
        }
    }
}
