using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class AddNumbers
    {
        private Chainlink nextInChain;

        public void setNextChainlink(Chainlink c)
        {
            nextInChain = c;
        }

        public void Calculate(Numbers request)
        {
            if (request.getCalcWanted() == "add")
            {
                Console.WriteLine(request.getNumber1() + " + " + request.getNumber2()
                    + " = " + (request.getNumber1() + request.getNumber2()));
            }
            else
                nextInChain.Calculate(request);
        }
    }
} //Test fra Randi
