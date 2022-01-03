using System;

namespace DoubleBuffer2D
{
    class Program
    {
        static void Main(string[] args)
        {
           DoubleBuffer2D<char> db = new DoubleBuffer2D<char>(5, 5);

           db[1, 0] = 'C';
           db[1, 1] = 'x';
           db[1, 2] = 'a';
           db[1, 3] = 's';
           db[1, 4] = 'd';

           db[2, 0] = 'f';
           db[2, 1] = 'g';
           db[2, 2] = 'h';
           db[2, 3] = 'j';
           db[2, 4] = 'k';

            db.Swap();

            Console.WriteLine(db.ToString());

        }
    }
}
