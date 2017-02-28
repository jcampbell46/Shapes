using System;
using System.Windows;
using Shapes.Classes.Abstract;

namespace Shapes.Classes.Concrete
{
    // Class that creating a three-dimensional Cuboid object. Implements IShape.
    public class Cuboid : Shape, IRenderer
    {
        // Constructor that accepts the dimensions of the Cuboid as an arguement.
        public Cuboid(IDialog messageBox, float width = 1, float height = 1, float depth = 1) : base(messageBox)
        {
            this.width = (width <= 0 || float.IsNaN(width)) ? 1 : width;
            this.height = (height <= 0 || float.IsNaN(height)) ? 1 : height;
            this.depth = (depth <= 0 || float.IsNaN(depth)) ? 1 : depth;
            this.messageBox = messageBox;
        }

        // Shorthand declaration for property "width", used to calculate volume, surface area, and render the Cuboid.
        public float width { get; set; }

        // Shorthand declaration for property "height", used to calculate volume, surface area, and render the Cuboid.
        public float height { get; set; }

        // Shorthand declaration for property "depth", used to calculate volume, surface area, and render the Cuboid.
        public float depth { get; set; }

        // Implemented method of IShape, displays messagebox with it's dimensions.
        public int render()
        {
            return messageBox.show($"Width: {width}" + Environment.NewLine + $"Height: {height}" + Environment.NewLine + $"Depth: {depth}" + Environment.NewLine + $"Surface Area: {surfaceArea()}" + Environment.NewLine + $"Volume: {volume()}", "Cuboid");
        }

        // Implemented method of IShape, calculates surface area.
        public override float surfaceArea()
        {
            return (float)Math.Round(2 * (width * height + height * depth + depth * width), 2);
        }

        // Implemented method of IShape, calculates volume.
        public override float volume()
        {
            return (float)Math.Round(depth * width * height, 2);
        }
    }
}