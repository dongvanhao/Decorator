using Coffee_tutorialDecorator_;

class program
{
    
    static void Main()
    {
        
        ICoffee coffee = new BasicCoffee();
        Console.WriteLine($"{coffee.GetDescription()} có giá {coffee.GetCost()}K");

        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} có giá {coffee.GetCost()}K");

        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} có giá {coffee.GetCost()}K");

        coffee = new CreamDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} có giá {coffee.GetCost()}K");
    }
}