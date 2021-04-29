using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorator
{
    public abstract class CondimentDecorator: Beverage
    {
        public new abstract String GetDescription();
    }
}
