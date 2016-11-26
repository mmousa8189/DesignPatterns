using System;

namespace StrategyPattern
{
    public sealed class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehavior=new FlyNoWay();
            QuackBehavior=new MuteQuack();
        }
        public override void Display()
        {
           Console.WriteLine("I'm a duck Decoy");
        }

    }
}

