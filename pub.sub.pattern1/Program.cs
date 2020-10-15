using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pub.sub.pattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var oba = new ObserverA();
            var obb = new ObserverB();

            subject.StateChange += oba.StateChangeHandler;
            subject.SomeBusinessLogic();
            subject.StateChange += obb.StateChangeHandler;
            subject.SomeBusinessLogic();
            subject.StateChange -= oba.StateChangeHandler;
            subject.SomeBusinessLogic();
            Console.ReadLine();
        }
    }
}
