using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Division : Chainlink
    {
        private Chainlink nextInChain;

        public void setNextChainlink(Chainlink c)
        {
            nextInChain = c;
        }

        public void Calculate(Numbers request)
        {
            if (request.getCalcWanted() == "division")
            {
                try
                {
                    double result = request.getNumber1() / request.getNumber2();
                    Console.WriteLine(request.getNumber1() + " / " + request.getNumber2()
                    + " = " + result);
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine($"ArithmeticException handler: {e}");
                } 
                
            }
            else
                nextInChain.Calculate(request);
        }
    }
}
