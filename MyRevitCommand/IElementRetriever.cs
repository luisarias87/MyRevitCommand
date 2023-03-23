using Autodesk.Revit.Creation;
using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document = Autodesk.Revit.DB.Document;

namespace MyRevitCommand
{
    public interface IElementRetriever
    {
        IList<Element> GetElements(Document document);
    }
}
