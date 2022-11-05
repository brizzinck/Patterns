using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class HolidayMaker : IVisitor
    {
        public string Value;
        public void Visit(Zoo zoo) => Value = "Слон в зоопарке!";

        public void Visit(Cinema cinema) => Value = "Кино - Человек Паук!";

        public void Visit(Circus circus) => Value = "Клоун в цирке!";
    }
}
