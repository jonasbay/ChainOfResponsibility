using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class SubtractNumbers : Chainlink
    { 
        private Chainlink nextInChain;

        public void SetNextChainlink(Chainlink c)
        { 
            nextInChain = c;
        }

        public void Calculate(Numbers request)
        {
            if (request.GetCalcWanted() == "subtract")
            {
                Console.WriteLine(request.GetNumber1() + " - " + request.GetNumber2() 
                                  + " = " + (request.GetNumber1() - request.GetNumber2()));
            }
            else
            {
                nextInChain.Calculate(request);
            }
        }
    }
}
