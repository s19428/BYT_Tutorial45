using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class Numbers
    {
        private int n1, n2;
        private string operation;

        public Numbers(int n1, int n2, string operation)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.operation = operation;
        }

        public int GetNumber1() { return n1; }
        public int GetNumber2(){ return n2; }
        public string GetOperation() { return operation; }
    }
}
