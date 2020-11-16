using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class DivideNumbers : Chain
    {
        private Chain nextInChain;

        public void SetNextChain(Chain chain)
        {
            nextInChain = chain;
        }

        public void Calculate(Numbers numbers)
        {
            if (numbers.GetOperation() == "/")
            {
                Console.WriteLine("Result: " + (numbers.GetNumber1() / numbers.GetNumber2()));
            }
            else
            {
                nextInChain.Calculate(numbers);
            }
        }
    }
}