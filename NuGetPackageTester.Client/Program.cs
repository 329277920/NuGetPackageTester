using NuGetPackageTester.Library;
using System;

namespace NuGetPackageTester.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine(Helper.ToJson(new { Name = "CNF" }));

            Console.ReadKey();
        }
    }
}
