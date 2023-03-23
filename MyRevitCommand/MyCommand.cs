using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;

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

            var collector = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_GenericModel).ToList();

            TaskDialog.Show("123", collector.Count.ToString());

            var window = new UserControl1();

            window.Show();
            
                

            return Result.Succeeded;
        }
    }
}
