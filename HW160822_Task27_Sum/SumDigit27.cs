using System;

namespace SumOfDigits
{
    class Program27
    {
        public int firstNum = 0;
        public int upperNum = 1000000;
        static void Main(string[] args)
        {
            ExecMethod exec = new ExecMethod();
            Console.WriteLine($"Введено число {exec.numBer}");
            Console.WriteLine($"Сумма чисел {exec.sumofNumber}");
        }
    }
}