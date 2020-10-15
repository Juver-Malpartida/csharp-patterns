using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pub.sub.pattern2
{
    class ObserverA
    {
        internal void OnStateChange(object sender, int e)
        {
            Console.WriteLine("New value " + e);
        }
    }
}
