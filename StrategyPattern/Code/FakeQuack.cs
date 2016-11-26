using System;

namespace StrategyPattern
{
    public class FakeQuack : IQuackBehavior
    {
        public  void quack()
        {
            Console.WriteLine("Qwak");
        }

    }
}

