using Shapes.Classes.Concrete;

namespace Shapes.Classes.Abstract
{
    public enum ShapeType
    {
        Cuboid,
        Cylinder,
        Sphere
    }

    public class ShapeFactory
    {
        public IDialog dialog { get; set; }

        public ShapeFactory(IDialog dialog)
        {
            this.dialog = dialog;
        }

        public Shape make(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Cuboid:
                    return new Cuboid(dialog);
                case ShapeType.Cylinder:
                    return new Cylinder(dialog);
                case ShapeType.Sphere:
                    return new Sphere(dialog);
                default:
                    throw new System.Exception("Unrecognized Shape");
            }
        }
    }

}
