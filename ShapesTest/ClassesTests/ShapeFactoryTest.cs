using NUnit.Framework;
using NSubstitute;
using Shapes.Classes.Abstract;
using Shapes.Classes.Concrete;

namespace ShapesTest.ClassesTests
{
    [TestFixture]
    class ShapeFactoryTest
    {
        [Test]
        public void constructorReturnsShapeFactoryTest()
        {
            IDialog fakeMessageBox = Substitute.For<IDialog>();
            ShapeFactory shapeFactory = new ShapeFactory(fakeMessageBox);

            Assert.IsInstanceOf<ShapeFactory>(shapeFactory);
        }

        [Test]
        public void shapeFactoryReturnsCuboid()
        {
            IDialog fakeMessageBox = Substitute.For<IDialog>();
            ShapeFactory shapeFactory = new ShapeFactory(fakeMessageBox);
            Cuboid testCuboid = (Cuboid)shapeFactory.make(ShapeType.Cuboid);

            Assert.IsInstanceOf<Cuboid>(testCuboid);
        }

        [Test]
        public void shapeFactoryReturnsCylinder()
        {
            IDialog fakeMessageBox = Substitute.For<IDialog>();
            ShapeFactory shapeFactory = new ShapeFactory(fakeMessageBox);
            Cylinder testCylinder = (Cylinder)shapeFactory.make(ShapeType.Cylinder);

            Assert.IsInstanceOf<Cylinder>(testCylinder);
        }

        [Test]
        public void shapeFactoryReturnsSphere()
        {
            IDialog fakeMessageBox = Substitute.For<IDialog>();
            ShapeFactory shapeFactory = new ShapeFactory(fakeMessageBox);
            Sphere testSphere = (Sphere)shapeFactory.make(ShapeType.Sphere);

            Assert.IsInstanceOf<Sphere>(testSphere);
        }
    }
}
