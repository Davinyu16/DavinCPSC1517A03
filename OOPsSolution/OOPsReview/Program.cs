using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Program
    {
        //assume you know how to obtain user entered data 
        static void Main(string[] args)
        {
            double height = 6.5;
            double width = 8.0;
            double linearlength = 135.0;
            string style = "Neighbour Friendly: Spruce";
            double price = 108.00;

            //store the fence area
            //declare a storage area for the fence data 

            //create a non-static instance of a class 
            //use the new command to create the class instance
            //the new command references the class constructor 
            FencePanel fenceinfo = new FencePanel(height, width, style, price);

            //obtain and store gate data
            FenceGate gateInfo;
            List<FenceGate> gateList = new List<FenceGate>();

            //assume looping to obtain all gate data
            //each loop is one gate
            //pass 1
            gateInfo = new FenceGate(); //system constructor since Gate has no constructors
            height = 6.25;
            width = 4.0;
            style = "Neighbour Friendly 1/2 Picket: Spruce";
            price = 86.45;
            gateInfo.Height = height;
            gateInfo.Width = width;
            gateInfo.Style = style;
            gateInfo.Price = price;
            gateList.Add(gateInfo);

            //pass 2
            gateInfo = new FenceGate(); //system constructor since Gate has no constructors
            height = 6.25;
            width = 4.0;
            style = "Neighbour Friendly: Spruce";
            price = 86.45;
            //name of the instance, the dotoperator (the period), the property = value
            gateInfo.Height = height;
            gateInfo.Width = width;
            gateInfo.Style = style;
            gateInfo.Price = price;
            gateList.Add(gateInfo);

            //assume end of gate looping

            //create the estimate
            Estimate theEstimate = new Estimate(); //class default constructor
            theEstimate.LinearLength = linearlength;
            theEstimate.Panel = fenceinfo;
            theEstimate.Gates = gateList;

            //name of the instance, the . and the behavior(method) name
            theEstimate.CalculatePrice();

            //client wishes a output of the estimate
            //both ways below is correct, just depends which one you want 
            Console.WriteLine("The fence is to be a " + theEstimate.Panel.Style + " style");
            Console.WriteLine("Total linear length requested {0}", theEstimate.LinearLength);
            Console.WriteLine("Number of required panels: {0}", theEstimate.Panel.EstimatedNumberOfPanels(linearlength));
            //.count lets you count the number of instances inside Gates
            Console.WriteLine("Number of gates: {0}", theEstimate.Gates.Count);
            double fenceArea = theEstimate.Panel.FenceArea(theEstimate.LinearLength);

            foreach (var item in theEstimate.Gates)
            {
                fenceArea += item.GateArea();
            }
            Console.WriteLine(string.Format("total fence surface area {0:0.00}", fenceArea * 2));
            Console.ReadKey();

        }
    }
}
