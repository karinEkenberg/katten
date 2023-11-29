using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        //övning 13.2
        class Katt
        {
            public string name;
            public string race;
            public int age;

            public void Mjau()
            {
                if (age < 1)
                    Console.WriteLine(name + " är en liten kattunge och mjauar jättemycket!");
                else
                    Console.WriteLine(name + " är en vuxen katt och mjauar lagom mycket!");
            }
            class program
            {
                static void Main(string[] args)
                {
                    Katt myKatt = new Katt();

                    myKatt.name = "Gulle";
                    myKatt.race = "bondkatt";
                    myKatt.age = 5;

                    Console.WriteLine("Katten heter " + myKatt.name + " och är en " + myKatt.race + " hen är " + myKatt.age + " år gammal.");
                    myKatt.Mjau();

                }
            }
        }

    }
}
