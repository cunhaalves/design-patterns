using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Component
{
    public abstract class Beverage
    {
        public string Description = "Unknown Beverage";

        public String GetDescription()
        {
            return Description;
        }

        public abstract double Cost();


    }
}
