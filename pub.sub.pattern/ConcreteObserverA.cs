using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pub.sub.pattern
{
    class ConcreteObserverA
    {
        internal void StateChangeEventHandler(object sender, int e)
        {
            Console.WriteLine("ConcreteObserverA: Reacted to the event. Value received is: " + e);
        }
    }
}
