using System.Threading.Tasks;
using System.Threading;

namespace CsPractice.Problems.ThreadsAndLocks
{
    public class DiningPhilosophersSimulation
    {
        private int waitTimeBase;
        private int numberPhilosophers;
        private object[] chopsticks;

        public DiningPhilosophersSimulation(int numPhilosophers, int waitTimeBaseMs)
        {
            waitTimeBase = waitTimeBaseMs;
            numberPhilosophers = numPhilosophers;
            chopsticks = new object[numPhilosophers];
            for (int i = 0; i < numberPhilosophers; i++)
            {
                chopsticks[i] = new object();
            }
        }

        public bool StartSimulation(int numTimesToEat)
        {
            Task<bool>[] philosophers = new Task<bool>[numberPhilosophers];
            for (int i = 0; i < numberPhilosophers; i++)
            {
                int thisPhilosopher = i;
                philosophers[i] = new Task<bool>(() => Eat(thisPhilosopher));
            }

            bool overallResult = true;

            for (int i = 0; i < numTimesToEat; i++)
            {
                for (int j = 0; j < numberPhilosophers; j++)
                {
                    philosophers[j].Start();
                }
                for (int j = 0; j < numberPhilosophers; j++)
                {
                    overallResult = overallResult && philosophers[j].Result;
                }
            }

            return overallResult;
        }

        private bool Eat(int philosopher)
        {
            bool gotChopsticks = false;
            for (int i = 0; i < numberPhilosophers; i++)
            {
                if (GetLeftChopstick(philosopher))
                {
                    if (GetRightChopstick(philosopher))
                    {
                        gotChopsticks = true;
                        break;
                    }
                    else
                    {
                        ReleaseLeftChopstick(philosopher);
                    }                    
                }
            }
            if (!gotChopsticks)
            {
                return false;
            }

            Thread.Sleep(waitTimeBase);
            ReleaseRightChopstick(philosopher);
            ReleaseLeftChopstick(philosopher);
            return true;
        }

        private bool GetLeftChopstick(int philosopher)
        {
            int chopstickToGet = philosopher - 1;
            if (chopstickToGet == -1)
            {
                chopstickToGet = chopsticks.Length - 1;
            }
            return Monitor.TryEnter(chopsticks[chopstickToGet], waitTimeBase);
        }
        private bool GetRightChopstick(int philosopher)
        {
            int chopstickToGet = philosopher + 1;
            if (chopstickToGet == chopsticks.Length)
            {
                chopstickToGet = 0;
            }
            return Monitor.TryEnter(chopsticks[chopstickToGet], waitTimeBase);
        }
        private void ReleaseLeftChopstick(int philosopher)
        {
            int chopstickToRelease = philosopher - 1;
            if (chopstickToRelease == -1)
            {
                chopstickToRelease = chopsticks.Length - 1;
            }
            Monitor.Exit(chopsticks[chopstickToRelease]);

        }
        private void ReleaseRightChopstick(int philosopher)
        {
            int chopstickToRelease = philosopher + 1;
            if (chopstickToRelease == chopsticks.Length)
            {
                chopstickToRelease = 0;
            }
            Monitor.Exit(chopsticks[chopstickToRelease]);
        }

    }
}
