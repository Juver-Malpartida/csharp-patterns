using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pub.sub.pattern1
{
    class ObserverB
    {
        internal void StateChangeHandler(object sender, int e)
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event. Value received is: " + e);
        }
    }
}
