using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteDecorator
{
    public class Soy : CondimentDecorator
    {
        Beverage Beverage;
        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return .35 + Beverage.Cost();
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Soy";
        }
    }
}
