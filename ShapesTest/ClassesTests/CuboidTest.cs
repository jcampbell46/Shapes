using System;
using Shapes.Classes.Concrete;
using NUnit.Framework;

namespace ShapesTest.ClassesTests
{
    /// <summary>
    /// Summary description for CuboidTest
    /// </summary>
    [TestFixture]
    public class CuboidTest
    {
        float testWidth = 1;
        float testHeight = 2;
        float testDepth = 3;

        [Test]
        public void constructorReturnsCuboidTest()
        {
            Cuboid cuboid = new Cuboid(testWidth, testHeight, testDepth);
            Assert.IsInstanceOf<Cuboid>(cuboid);
        }

        [Test]
        public void constructorDefaultsPropertiesToOneTest()
        {
            Cuboid cuboid = new Cuboid(0, 0, 0);
            Assert.AreEqual(1, cuboid.width);
            Assert.AreEqual(1, cuboid.height);
            Assert.AreEqual(1, cuboid.depth);
        }

        [Test]
        public void widthAutoPropertyTest()
        {
            Cuboid cuboid = new Cuboid(testWidth, testHeight, testDepth);
            Assert.AreEqual(testWidth, cuboid.width);
        }

        [Test]
        public void heightAutoPropertyTest()
        {
            Cuboid cuboid = new Cuboid(testWidth, testHeight, testDepth);
            Assert.AreEqual(testHeight, cuboid.height);
        }

        [Test]
        public void depthAutoPropertyTest()
        {
            Cuboid cuboid = new Cuboid(testWidth, testHeight, testDepth);
            Assert.AreEqual(testDepth, cuboid.depth);
        }

        [Test]
        public void surfaceAreaTest()
        {
            float expectedSurfaceArea = (float)Math.Round(2 * (testWidth * testHeight + testHeight * testDepth + testDepth * testWidth), 2);
            Cuboid cuboid = new Cuboid(testWidth, testHeight, testDepth);
            Assert.AreEqual(expectedSurfaceArea, cuboid.surfaceArea());
        }

        [Test]
        public void volumeTest()
        {
            float expectedVolume = (float)Math.Round(testDepth * testWidth * testHeight, 2);
            Cuboid cuboid = new Cuboid(testWidth, testHeight, testDepth);
            Assert.AreEqual(expectedVolume, cuboid.volume());
        }
    }
        
}
