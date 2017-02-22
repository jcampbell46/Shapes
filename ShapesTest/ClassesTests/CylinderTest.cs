using Shapes.Classes.Concrete;
using Shapes.Classes.Abstract;
using NUnit.Framework;
using NSubstitute;
using System;

namespace ShapesTest.ClassesTests
{
    [TestFixture]
    public class CylinderTest
    { 
        float testRadius = 5;
        float testHeight = 10;
        IDialog fakeMessageBox = Substitute.For<IDialog>();
        
        [OneTimeSetUp]
        public void setUp()
        {
            fakeMessageBox.show(Arg.Any<string>(), Arg.Any<string>()).Returns(0);
        }

        [Test]
        public void constructorReturnsCylinderTest()
        {
            Cylinder cylinder = new Cylinder(fakeMessageBox, testHeight, testRadius);
            Assert.IsInstanceOf<Cylinder>(cylinder);
        }

        [Test]
        public void constructorDefaultsPropertiesToOneTest()
        {
            Cylinder cylinder = new Cylinder(fakeMessageBox, 0, 0);
            Assert.AreEqual(1, cylinder.radius);
            Assert.AreEqual(1, cylinder.height);
        }

        [Test]
        public void radiusAutoPropertyTest()
        {
            Cylinder cylinder = new Cylinder(fakeMessageBox, testHeight, testRadius);
            Assert.AreEqual(testRadius, cylinder.radius);
        }

        [Test]
        public void heightAutoPropertyTest()
        {
            Cylinder cylinder = new Cylinder(fakeMessageBox, testHeight, testRadius);
            Assert.AreEqual(testHeight, cylinder.height);
        }

        [Test]
        public void surfaceAreaTest()
        {
            float expectedSurfaceArea = (float)Math.Round(((2 * Math.PI * testRadius * testHeight) + Math.Pow(2 * System.Math.PI * testRadius, 2)), 2);
            Cylinder cylinder = new Cylinder(fakeMessageBox, testHeight, testRadius);
            Assert.AreEqual(expectedSurfaceArea, cylinder.surfaceArea());
        }

        [Test]
        public void volumeTest()
        {
            float expectedVolume = (float)Math.Round(Math.PI * Math.Pow(testRadius, 2) * testHeight, 2);
            Cylinder cylinder = new Cylinder(fakeMessageBox, testHeight, testRadius);
            Assert.AreEqual(expectedVolume, cylinder.volume());
        }

        [Test]
        public void renderTest()
        {
            Cylinder cylinder = new Cylinder(fakeMessageBox, testHeight, testRadius);
            Assert.AreEqual(0, cylinder.render());
        }
    }
}
