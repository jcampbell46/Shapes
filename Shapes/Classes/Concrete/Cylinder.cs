using System;
using Shapes.Classes.Abstract;

namespace Shapes.Classes.Concrete
{
    // Class that creating a three-dimensional Cylinder object. Implements IShape.
    public class Cylinder : Shape, IRenderer
    {
        // Constructor that accepts the dimensions of the Cylinder as an arguement.
        public Cylinder(IDialog messageBox, float height, float radius) : base(messageBox)
        {
            if (height <= 0 || 
                radius <= 0 || 
                float.IsNaN(height) || 
                float.IsNaN(radius))
            {
                this.height = 1;
                this.radius = 1;
                return;
            }
            this.height = height;
            this.radius = radius;
            this.messageBox = messageBox;
        }

        // Shorthand declaration for property "radius", used to calculate volume, surface area, and render the Cylinder.
        public float radius { get; set; }

        // Shorthand declaration for property "height", used to calculate volume, surface area, and render the Cylinder.
        public float height { get; set; }

        // Implemented method of IShape, displays messagebox with it's dimensions.
        public int render()
        {
            return messageBox.show($"Radius: {radius}" + Environment.NewLine + $"Height: {height}" + Environment.NewLine + $"Surface Area: {surfaceArea()}" + Environment.NewLine + $"Volume: {volume()}", "Cylinder");
        }

        // Implemented method of IShape, calculates surface area.
        public override float surfaceArea()
        {
            return (float)Math.Round((2 * Math.PI * radius * height) + Math.Pow(2 * Math.PI * radius, 2), 2);
        }

        // Implemented method of IShape, calculates volume.
        public override float volume()
        {
            return (float)Math.Round(Math.PI * Math.Pow(radius, 2) * height, 2);
        }
    }
}