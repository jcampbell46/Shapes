namespace Shapes.Classes.Abstract
{
    // Interface for implementations of Shape to inherit from.
    interface IShape
    {
        // Used to calculate surface area.
        float surfaceArea();

        // Used to calculate volume.
        float volume();

        // Used to render the shape.
        void render();
    }
}