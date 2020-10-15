using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pub.sub.pattern1
{
    class Subject
    {
        public int State { get; set; }

        public event EventHandler<int> StateChange;

        public void SomeBusinessLogic() {
            Console.WriteLine("Starting state change");

            State = new Random().Next(0, 10);
            Thread.Sleep(5);

            Console.WriteLine("New State value" + State);
            OnStateChange();
        }

        public void OnStateChange()
        {
            StateChange(this, State);
        }
    }
}
