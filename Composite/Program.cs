using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape square1 = new Square();
            IShape square2 = new Square();
            IShape triangle1 = new Triangle();

            IShape square3 = new Square();
            IShape circle1 = new Circle();
            IShape circle2 = new Circle();
            IShape circle3 = new Circle();

            Composite composite = new Composite();
            Composite composite1 = new Composite();
            Composite composite2 = new Composite();

            composite1.AddComponent(square1);
            composite1.AddComponent(square2);
            composite1.AddComponent(triangle1);

            composite2.AddComponent(square3);
            composite2.AddComponent(circle1);
            composite2.AddComponent(circle2);
            composite2.AddComponent(circle3);

            composite.AddComponent(composite1);
            composite.AddComponent(composite2);

            composite.draw();
        }
    }
}
