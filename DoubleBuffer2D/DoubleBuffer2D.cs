using System;

namespace DoubleBuffer2D
{
    public class DoubleBuffer2D<T>
    {
        private T[,] current;

        private T[,] next;

        public int XDim => current.GetLength(0);

        public int YDim => current.GetLength(1);


        public T this[int x, int y]
        {
            get => current[x, y];
            set => next[x, y];
        }

        public void Clear() => Array.Clear(next, 0, XDim * YDim);

        public DoubleBuffer2D(int x, int y)
        {
            current = new T[x, y];
            next = new T[x, y];
        }

        public void Swap()
        {
            int aux = current;
            current = next;
            next = aux;
        }
    }
}