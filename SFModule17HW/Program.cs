using System;
using System.Text;

namespace SFModule17HW
{
    class Program
    {
        static void Main(string[] args)
        {
            ICount countRegularAccount = new RegularAccount();
            ICount countSalaryAccount = new SalaryAccount();

            Calculator calculatorRegular = new Calculator(countRegularAccount);
            Calculator calculatorSalary = new Calculator(countSalaryAccount);

            calculatorRegular.balance = 100000;
            calculatorRegular.Calculate();

            calculatorSalary.balance = 100000;
            calculatorSalary.Calculate();

        }
    }
}
