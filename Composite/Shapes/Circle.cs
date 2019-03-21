using System;

namespace Composite
{
    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Hello, I'm Circle");
        }
    }
}