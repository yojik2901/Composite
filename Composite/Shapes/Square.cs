using System;

namespace Composite
{
    public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Hello, I'm Square");
        }
    }
}