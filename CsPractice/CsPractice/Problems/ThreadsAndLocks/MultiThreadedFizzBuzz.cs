using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CsPractice.Problems.ThreadsAndLocks
{
    public class MultiThreadedFizzBuzz
    {
        public List<string> OutputSet { get; set; }

        private object theLock = new object();
        private int number;

        private string theOutput;
        private string Output
        {
            get { return theOutput; }
            set
            {
                lock (theLock)
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        theOutput = value;
                    }
                    else if (value == "FizzBuzz")
                    {
                        theOutput = value;
                    }
                    else if ((value == "Fizz" || value == "Buzz") && theOutput != "FizzBuzz")
                    {
                        theOutput = value;
                    }
                    else if (String.IsNullOrEmpty(theOutput))
                    {
                        theOutput = value;
                    }
                }
            }
        }
        
        public List<string> RunTest(int n)
        {
            OutputSet = new List<string>();
            OutputSet.Add("dummy");

            for (int i = 1; i <= n; i++)
            {
                number = i;
                Output = "";
                Task fizzBuzzer = new Task(() => DoFizzBuzz());
                Task fizzer = new Task(() => DoFizz());
                Task buzzer = new Task(() => DoBuzz());
                Task numberCruncher = new Task(() => DoNumber());
                fizzBuzzer.Start();
                fizzer.Start();
                buzzer.Start();
                numberCruncher.Start();
                fizzBuzzer.Wait();
                fizzer.Wait();
                buzzer.Wait();
                numberCruncher.Wait();
                OutputSet.Add(Output);
            }

            return OutputSet;
        }

        private void DoFizzBuzz()
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Output = "FizzBuzz";
            }
        }

        private void DoFizz()
        {
            if (number % 3 == 0)
            {
                Output = "Fizz";
            }
        }

        private void DoBuzz()
        {
            if (number % 5 == 0)
            {
                Output = "Buzz";
            }
        }

        private void DoNumber()
        {
            Output = number.ToString();
        }
    }
}
