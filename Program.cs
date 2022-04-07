using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Trucker 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicle volvo = new Truck(100,"green", 40);
            Console.WriteLine(volvo.ToString());
            Console.WriteLine(volvo.Honk);
            
            
            Console.ReadLine();
            
            


        }
        abstract class Vehicle
        {
            protected int horsePower;
            protected string color;

            protected Vehicle(int _horsepower, string _color)


            {
                horsePower = _horsepower;
                color = _color; 

            }

            public virtual int CalcSpeed()
            {
                

                var topspeed = horsePower *2;

                return topspeed;
                

            }
            public virtual void Honk()
            {
                Console.WriteLine("Hooonk hoonk!");
            }
            


        }

        class Truck: Vehicle
        {
            private int load;
            



            public Truck(int _horsepower, string _color, int _load) : base(_horsepower, _color)
            {
                horsePower = _horsepower;
                color = _color;
                load = _load;

            }

            public override int CalcSpeed()
            {
                
               var topspeed = horsePower + (load / 3) * 2;

                return topspeed;
                
            }
           public override string ToString()
            {
                string truck = string.Format(" The truck is loaded with : {0} KG.\n The color is of the truck is: {1}.\n Amount of horsepower: {2}.\n And the top speed is: {3}", load, color, horsePower, CalcSpeed());
                return truck;
                
            }   



        }

        






    }

  

    
        



    
}