using System;

namespace Exponent
{
    class ExecMethod : Program25
    {
        public int numberA;
        public int numberB;
        public int resultExp;
        public ExecMethod()
        {
            this.randExecute();
        }
        public void randExecute()
        {
            this.numberA = new Random().Next(this.firstNum, this.upperNum);
            this.numberB = new Random().Next(this.firstNum, this.upperNum);;
            
        }
        public void expExecute()
        {
            this.resultExp = 1;
            for (int i = 0; i < this.numberB; i++)
            {
                this.resultExp = this.resultExp * this.numberA;
            }
        }
    }
}