using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRevitCommand.Domain
{
    public interface IConduit
    {
        double Lenght { get; }
        double Diameter { get; }
        double Height { get; }
    }
}
