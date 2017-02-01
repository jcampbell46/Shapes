using System;
using System.Windows;
using Shapes.Classes.Abstract;

namespace Shapes.Classes.Concrete
{
    // Class that creating a three-dimensional Cylinder object. Implements IShape.
    class Cylinder : IShape
    {
        // Constructor that accepts the dimensions of the Cylinder as an arguement.
        public Cylinder(float height, float radius)
        {
            if (height <= 0 || radius <= 0) return;
            this.height = height;
            this.radius = radius;
        }

        // Shorthand declaration for property "radius", used to calculate volume, surface area, and render the Cylinder.
        private float radius { get; set; }

        // Shorthand declaration for property "height", used to calculate volume, surface area, and render the Cylinder.
        private float height { get; set; }

        // Implemented method of IShape, displays messagebox with it's dimensions.
        public void render()
        {
            MessageBox.Show($"Radius: {radius}" + Environment.NewLine + $"Height: {height}" + Environment.NewLine + $"Surface Area: {surfaceArea()}" + Environment.NewLine + $"Volume: {volume()}", "Cylinder");
        }

        // Implemented method of IShape, calculates surface area.
        public float surfaceArea()
        {
            double result = (2 * Math.PI * radius * height) + Math.Pow(2 * Math.PI * radius, 2);
            return (float)result;
        }

        // Implemented method of IShape, calculates volume.
        public float volume()
        {
            double result = Math.PI * Math.Pow(radius, 2) * height;
            return (float)result;
        }
    }
}