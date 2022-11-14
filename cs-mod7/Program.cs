using System;

namespace cs_class1
{
    class Rectangle
    {
        public int a;
        public int b;

        public void Print()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < b; i++)
            {
                for (int k = 0; k < a; k++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }





    class Program
    {

        static int GetValue()
        {
            int.TryParse(Console.ReadLine(), out int i);
            return i;
        }


        static void Main(string[] args)
        {



            Rectangle rect1 = new Rectangle();
            Console.WriteLine("Длина: ");
            rect1.a = GetValue();
            Console.WriteLine("Ширина: ");
            rect1.b = GetValue();
            rect1.Print();
        }
    }
}
