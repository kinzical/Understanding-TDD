using System;

namespace StackService.Services
{
    public class StackS<T>
    {
        private T[] stackArray;
        private int maximumLength;
        public int Size {get; set;}
        public StackS(int length)
        {
            maximumLength = length;
            stackArray = new T[length];
        }
        public void Push(T value)
        {
            stackArray[Size++] = value;
            //return value;
        }

        public T Pop()
        {
            return stackArray[--Size];
        }
    }
}
