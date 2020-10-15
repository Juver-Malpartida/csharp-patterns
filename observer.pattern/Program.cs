using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer.pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();

            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            subject.SomeBusinessLogic();
            
            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();

            subject.Detach(observerA);

            subject.SomeBusinessLogic();

            Console.ReadLine();
        }
    }
}
