using System;

namespace ArrayPrint
{
    class ExecMethod : Program29
    {
        public int[] arrayExample;
        public ExecMethod()
        {
            this.randExecute();
        }
        public void randExecute()
        {
            for (int i = 0; i < 8; i++) 
            {
                Array.Resize(ref this.arrayExample, (i + 1));
                this.arrayExample[i] = new Random().Next(this.firstNum, this.upperNum);
            } 
        }
        public void printExecute() 
        {
            Console.WriteLine("Вы создали массив: ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{this.arrayExample[i]} ");
            }

        }
    }
}