using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14_16_02
{
    class MattedPhoto : Photo
    {
        //	Color enumerator
        public enum Color
        {
            BLACK = 0,
            RED = 1,
            GREEN = 2,
            BLUE = 4,
            WHITE = 7
        }

        Color _theColor;   //	Instance variables

        //	Constructor
        public MattedPhoto(double width, double height, Color color)
                                        : base(width, height)
        {
            this._theColor = color;
        }

        //	Getter and setter
        public Color TheColor
        {   //  Begin public Color Color
            get
            {
                return _theColor;
            }
            set
            {
                _theColor = value;
            }
        }   //  End   public Color Color

        override public string ToString()
        {   //	Begin override public string ToString()
            return base.ToString() + " Matted " + TheColor.ToString();
        }   //	End   override public string ToString()
    }
}
