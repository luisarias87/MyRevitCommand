using Autodesk.Revit.DB.Electrical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRevitCommand.Domain
{
    internal class MyConduitDataMapping : IConduit
    {
        private readonly Conduit _Conduit;
        public double Lenght { get; }
        public double Diameter { get; }
        public double Height { get; }

        //This Constructor is for data mapping
        public MyConduitDataMapping( double length, double diameter, double height)
        {

            Lenght = length;
            Diameter = diameter;
            Height = height;
        }
    }
}
