using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class FenceGate
    {
        private double _Height;

        public double Height
        {
            get
            {
                return _Height;
            }
            set
            {
                if (value > 0 && value <= 8.0)
                {
                    _Height = value;
                }
                else
                {
                    throw new Exception("Invalid Height");
                }
            }
        }


        public double Width { get; set; }

        private string _Style;

        public string Style
        {
            get
            {
                return _Style;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Style = null;
                }
                else
                {
                    _Style = value;
                }
            }
        }

        public double Price { get; set; }

        public FenceGate()
        {

        }
        public FenceGate(double height, double width, string style, double price)
        {
            Height = height;
            Width = width;
            Style = style;
            Price = price;
        }

        public double GateArea()
        {
            //Should probably check that width and height have values 
            return Width * Height;
        }
    }
}
