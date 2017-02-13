using Shapes.Classes.Concrete;
using NUnit.Framework;
using System;

namespace ShapesTest.ClassesTests
{
    [TestFixture]
    public class CylinderTest
    {
        float testRadius = 5;
        float testHeight = 10;

        [Test]
        public void constructorReturnsCylinderTest()
        {
            Cylinder cylinder = new Cylinder(testHeight, testRadius);
            Assert.IsInstanceOf<Cylinder>(cylinder);
        }

        [Test]
        public void constructorDefaultsPropertiesToOneTest()
        {
            Cylinder cylinder = new Cylinder(0, 0);
            Assert.AreEqual(1, cylinder.radius);
            Assert.AreEqual(1, cylinder.height);
        }

        [Test]
        public void radiusAutoPropertyTest()
        {
            Cylinder cylinder = new Cylinder(testHeight, testRadius);
            Assert.AreEqual(testRadius, cylinder.radius);
        }

        [Test]
        public void heightAutoPropertyTest()
        {
            Cylinder cylinder = new Cylinder(testHeight, testRadius);
            Assert.AreEqual(testHeight, cylinder.height);
        }

        [Test]
        public void surfaceAreaTest()
        {
            float expectedSurfaceArea = (float)Math.Round(((2 * Math.PI * testRadius * testHeight) + Math.Pow(2 * System.Math.PI * testRadius, 2)), 2);
            Cylinder cylinder = new Cylinder(testHeight, testRadius);
            Assert.AreEqual(expectedSurfaceArea, cylinder.surfaceArea());
        }

        [Test]
        public void volumeTest()
        {
            float expectedVolume = (float)Math.Round(Math.PI * Math.Pow(testRadius, 2) * testHeight, 2);
            Cylinder cylinder = new Cylinder(testHeight, testRadius);
            Assert.AreEqual(expectedVolume, cylinder.volume());
        }
    }
}
