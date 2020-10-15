using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pub.sub.pattern1
{
    class ObserverA
    {
        internal void StateChangeHandler(object sender, int e)
        {
            Console.WriteLine("ConcreteObserverA: Reacted to the event. Value received is: " + e);
        }
    }
}
