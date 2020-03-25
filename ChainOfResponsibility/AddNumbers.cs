using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class AddNumbers : Chainlink
    {
        private Chainlink nextInChain;

        public void SetNextChainlink(Chainlink c)
        {
            nextInChain = c;
        }

        public void Calculate(Numbers request)
        {
            if (request.GetCalcWanted() == "add")
            {
                Console.WriteLine(request.GetNumber1() + " + " + request.GetNumber2()
                    + " = " + (request.GetNumber1() + request.GetNumber2()));
            }
            else
                nextInChain.Calculate(request);
        }
    }
} //Test fra Randi
