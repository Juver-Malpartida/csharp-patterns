using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pub.sub.pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observera = new ConcreteObserverA();
            subject.StateChange += observera.StateChangeEventHandler;

            subject.SomeBusinessLogic();

            var observerb = new ConcreteObserverB();
            subject.StateChange += observerb.StateChangeEventHandler;

            subject.SomeBusinessLogic();

            subject.StateChange -= observera.StateChangeEventHandler;

            subject.SomeBusinessLogic();

            Console.ReadLine();
        }
    }
}
