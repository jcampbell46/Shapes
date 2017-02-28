using System;
using System.Windows;
using Shapes.Classes.Abstract;

namespace Shapes.Classes.Concrete
{
    // Class that creating a three-dimensional Sphere object. Implements IShape.
    public class Sphere : Shape, IRenderer
    {
        // Constructor that accepts the dimensions of the Sphere as an arguement.
        public Sphere(IDialog messageBox, float radius = 1) : base(messageBox)
        {
            this.radius = (radius <= 0 || float.IsNaN(radius)) ? 1 : radius;
            this.messageBox = messageBox;
        }

        // Shorthand declaration for property "radius", used to calculate volume, surface area, and render the Sphere.
        public float radius { get; set; }

        // Implemented method of Shape, displays messagebox with it's dimensions.
        public int render()
        {
            return messageBox.show($"Radius: {radius}" + Environment.NewLine + $"Surface Area: {surfaceArea()}" + Environment.NewLine + $"Volume: {volume()}", "Sphere");
        }

        // Implemented method of Shape, calculates surface area.
        public override float surfaceArea()
        {
            return (float)Math.Round(4 * Math.PI * Math.Pow(radius, 2), 2);
        }

        // Implemented method of Shape, calculates volume.
        public override float volume()
        {
            return (float)Math.Round((4 / 3) * Math.PI * Math.Pow(radius, 3), 2);
        }
    }
}