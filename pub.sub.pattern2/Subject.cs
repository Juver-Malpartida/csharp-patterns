using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pub.sub.pattern2
{
    class Subject
    {
        private int State;
        public event EventHandler<int> StateChange;
        public void SomeLogin()
        {
            Console.WriteLine("Starting logic");
            State = new Random().Next(0, 10);
            Thread.Sleep(2000);
            StateChange(this, State);
        }
    }
}
