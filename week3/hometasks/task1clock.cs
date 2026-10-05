using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1clock
{
    class clocktype
    {
        public int hr;
        public int min;
        public int sec;
        public clocktype(int hr, int min, int sec)
        {
            this.hr = hr;
            this.min = min;
            this.sec = sec;
        }

        public void printtime()
        {
            Console.WriteLine("the time is {0}:{1}:{2}", hr, min, sec);

        }
        public void incrementbysec()
        {
            sec++;
            if (sec >= 60)
            {
                incrementbymin();
            }
        }
        public void incrementbymin()
        {
            min++;
            if (min >= 60)
            {
                incrementbyhr();
            }
        }
        public void incrementbyhr()
        {
            hr++;
            if (hr >= 24)
            {
                hr = hr - 24;
            }
        }
        public bool equaltime(clocktype other)
        {
            if(hr == other.hr && min == other.min && sec == other.sec)
            {
                return true;
            }
            return false;
        }
        public int elapsedseconds()
        {
            int elapsedseconds = (hr * 3600) + (min * 60) + sec;
            return elapsedseconds;
        }
        public int remseconds()
        {
            int remainingseconds = (24*3600) - elapsedseconds();
            return remainingseconds;
        }
        public int timedifference(clocktype other)
        {
            int difference = elapsedseconds() - other.elapsedseconds();
            return difference ;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clocktype clock1 = new clocktype(10, 25, 40);

            Console.WriteLine("Clock 1:");
            clock1.printtime();

           

            clock1.incrementbysec();

            Console.WriteLine("\nAfter Incrementing Seconds:");
            clock1.printtime();

            clock1.incrementbymin();

            Console.WriteLine("\nAfter Incrementing Minutes:");
            clock1.printtime();

            clock1.incrementbyhr();

            Console.WriteLine("\nAfter Incrementing Hours:");
            clock1.printtime();

            clocktype clock2 = new clocktype(12, 30, 20);

            Console.WriteLine("\nClock 2:");
            clock2.printtime();

            // Compare clocks
            Console.WriteLine("\nAre Clock 1 and Clock 2 equal?");

            if (clock1.equaltime(clock2))
            {
                Console.WriteLine("Yes, both clocks have the same time.");
            }
            else
            {
                Console.WriteLine("No, clocks have different times.");
            }

            // Elapsed time
            Console.WriteLine("\nElapsed seconds of Clock 1:");
            Console.WriteLine(clock1.elapsedseconds());

            // Remaining time
            Console.WriteLine("\nRemaining seconds of Clock 1:");
            Console.WriteLine(clock1.remseconds());

            // Difference between clocks
            Console.WriteLine("\nDifference between Clock 1 and Clock 2:");
            Console.WriteLine(clock1.timedifference(clock2) + " seconds");



            Console.ReadLine();
        }
    }
}
