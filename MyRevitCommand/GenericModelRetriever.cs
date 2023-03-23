using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyRevitCommand
{
    public class GenericModelRetriever : IElementRetriever
    {
        public IList<Element> GetElements(Document document)
        {
            return new FilteredElementCollector(document).OfCategory(BuiltInCategory.OST_GenericModel).ToList();
        }
    }
}
