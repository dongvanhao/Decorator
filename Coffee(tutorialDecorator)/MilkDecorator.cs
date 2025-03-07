using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_tutorialDecorator_
{
    public class MilkDecorator : CoffeeDecorator
    {
        
        public MilkDecorator(ICoffee coffee) : base(coffee) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }

        public override string GetDescription() => _coffee.GetDescription() + " + Sữa";
        public override double GetCost() => _coffee.GetCost() + 5;
    }
}
