using Shapes.Classes.Abstract;

namespace Shapes.Classes.Concrete
{
    class MessageBox : IDialog
    {
        public int show(string message, string title)
        {
            System.Windows.MessageBox.Show(message, title);
            return 1;
        }
    }
}
