﻿using System;
using System.Windows;
using Shapes.Classes.Abstract;

namespace Shapes.Classes.Concrete
{
    // Class that creating a three-dimensional Cuboid object. Implements IShape.
    public class Cuboid : IShape
    {
        // Constructor that accepts the dimensions of the Cuboid as an arguement.
        public Cuboid(float width, float height, float depth)
        {
            if (width <= 0 || 
                height <= 0 || 
                depth <= 0 ||
                float.IsNaN(width) ||
                float.IsNaN(height) ||
                float.IsNaN(depth))
            {
                this.width = 1;
                this.height = 1;
                this.depth = 1;
                return;
            }
            this.width = width;
            this.height = height;
            this.depth = depth;
        }

        // Shorthand declaration for property "width", used to calculate volume, surface area, and render the Cuboid.
        public float width { get; set; }

        // Shorthand declaration for property "height", used to calculate volume, surface area, and render the Cuboid.
        public float height { get; set; }

        // Shorthand declaration for property "depth", used to calculate volume, surface area, and render the Cuboid.
        public float depth { get; set; }

        // Implemented method of IShape, displays messagebox with it's dimensions.
        public void render()
        {
            MessageBox.Show($"Width: {width}" + Environment.NewLine + $"Height: {height}" + Environment.NewLine + $"Depth: {depth}" + Environment.NewLine + $"Surface Area: {surfaceArea()}" + Environment.NewLine + $"Volume: {volume()}", "Cuboid");
        }

        // Implemented method of IShape, calculates surface area.
        public float surfaceArea()
        {
            return (float)Math.Round(2 * (width * height + height * depth + depth * width), 2);
        }

        // Implemented method of IShape, calculates volume.
        public float volume()
        {
            return (float)Math.Round(depth * width * height, 2);
        }
    }
}