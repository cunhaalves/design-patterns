using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteDecorator
{
    public class Mocha : CondimentDecorator
    {
        Beverage Beverage;
        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return .20 + Beverage.Cost();
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }
    }
}
