using NUnit.Framework;
using Tut2_s20123;
using System;

namespace Tut2_s20123_Tests
{
    public class Tests
    {
        private IShape sphere;
        private IShape cylinder;
        private IShape rectangle;
        private IShape cube;

        [SetUp]
        public void Setup()
        {
            sphere = new Sphere(5);
            cylinder = new Cylinder(3, 7);
            rectangle = new Rectangle(4, 8);
            cube = new Cube(4);
        }


        [Test]
        public void TestSphereCalculateArea()
        {
            double expected = 4 * Math.PI * Math.Pow(5, 2); 
            Assert.That(sphere.CalculateArea(), Is.EqualTo(expected).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            double expected = (4.0 / 3.0) * Math.PI * Math.Pow(5, 3); 
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(expected).Within(0.001));
        }


        [Test]
        public void TestCylinderCalculateArea()
        {
            double expected = 2 * Math.PI * 3 * (3 + 7); 
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(expected).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateVolume()
        {
            double expected = Math.PI * Math.Pow(3, 2) * 7; 
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(expected).Within(0.001));
        }


        [Test]
        public void TestRectangleCalculateArea()
        {
            double expected = 4 * 8; 
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(expected).Within(0.001));
        }

        [Test]
        public void TestRectangleCalculateVolume()
        {
            double expected = 0;
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(expected));
        }


        [Test]
        public void TestCubeCalculateArea()
        {
            double expected = 6 * Math.Pow(4, 2); 
            Assert.That(cube.CalculateArea(), Is.EqualTo(expected).Within(0.001));
        }

        [Test]
        public void TestCubeCalculateVolume()
        {
            double expected = Math.Pow(4, 3); 
            Assert.That(cube.CalculateVolume(), Is.EqualTo(expected).Within(0.001));
        }


        [Test]
        public void TestSphereWithZeroRadius()
        {
            var smallSphere = new Sphere(0);
            Assert.That(smallSphere.CalculateArea(), Is.EqualTo(0));
            Assert.That(smallSphere.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestRectangleWithZeroDimensions()
        {
            var flatRectangle = new Rectangle(0, 10);
            Assert.That(flatRectangle.CalculateArea(), Is.EqualTo(0));
            Assert.That(flatRectangle.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestCubeWithNegativeSide()
        {
            var invalidCube = new Cube(-3);
            Assert.That(invalidCube.CalculateArea(), Is.EqualTo(6 * Math.Pow(-3, 2)).Within(0.001));
            Assert.That(invalidCube.CalculateVolume(), Is.EqualTo(Math.Pow(-3, 3)).Within(0.001));
        }
    }
}
