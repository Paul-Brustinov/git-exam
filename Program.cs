using System;
using System.Collections.Generic;
using git_exam.Reader;

namespace git_exam {
    internal class Program {
        public static void Main(string[] args)
        {
            var person = ChumakReader.Get();
            Console.WriteLine(person.Name);
        }
    }
}