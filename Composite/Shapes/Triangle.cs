using System;

namespace Composite
{
    public class Triangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Hello, I'm Triangle");
        }
    }
}