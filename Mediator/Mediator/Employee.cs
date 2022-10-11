using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class Employee
    {
        protected IMediator mediator;
        public Employee(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
