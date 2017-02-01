using System;
using System.Windows;
using Shapes.Classes.Abstract;

namespace Shapes.Classes.Concrete
{
    // Class that creating a three-dimensional Sphere object. Implements IShape.
    class Sphere : IShape
    {
        // Constructor that accepts the dimensions of the Sphere as an arguement.
        public Sphere(float radius)
        {
            if (radius <= 0) return;
            this.radius = radius;
        }

        // Shorthand declaration for property "radius", used to calculate volume, surface area, and render the Sphere.
        private float radius { get; set; }

        // Implemented method of IShape, displays messagebox with it's dimensions.
        public void render()
        {
            MessageBox.Show($"Radius: {radius}" + Environment.NewLine + $"Surface Area: {surfaceArea()}" + Environment.NewLine + $"Volume: {volume()}", "Sphere");
        }

        // Implemented method of IShape, calculates surface area.
        public float surfaceArea()
        {
            double result = 4 * Math.PI * Math.Pow(radius, 2);
            return (float)result;
        }

        // Implemented method of IShape, calculates volume.
        public float volume()
        {
            double result = (4 / 3) * Math.PI * Math.Pow(radius, 3);
            return (float)result;
        }
    }
}