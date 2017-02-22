using NSubstitute;
using NUnit.Framework;
using Shapes.Classes.Abstract;
using Shapes.Classes.Concrete;
using System;

namespace ShapesTest.ClassesTests
{
    [TestFixture]
    public class SphereTest
    {
        int testRadius = 5;
        IDialog fakeMessageBox = Substitute.For<IDialog>();

        [OneTimeSetUp]
        public void setUp()
        {
            fakeMessageBox.show(Arg.Any<string>(), Arg.Any<string>()).Returns(0);
        }

        [Test]
        public void constructorReturnsSphereTest()
        {
            Sphere sphere = new Sphere(fakeMessageBox, testRadius);
            Assert.IsInstanceOf<Sphere>(sphere);
        }
        [Test]
        public void constructorDefaultsPropertiesToOneTest()
        {
            Sphere sphere = new Sphere(fakeMessageBox, 0);
            Assert.AreEqual(1, sphere.radius);
        }

        [Test]
        public void radiusSetterTest()
        {
            Sphere sphere = new Sphere(fakeMessageBox, testRadius);
            Assert.AreEqual(testRadius, sphere.radius);
        }

        [Test]
        public void radiusGetterTest()
        {
            Sphere sphere = new Sphere(fakeMessageBox, testRadius);
            Assert.AreEqual(testRadius, sphere.radius);
        }

        [Test]
        public void surfaceAreaTest()
        {
            float expectedSurfaceArea = (float)Math.Round(4 * Math.PI * Math.Pow(testRadius, 2), 2);
            Sphere sphere = new Sphere(fakeMessageBox, testRadius);

            Assert.AreEqual(expectedSurfaceArea, sphere.surfaceArea());
        }

        [Test]
        public void volumeTest()
        {
            float expectedVolume = (float)Math.Round((4 / 3) * Math.PI * Math.Pow(testRadius, 3), 2);
            Sphere sphere = new Sphere(fakeMessageBox, testRadius);

            Assert.AreEqual(expectedVolume, sphere.volume());
        }

        [Test]
        public void renderTest()
        {
            Sphere sphere = new Sphere(fakeMessageBox, testRadius);
            Assert.AreEqual(0, sphere.render());
        }
    }
}
