using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pub.sub.pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sjt = new Subject();
            var oba = new ObserverA();
            var obb = new ObserverB();

            sjt.StateChange += oba.OnStateChange;
            sjt.SomeLogin();

            sjt.StateChange += obb.OnStateChange;
            sjt.SomeLogin();

            sjt.StateChange -= oba.OnStateChange;
            sjt.SomeLogin();

            Console.ReadLine();
        }
    }
}
