using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface Chainlink
    {
        public void SetNextChainlink(Chainlink nextInChain);
        public void Calculate(Numbers request);
    }
}
