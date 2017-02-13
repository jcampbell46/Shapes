using System;
using System.Windows;
using Shapes.Classes.Abstract;

namespace Shapes.Classes.Concrete
{
    // Class that creating a three-dimensional Sphere object. Implements IShape.
    public class Sphere : IShape
    {
        // Constructor that accepts the dimensions of the Sphere as an arguement.
        public Sphere(float radius)
        {
            if (radius <= 0 || float.IsNaN(radius))
            {
                this.radius = 1;
                return;
            }
            this.radius = radius;
        }

        // Shorthand declaration for property "radius", used to calculate volume, surface area, and render the Sphere.
        public float radius { get; set; }

        // Implemented method of IShape, displays messagebox with it's dimensions.
        public void render()
        {
            MessageBox.Show($"Radius: {radius}" + Environment.NewLine + $"Surface Area: {surfaceArea()}" + Environment.NewLine + $"Volume: {volume()}", "Sphere");
        }

        // Implemented method of IShape, calculates surface area.
        public float surfaceArea()
        {
            return (float)Math.Round(4 * Math.PI * Math.Pow(radius, 2), 2);
        }

        // Implemented method of IShape, calculates volume.
        public float volume()
        {
            return (float)Math.Round((4 / 3) * Math.PI * Math.Pow(radius, 3), 2);
        }
    }
}