using System;

namespace SumOfDigits
{
    class ExecMethod : Program27
    {
        public int numBer;
        public int counterDigit;
        public int sumofNumber = 0;
        public ExecMethod()
        {
            this.randExecute();
            this.findDigit();
            this.SumOfNumber();
        }
        public void randExecute()
        {
            int number = new Random().Next(this.firstNum, this.upperNum);
            this.numBer = number;
            
        }
        public void findDigit()
        {
            this.counterDigit = 0;
            while (this.numBer / Math.Pow(10, this.counterDigit + 1) > 1)
            {
                this.counterDigit++;
            }
        }
        public void SumOfNumber()
        {
            int fraction;
            int initialNumber = this.numBer;
            for (int i = 0; i < this.counterDigit + 1; i++)
            {
                fraction = Convert.ToInt32(initialNumber % 10);
                this.sumofNumber = this.sumofNumber + fraction;
                initialNumber = Convert.ToInt32(initialNumber / 10);
            }
        }
    }
}