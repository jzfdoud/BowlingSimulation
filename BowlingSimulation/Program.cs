using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace BowlingSimulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            //var frame = new List<int>(10);
            //for(var idx = 0; idx <10; idx++)
            //{
            var nbr = rnd.Next(0, 29);
            //    frame.Add(nbr);
            //}

            var frame = new List<int>();
            {
                frame.Add(nbr);
                frame.Add(nbr);
                frame.Add(nbr);
                frame.Add(nbr);
                frame.Add(nbr);
                frame.Add(nbr);
                frame.Add(nbr);
                frame.Add(nbr);
                frame.Add(nbr);
                frame.Add(nbr);
            }


            var Total = 0;

            foreach (var item in frame)
                {
                Total += item;
                }
            Console.WriteLine($"Score is {Total}.");


        }
    }
}
