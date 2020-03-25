using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface Chainlink
    {
        public void setNextChainlink(Chainlink nextInChain);
        public void Calculate(Numbers request);
    }
}
