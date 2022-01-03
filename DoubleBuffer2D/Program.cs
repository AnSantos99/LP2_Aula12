using System;

namespace DoubleBuffer2D
{
    class Program
    {
        static void Main(string[] args)
        {
           DoubleBuffer2D<char> db = new DoubleBuffer2D<char>(5, 5);

            db[1, 0] = 'X';
            db[2, 0] = 'X';
            db[3, 0] = 'X';
            db[4, 0] = 'X';
            db[1, 1] = 'X';
            db[1, 2] = 'X';
            db[2, 2] = 'X';
            db[3, 2] = 'X';
            db[3, 3] = 'X';
            db[0, 4] = 'X';
            db[1, 4] = 'X';
            db[3, 4] = 'X';

            db.Swap();

            PrintToScreen(db);
        }

        private static void PrintToScreen(DoubleBuffer2D<char> db)
        {
            for(int i = 0; i < db.YDim; i++)
            {
                for(int j = 0; j < db.XDim; j++)
                {
                    if(db[i, j] == default)
                        Console.Write(" ");

                    else
                        Console.Write(db[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
