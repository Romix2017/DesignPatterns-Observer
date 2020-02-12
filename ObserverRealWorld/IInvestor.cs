using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverRealWorld
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
