using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14_16_02
{
    class FramedPhoto : Photo
    {
        //	Material enumerator
        public enum Material
        {
            PINE,
            OAK,
            STEEL,
            SILVER,
            GOLD
        }

        //	Style enumerator
        public enum Style
        {
            SIMPLE,
            MODERN,
            ANTIQUE,
            VINTAGE,
            ECLECTIC
        }

        //	Instance variables
        Material _theMaterial;
        Style _theStyle;

        //	Constructor
        public FramedPhoto(double width, double height,
                           Material material, Style style)
                                        : base(width, height)
        {
            this._theMaterial = material;
            this._theStyle = style;
        }

        //	Getters and setters
        public Material TheMaterial
        {   //  Begin public Material TheMaterial
            get
            {
                return _theMaterial;
            }
            set
            {
                _theMaterial = value;
            }
        }   //  End   public Material TheMaterial

        public Style TheStyle
        {   //  Begin public Style TheStyle
            get
            {
                return _theStyle;
            }
            set
            {
                _theStyle = value;
            }
        }   //  End   public Style TheStyle

        override public string ToString()
        {   //	Begin override public string ToString()
            return base.ToString() + " Framed " + TheMaterial.ToString() +
                                     " " + TheStyle.ToString();
        }   //	End   override public string ToString()
    }
}
