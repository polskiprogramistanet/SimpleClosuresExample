using System;

namespace ClosuresExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Closures();
        }
        static void Closures()
        {
            Console.WriteLine(GetFunction()(arg:300));
        }
        static Func<int, int> GetFunction()
        {
            int val = 100;
            Func<int, int> internalAdd = x => x + val;
            Console.WriteLine(internalAdd(arg: 10));

            val = 300;
            Console.WriteLine(internalAdd(arg:10));

            return internalAdd;
        }
    }
}
