using Shapes.Classes.Abstract;
using Shapes.Classes.Concrete;

namespace Shapes.Classes
{
    class Main
    {
        public void main()
        {
            IDialog messageBox = new MessageBox();

            Cuboid cuboid = new Cuboid(messageBox, 2, 3, 4);
            Cylinder cylinder = new Cylinder(messageBox, 2, 3);
            Sphere sphere = new Sphere(messageBox, 2);

            cuboid.render();
            cylinder.render();
            sphere.render();
        }
    }
}
