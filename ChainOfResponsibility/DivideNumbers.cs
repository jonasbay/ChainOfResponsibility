using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class DivideNumbers : Chainlink
    {
        private Chainlink nextInChain;

        public void SetNextChainlink(Chainlink c)
        {
            nextInChain = c;
        }

        public void Calculate(Numbers request)
        {
            if (request.GetCalcWanted() == "divide")
            {
                try
                {
                    double result = request.GetNumber1() / request.GetNumber2();
                    Console.WriteLine(request.GetNumber1() + " / " + request.GetNumber2()
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
