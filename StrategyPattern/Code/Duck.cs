﻿using System;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public  IFlyBehavior FlyBehavior
        {
            get;
            set;
        }

        public IQuackBehavior QuackBehavior
        {
            get;
            set;
        }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.fly();
        }

        public  void PerformQuack()
        {
            QuackBehavior.quack();
        }

        public  void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

    }
}

