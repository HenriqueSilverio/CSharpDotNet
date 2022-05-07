using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // The compiler will warn, but that won't stop from running
            System.Data.DataSet ds;

            // The compiler will warn, but that won't stop from running
            System.Net.Http.HttpClient client;

            Console.WriteLine();

            Console.WriteLine("Hello C#!");

            Console.WriteLine("Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4);

            foreach(var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                var a = Assembly.Load(new AssemblyName(r.FullName));

                int methodCount = 0;

                foreach (var t in a.DefinedTypes)
                {
                    methodCount += t.GetMethods().Count();
                }
                
                Console.WriteLine(
                    "{0:N0} types with {1:N0} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount,
                    arg2: r.Name
                );

                double heightInMetres = 1.88;

                Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");

                // The compiler will warn, but that won't stop from running
                char letter = 'A';
                
                // The compiler will warn, but that won't stop from running
                char digit = '1';

                // The compiler will warn, but that won't stop from running
                char symbol = '$';
                
                // The compiler will warn, but that won't stop from running
                string firstName = "Bob";
                
                // The compiler will warn, but that won't stop from running
                string lastName = "Smith";
                
                // The compiler will warn, but that won't stop from running
                string phoneNumber = "(215) 555-4256";

                // The compiler will warn, but that won't stop from running
                string fullNameWithTabSeparator = "Bob\tSmith";

                // The compiler will warn, but that won't stop from running
                // Prefix with the @ symbol to use a **verbatim** literal string
                string filePath = @"C:\televisions\sony\bravia.txt";
            }
        }
    }
}
