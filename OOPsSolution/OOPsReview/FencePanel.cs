﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    //by default all classes are private
    //for this class to be used by an outside user,
    //you must alter the permission for this class
    //you will use "public"

    public class FencePanel
    {
        //Properties
        //A property is associated with a single piece of data
        //a property has two sub components:
        // Get: returns a value to the calling client (outside user)
        // Set: receives a value from the calling client
        //  A keyword "value" is used to hold the incoming data to the property
        //  The property has a 'return datatype' (rdt) which specifies the type of data allowed. 
        //the property syntax DOES NOT allow for a parameter. 

        //Auto Implemented Property:
        //This style DOES NOT need a private data member
        //This system will create an internal data member of the rdt specified in the property definition 

        //public double Height { get; set; } what about negative numbers??

        //Assuming you wish to validate your data, then you should be using a Fully Implemented Property
        //Example: Height must have a positive non-zero value
        //         Height must not be greater than 8 feet 
        private double _Height;

        public double Height
        {
            get
            {
                return _Height;
            }
            set
            {
                //validation of data
                //throw exception if invalid
                if (value >0 && value <=8.0)
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

        //Fully Implemented Property;
        //this style NEEDS a private data member
        //The private data member will store the incoming data value
        //Usually this form of property is used when additional coding is required for the incoking data. 
        //  Such as: validation of the data

        //example: the string data CAN NOT be an empty string
        private string _Style; 

        public string Style
        {
            //The keyword "Value" holds the incoming data to the property 
            get
            {
                //Get returns the stored data value
                return _Style;
            }
            set
            {
                //Set stores the incoming value in "value" to the private data member for storage
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

        //nullable numeric property for a double
        //there are ONLY two possibilities: 
        //  a) data is missing: which means its 'null'
        //  b) data is present and is of the right data type

        public double? Price { get; set; }

        //Constructor

        //Either you could code your constructors or you omit your constructors
        //IF you omit constructors then the system will initialize 
        //  your data members to the natural system defaults for that data member datatype. 

        //If you code any constructors, you are responsible for coding all constructors to be used by this class

        //default
        //simulates the system initialization of your data
        //default executes on a : new FencePanel();
        public FencePanel()
        {
            //optionally you can override the system values with your own values 
            Height = 6.0;
            Width = 8.0;
            //the remainder of your data value would be the system values 
        }

        //Greedie constructor
        //The constructor has a list of parameters which will recieve an argument value for each property in the class 
        
        public FencePanel(double height, double width, string style, double? price)
        {
            Height = height;
            Width = width;
            Style = style;
            Price = price;
        }

        //Behaviours (a.k.a methods) 
        public double EstimatedNumberOfPanels(double linearlength)
        {
            //linearlength is the full length of the fence needed
            //You could use either the Width property or the data member _Width
            //Using the property ensures all validation or excess logic is in play 
            double numberofpanels = linearlength / Width; //or we could use _Width
            return numberofpanels; 
        }

        public double FenceArea(double linearlength)
        {
            //return linearlength * Height;
            return Width * Height * EstimatedNumberOfPanels(linearlength);
        }

    } //eoc: end of class
}//eon: end of name
