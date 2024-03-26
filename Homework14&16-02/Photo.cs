using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14_16_02
{
    class Photo
    {

        //	Instance variables
        double _width;
        double _height;

        //	Constructor
        public Photo(double width, double height)
        {
            this._width = width;
            this._height = height;
        }

        //	Getter and setter
        public double Width
        {   //  Begin public double Width
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }   //  End   public double Width

        public double Height
        {   //  Begin public double Height
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }   //  End   public double Height

        override public string ToString()
        {   //	Begin override public string ToString()
            return (Width + " x " + Height);
        }   //	End   override public string ToString()
    }
}
