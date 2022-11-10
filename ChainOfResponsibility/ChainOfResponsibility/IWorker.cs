﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IWorker
    {
        public IWorker SetNextWorker(IWorker worker);
        public string Execute(string command);
    }
}
