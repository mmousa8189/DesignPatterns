using System;

namespace StrategyPattern
{
    public sealed class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
        }
        public override void Display()
        {
           Console.WriteLine("I'm a real Red Headed duck");
        }

    }
}

