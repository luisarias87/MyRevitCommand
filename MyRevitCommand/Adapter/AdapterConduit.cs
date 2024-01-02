using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Electrical;
using MyRevitCommand.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRevitCommand.Adapter
{
    public class AdapterConduit : IAdapterConduit
    {
        Conduit IAdapterConduit._Conduit { set => throw new NotImplementedException(); }

        Conduit _Conduit;
        public double Lenght => _Conduit
            .get_Parameter(BuiltInParameter.RBS_CABLETRAYCONDUITRUN_LENGTH_PARAM).AsDouble();
            
        public double Diameter => _Conduit
            .get_Parameter(BuiltInParameter.RBS_CONDUITRUN_DIAMETER_PARAM).AsDouble();

        public double Height => _Conduit
            .get_Parameter(BuiltInParameter.RBS_PARALLELCONDUITS_VERTICAL_OFFSET_VALUE).AsDouble();

    
        public AdapterConduit(Conduit conduit)
        {
            this._Conduit = conduit;
                
        }
    }
}
