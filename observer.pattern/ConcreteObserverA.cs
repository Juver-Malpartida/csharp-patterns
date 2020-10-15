using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer.pattern
{
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is Subject)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event. Value received is: " + ((Subject)subject).State);
            }
        }
    }
}
