using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class RacingCar
    {
        public string carname;
        public float speed;
        public float acceleration;
        public int fuelLevel;
        public int damagelevel;
        public float position;
        public int lapcount ;
        public RacingCar(string carname , float speed , float acceleration , int fuelLevel, int damagelevel, float position , int lapcount)
        {
            this.carname = carname;
            this.speed = speed;
            this.acceleration = acceleration;
            this.fuelLevel = fuelLevel;
            this.damagelevel = damagelevel;
            this.position = position;
            this.lapcount = lapcount;
        }
        public void Accelerate()
        {
            if (fuelLevel <= 0 )
            {
                Console.WriteLine("No Enough fuel");
                return;
            }
            speed = speed + acceleration;
            fuelLevel -= 5;
            Console.WriteLine(carname + " accelerated.");
        }
        public void Move()
        {
            if (fuelLevel <= 0)
            {
                Console.WriteLine("No Enough fuel");
                return;
            }
            position = position + speed;
            fuelLevel -= 2;
            Console.WriteLine(carname + " moved to position " + position);


        }
        public void Collision()
        {
            damagelevel = damagelevel + 20;

            if (damagelevel > 100)
            {
                damagelevel = 100;
            }

            Console.WriteLine("Collision occurred!");
            Console.WriteLine("Damage Level: " + damagelevel);
        }
        public void Refuel(int amount)
        {
            fuelLevel = fuelLevel + amount;

            if (fuelLevel > 100)
            {
                fuelLevel = 100;
            }

            Console.WriteLine("Car refueled.");
        }
        public void Repair()
        {
            damagelevel = 0;

            Console.WriteLine("Car repaired successfully.");
        }


        public void CompleteLap()
        {
            lapcount++;
            Console.WriteLine("Lap completed!");
            Console.WriteLine("Total Laps: " + lapcount);
        }
        public void ShowStatus()
        {
            Console.WriteLine("\n===== CAR STATUS =====");
            Console.WriteLine("Car Name      : " + carname);
            Console.WriteLine("Speed         : " + speed);
            Console.WriteLine("Acceleration  : " + acceleration);
            Console.WriteLine("Fuel Level    : " + fuelLevel);
            Console.WriteLine("Damage Level  : " + damagelevel);
            Console.WriteLine("Position      : " + position);
            Console.WriteLine("Lap Count     : " + lapcount);
            Console.WriteLine("======================");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RacingCar car1 = new RacingCar(
                "Ferrari",
                50,
                10,
                100,
                0,
                0,
                0
            );

            car1.ShowStatus();

            car1.Accelerate();
            car1.Move();

            car1.Collision();

            car1.Move();

            car1.CompleteLap();

            car1.Refuel(30);

            car1.Repair();

            car1.ShowStatus();

            Console.ReadKey();
        }
    }
}
