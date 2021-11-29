using System.Windows;

namespace YoloMarkNet
{
    public class BoundingBox : Notifier
    {
        public BoundingBox(Rect rect, Class c) { this.rect = rect; Class = c; }
        private Rect rect;
        public Class Class { get; }
        public double X
        {
            get { return rect.X; }
            set
            {
                rect.X = value;
                NotifyPropertyChanged();
            }
        }
        public double Y
        {
            get { return rect.Y; }
            set
            {
                rect.Y = value;
                NotifyPropertyChanged();
            }
        }
        public double Width
        {
            get { return rect.Width; }
            set
            {
                rect.Width = value;
                NotifyPropertyChanged();
            }
        }
        public double Height
        {
            get { return rect.Height; }
            set
            {
                rect.Height = value;
                NotifyPropertyChanged();
            }
        }
    }
}