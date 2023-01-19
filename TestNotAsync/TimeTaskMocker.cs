using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAsync
{
    internal class TimeTaskMocker
    {
        public void Work(int during)
        {
            Task.Delay(during * 1000).ContinueWith(task =>
            {
                Console.WriteLine("Work fini {0}", during);
            });
        }
    }
}
