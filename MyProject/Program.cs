using System;
using System.Collections.Generic;

namespace MyProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> family = new List<string>() { "Jonathna", "Miriane", "Pedro", "Serena" };

            var index = family.FindIndex(x => x[0] == 'M');

            family.Insert(index + 1, "Bernado");

            foreach (var names in family)
                Console.WriteLine(names);
            //string filho;
            //filho = list.Find(x => x[0] == 'P');

            //Console.WriteLine(filho);
            Console.WriteLine("------------------------------");

            List<string> family2 = family.FindAll(x => x[0] !=('B'));
            foreach(var names in family2)
                Console.WriteLine(names);

            Console.WriteLine("------------------------------");

            family.Add("Mabel");
            foreach (var names in family)
                Console.WriteLine(names);


            Console.WriteLine("------------------------------");
            family.RemoveAll(x => x == "Mabel"); 
            foreach (var names in family)
                Console.WriteLine(names);


            Console.WriteLine("------------------------------");
            family.RemoveAt(index +1);
            foreach (var names in family)
                Console.WriteLine(names);
            family.Add("JUdéianla");
            family.Add("Peter");


            Console.WriteLine("------------------------------");
            family.RemoveRange(2,4);
            foreach (var names in family)
                Console.WriteLine(names);
        }
    }
}
