using System.Collections.Generic;

namespace Composite
{
    public class Composite : IShape
    {
        private List<IShape> _components = new List<IShape>();

        public void AddComponent(IShape component)
        {
            _components.Add(component);
        }

        public void RemoveComponent(IShape component)
        {
            _components.Remove(component);
        }

        public void draw()
        {
            foreach (var component in _components)
            {
                component.draw();
            }
        }
    }
}