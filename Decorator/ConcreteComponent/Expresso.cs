using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteComponent
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "Expresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
