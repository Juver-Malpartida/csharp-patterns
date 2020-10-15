using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pub.sub.pattern
{
    class Subject
    {
        public event EventHandler<int> StateChange;
        public int State { get; set; } = -0;
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.OnStateChange();
        }

        public void OnStateChange()
        {
            StateChange(this, State);
        }
    }
}
