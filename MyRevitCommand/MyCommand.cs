using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB.Electrical;
using MyRevitCommand.Domain;

namespace MyRevitCommand
{
    [Transaction(TransactionMode.Manual)]
    public class MyCommand : IExternalCommand
    {
        

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            

            var uiApp = commandData.Application;
            var app  = uiApp.Application;
            var uiDoc = uiApp.ActiveUIDocument;
            var doc = uiDoc.Document;

            //user control instance not used yet
            var window = new UserControl1();
            window.Show();

            //here I retrieve a conduit from Revit to acquire its properties
            var selectedConduit = uiDoc.Selection.GetElementIds().First();

            //I use the doc instance to get the revit conduit
            var revitConduit = doc.GetElement(selectedConduit) as Conduit;

            //Here I use Data mapping to create a myConduitDataMapping instance.
            // Should I use a Record here? 
            var conduitLength = revitConduit
                .get_Parameter(BuiltInParameter.RBS_CABLETRAYCONDUITRUN_LENGTH_PARAM)
                .AsDouble();
            var conduitDiameter = revitConduit
                .get_Parameter(BuiltInParameter.RBS_CONDUIT_DIAMETER_PARAM)
                .AsDouble();
            var conduitHeight = revitConduit
                .get_Parameter(BuiltInParameter.RBS_PARALLELCONDUITS_VERTICAL_OFFSET_VALUE)
                .AsDouble();
            var myConduit = new MyConduitDataMapping(conduitLength,conduitDiameter,conduitHeight);

            // below I will use my Adapter interface to create an AdapterConduit instance using the 
            //Retreived revit conduit in its construcor
            //I am having trouble in my IAdapterConduit interface because of the Conduit Field
            // Im not sure yet how to impletment the field correctlty.

            return Result.Succeeded;
        }
    }
}
