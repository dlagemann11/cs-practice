using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CsPractice.Problems.ThreadsAndLocks
{
    public class InOrderCaller
    {
        public List<string> RunTest()
        {            
            SharedResource resource = new SharedResource();
            Task firstCaller = new Task(() => resource.First());
            Task secondCaller = new Task(() => resource.Second());
            Task thirdCaller = new Task(() => resource.Third());

            firstCaller.Start();
            secondCaller.Start();
            thirdCaller.Start();

            firstCaller.Wait();
            secondCaller.Wait();
            thirdCaller.Wait();

            return resource.CallOrder;
        }
    }

    public class SharedResource
    {
        public List<string> CallOrder { get; set; }
        AutoResetEvent firstCall = new AutoResetEvent(false);
        AutoResetEvent secondCall = new AutoResetEvent(false);

        public SharedResource()
        {
            CallOrder = new List<string>();
        }

        public void First()
        {
            CallOrder.Add("First");
            firstCall.Set();
        }

        public void Second()
        {
            firstCall.WaitOne();
            CallOrder.Add("Second");
            secondCall.Set();
        }

        public void Third()
        {
            secondCall.WaitOne();
            CallOrder.Add("Third");
        }
    }
}
