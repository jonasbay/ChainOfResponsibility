using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class MultiplyNumbers : Chainlink
    {
        private Chainlink nextInChain;

        public void SetNextChainlink(Chainlink c)
        {
            nextInChain = c;
        }

        public void Calculate(Numbers request)
        {
            if (request.GetCalcWanted() == "multiply")
            {
                Console.WriteLine(request.GetNumber1() + " × " + request.GetNumber2()
                                  + " = " + (request.GetNumber1() * request.GetNumber2()));
            }
            else
                nextInChain.Calculate(request);
        }
    }
}
