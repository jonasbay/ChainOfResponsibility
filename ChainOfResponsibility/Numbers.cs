using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class Numbers
    {
        int Number1_;
        int Number2_;
        string CalculationWanted_;
        public Numbers(int n1, int n2, string calcW)
        {
            Number1_ = n1;
            Number2_ = n2;
            CalculationWanted_ = calcW;
        }

        public int getNumber1() { return Number1_; }
        public int getNumber2() { return Number2_; }
        public string getCalcWanted() { return CalculationWanted_; }
    }
}
//ds