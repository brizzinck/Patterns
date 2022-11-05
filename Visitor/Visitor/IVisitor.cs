using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IVisitor
    {
        public void Visit(Zoo zoo);
        public void Visit(Cinema cinema);
        public void Visit(Circus circus);
    }
}
