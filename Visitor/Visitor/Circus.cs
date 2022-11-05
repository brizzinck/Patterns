﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Circus : IPlace
    {
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
