using System;

namespace TheOcho
{
    class Program
    {

        static void NullableRefTypesDemo()
        {
            // example 1:simple
            // COMPILE TIME ERROR!!!!
            // string name = null;
            // Console.WriteLine(name);
            
            // example 2: intent!
            var kitty = new Cat{
                Name = "Sylvester"
            };
            // // somewhere else
            // var count = 35;
            // if (count > 30){
            //     kitty = null;
            // }

            // 100 lines of code later
            Console.WriteLine(kitty.Greeting());
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NullableRefTypesDemo();
        }
    }
}
