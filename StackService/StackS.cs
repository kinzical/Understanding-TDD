using System;

namespace StackService.Services
{
    public class StackS<T>
    {
        private T[] stackArray;
        private int maximumLength;
        public int Size { get; set; }
        public StackS(int length)
        {
            maximumLength = length;
            stackArray = new T[length];
        }
        public void Push(T value)
        {
            if(Size == maximumLength)
                Console.WriteLine("Cannot enter more values");
            stackArray[Size++] = value;
        }

        public T Pop()
        {
            if(Size == 0)
                Console.WriteLine("Cannot pop more elements");
            return stackArray[--Size];
        }
    }
}
