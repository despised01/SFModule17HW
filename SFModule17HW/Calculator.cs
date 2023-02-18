using SFModule17HW;
using System;
using System.Text;

namespace SFModule17HW
{
    public class Calculator
    {
        public ICount count { get; }
        public double balance { get; set; }


        public Calculator(ICount count)
        {
            this.count = count;
        }

        public void Calculate()
        {
            count.CalculateInterest(balance);
        }
    }
}