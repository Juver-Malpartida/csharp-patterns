using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pub.sub.pattern
{
    class ConcreteObserverB
    {
        public void StateChangeEventHandler(Object sender, int state)
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event. Value received is: " + state);
        }
    }
}
