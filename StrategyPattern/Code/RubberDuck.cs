using System;

namespace StrategyPattern
{
    public sealed class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a rubber duckie");
        }

    }
}

