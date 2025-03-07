using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_tutorialDecorator_
{
    public class CreamDecorator : CoffeeDecorator
    {
        public CreamDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => _coffee.GetDescription() + " + Kem";
        public override double GetCost() => _coffee.GetCost() + 7;
    }
    
}
