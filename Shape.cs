using System;
using SplashKitSDK;

namespace week_4_task
{
    //First comment for new github code
    public class Shape
    {
        private Color _color;
        //private Point2D _position;
        private float _x;
        private float _y;
        private int width;
        private int height;   //First comment for new github code
    
        public Shape(int param)
        {
            _color = Color.Azure;
            _x = 0;
            _y = 0;
            width = param;
            height = param;
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public void Draw()
        {
            // This method will be overridden in derived classes to draw specific shapes
            SplashKit.FillRectangle(_color, _x, _y, width, height);
        }

        public bool IsAt(Point2D pt)
        {
            // This method will be overridden in derived classes to check if a point is within the shape
            return (pt.X >= _x && pt.X <= _x + width && pt.Y >= _y && pt.Y <= _y + height);
        }
    }
}