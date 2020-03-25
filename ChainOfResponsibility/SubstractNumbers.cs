using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class SubstractNumbers : Chainlink
    { 
        private Chainlink nextInChain;

        public void SetNextChainlink(Chainlink c)
        { 
            nextInChain = c;
        }

        public void Calculate(Numbers request)
        {
            if (request.GetCalcWanted() == "substract")
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
