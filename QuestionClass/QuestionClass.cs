using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionClass
{
    public static class QuestionClass
    {
        static void Main(string[] args)
        {
            
            List<string> NamesList = new List<string> { "Jimmy","Jeffrey","John"};
            NamesList.ForEach((name) => Console.WriteLine(name));
            Console.ReadLine();

        }
    }
}
