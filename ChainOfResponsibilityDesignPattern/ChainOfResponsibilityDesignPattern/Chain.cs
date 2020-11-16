using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public interface Chain
    {
        public void SetNextChain(Chain nextChain);
        public void Calculate(Numbers request);
    }
}
