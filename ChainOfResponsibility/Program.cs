using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating number to calculate
            var numbers = new Numbers(5,2, "subtract");

            //Creating Chain
            Chainlink chainlink1 = new AddNumbers();
            Chainlink chainlink2 = new SubtractNumbers();
            Chainlink chainlink3 = new MultiplyNumbers();
            Chainlink chainlink4 = new DivideNumbers();

            chainlink1.SetNextChainlink(chainlink2);
            chainlink2.SetNextChainlink(chainlink3);
            chainlink3.SetNextChainlink(chainlink3);
        }
    }
}
