using Autodesk.Revit.DB.Electrical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRevitCommand.Adapter
{
   public interface IAdapterConduit
    {
        Conduit _Conduit {  set; }
        double Lenght {  get; }
        double Diameter { get; }
        double Height { get; }

    }
}
