using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer.pattern
{
    interface IObserver
    {
        void Update(ISubject subject);
    }
}
