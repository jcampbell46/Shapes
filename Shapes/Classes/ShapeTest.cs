using Shapes.Classes.Concrete;

namespace Shapes.Classes
{
    class ShapeTest
    {
        public void main()
        {
            Cuboid cuboid = new Cuboid(2, 3, 4);
            Cylinder cylinder = new Cylinder(2, 3);
            Sphere sphere = new Sphere(2);

            cuboid.render();
            cylinder.render();
            sphere.render();
        }
    }
}
