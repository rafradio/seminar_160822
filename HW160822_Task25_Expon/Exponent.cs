using System;

namespace Exponent
{
    class Program25
    {
        public int firstNum = 0;
        public int upperNum = 11;
        static void Main(string[] args)
        {
            Console.Clear();
            ExecMethod exec = new ExecMethod();
            exec.expExecute();
            Console.WriteLine($"{exec.numberA} в степени {exec.numberB} равняется {exec.resultExp}");
        }

    }
}