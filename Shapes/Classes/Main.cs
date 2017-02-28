using Shapes.Classes.Abstract;
using Shapes.Classes.Concrete;

namespace Shapes.Classes
{
    class Main
    {
        public void main()
        {
            IDialog messageBox = new MessageBox();
            ShapeFactory shapeFactory = new ShapeFactory(messageBox);

            Cuboid cuboid = (Cuboid)shapeFactory.make(ShapeType.Cuboid);
            Cylinder cylinder = (Cylinder)shapeFactory.make(ShapeType.Cylinder);
            Sphere sphere = (Sphere)shapeFactory.make(ShapeType.Sphere);

            cuboid.render();
            cylinder.render();
            sphere.render();
        }
    }
}
