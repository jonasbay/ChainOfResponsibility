using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Chainlink
            Chainlink chainlinkHead = new AddNumbers();
            Chainlink chainlink1 = new SubtractNumbers();
            Chainlink chainlink2 = new MultiplyNumbers();
            Chainlink chainlink3 = new DivideNumbers();

            //Linking links
            chainlinkHead.SetNextChainlink(chainlink1);
            chainlink1.SetNextChainlink(chainlink2);
            chainlink2.SetNextChainlink(chainlink3);

            //Creating numbers to calculate
            var subtract = new Numbers(5, 2, "subtract");
            var add = new Numbers(270, 430, "add");
            var multiply = new Numbers(2, 440, "multiply");
            var divideWithZero = new Numbers(5, 0, "divide");
            var divide = new Numbers(10, 2, "divide");

            //Requesting calculations
            chainlinkHead.Calculate(subtract);
            chainlinkHead.Calculate(add);
            chainlinkHead.Calculate(multiply);
            chainlinkHead.Calculate(divideWithZero);
            chainlinkHead.Calculate(divide);
        }
    }
}
