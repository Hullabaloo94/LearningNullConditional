using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningNullConditional
{
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();// { Name = "Tim" };
            // The ? after person (code below) is stating that the person variable (for this statement only) can be null so don't fire a NullReferenceException if it is null. 
            // Combining Null Conditional (person?) with Null Coalescing (??) we are able to access a person variable that may be null, try and access its name and if that is null then output "Not Set", otherwise output the name.
            Console.WriteLine(person?.Name ?? "Not Set.");
        }
    }
}
