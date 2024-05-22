using System;
using System.Resources;

namespace CP
{
    class Program
    {
        static void Main(string[] args)
        {   // Path to testFile.txt must be changed to your download
            Algorithm algorithm = new 
                Algorithm(@"testfile.txt");
            
            algorithm.GetCharFrequency();
            algorithm.GetWordFrequency();


            //Console.WriteLine("Hello World!");
        }
    }
}
