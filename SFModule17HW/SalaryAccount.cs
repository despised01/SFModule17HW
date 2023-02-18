using System;
using System.Text;

namespace SFModule17HW
{
    public class SalaryAccount : ICount
    {
        public void CalculateInterest(double balance)
        {
            double interest = balance * 0.5;

            Console.WriteLine($"Процентная ставка зарплатного аккаунта: {interest}");
        }
    }
}
