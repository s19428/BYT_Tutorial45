using System;

namespace ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Chain chain1 = new AddNumbers();
            Chain chain2 = new SubstructNumbers();
            Chain chain3 = new DivideNumbers();
            Chain chain4 = new MultiplyNumbers();

            chain1.SetNextChain(chain2);
            chain2.SetNextChain(chain3);
            chain3.SetNextChain(chain4);

            Numbers numbers = new Numbers(6, 12, "-");
            chain1.Calculate(numbers);
        }
    }
}