using System;

namespace ConsoleApp1
{
    class My
    {
        private int a = 5 ;
        private int b = 4;

        
        public int C
        {
            get { return a + b; }
        }

        
    }
    class Program
    {
        
        
        static void Main(string[] args)
        {
            My program = new My();
            Console.WriteLine("" + program.C);
            
        }
    }
}