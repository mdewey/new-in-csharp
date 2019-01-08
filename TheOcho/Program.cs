using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheOcho
{


    public abstract class Person
    {

    }

    public class Student
    {
        public int Id { get; set; }
        public bool Graduated { get; set; }
        public string? Name { get; set; }
    }

    class Program
    {


        // Recursive Patterns

        static IEnumerable<string> RecursivePatterns()
        {
            var myPets = new List<Pet>{
                new Cat{Name = "Whiskers"},
                new Cat{Name = "Tuna"},
                new Dog{Name = "Fido"},
                new Fish {Name = "Red"},
                new Fish {Name = "Blue"}
            }
            var People = new List<Person>();
            foreach (var p in People)
            {
                if (p is Student { Graduated: false, Name: string name }) yield return name;
            }
            // foreach (var p in myPets)
            // {
            //     if (p is Cat { Graduated: false, Name: string name }) yield return name;
            // }
        }

        // ===== interafaces!!
        // See the Cat for Wisdom

        // ======= Async Streams

        // static async IAsyncEnumerable<int> GetDigits()
        // {
        //     int result = 1;

        //     for (int i = 0; i < 10; i++)
        //     {
        //         result = result * 3;
        //         yield return result;
        //     }
        // }

        // static async Task AsyncStreams()
        // {
        //     await foreach (var number in GetDigits())
        //     {
        //         // do something cool
        //     }
        // }

        // =================== Null!!
        static void NullableRefTypesDemo()
        {
            // example 1:simple
            // COMPILE TIME ERROR!!!!
            // string name = null;
            // Console.WriteLine(name);

            // example 2: intent!
            // var kitty = new Cat{
            //     Name = "Sylvester"
            // };

            // // somewhere else
            // var count = 35;
            // if (count > 30){
            //     kitty = null;
            // }

            // 100 lines of code later
            // Console.WriteLine(kitty.Greeting());

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // NullableRefTypesDemo();
        }
    }
}
