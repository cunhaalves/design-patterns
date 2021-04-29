using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteDecorator
{

    public class Whip : CondimentDecorator
    {
        Beverage Beverage;
        public Whip(Beverage beverage)
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
