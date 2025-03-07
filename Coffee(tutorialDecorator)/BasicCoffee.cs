using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_tutorialDecorator_
{
    public class BasicCoffee : ICoffee
    {
        public string GetDescription() => "Ca Phe";
        public double GetCost() => 20;
    }
    
}
