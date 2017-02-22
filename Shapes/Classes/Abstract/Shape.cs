
namespace Shapes.Classes.Abstract
{
    // Interface for implementations of Shape to inherit from.
public abstract class Shape
    {
        // Shorthand getter/setter for an IDialog object.
        public IDialog messageBox { get; set; }
        
        // Constructor that ensures all children will recieve an IDialog object on their instantiation.
        public Shape(IDialog messageBox)
        {
            this.messageBox = messageBox;
        }

        // Used to calculate surface area.
        public abstract float surfaceArea();

        // Used to calculate volume.
        public abstract float volume();
    }
}