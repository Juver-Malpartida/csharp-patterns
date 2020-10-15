using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer.pattern
{
    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is Subject)
            {
                Subject subject1 = (Subject)subject;
                Console.WriteLine("ConcreteObserverB: Reacted to the event. Value received is: " + subject1.State);
            }
        }
    }
}
