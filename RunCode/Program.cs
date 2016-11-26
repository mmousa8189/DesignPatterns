using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern;

namespace RunCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Welcome To Design Patterns Tutorials Application. ====\n ");
            Console.WriteLine("Chose The Pattern To Run..");
            Console.WriteLine("1- for Strategy Pattern, 2- for Observer Pattern,\n");
            string input = GetInput();
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            RunCode(input);
            Console.WriteLine("\n--- Press Enter to Finish ---");
            Console.ReadKey();

        }
        #region Private Methods
        private static void StrategyPatternRun()
        {
            Console.WriteLine();
            MallardDuck mallard = new MallardDuck();
            RubberDuck rubberDuckie = new RubberDuck();
            DecoyDuck decoy = new DecoyDuck();

            ModelDuck model = new ModelDuck();

            mallard.PerformQuack();
            rubberDuckie.PerformQuack();
            decoy.PerformQuack();

            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();
        }
        private static void ObserverPatternRun()
        {
            Console.WriteLine();
            Console.WriteLine(" Under Implementation !!");
        }
        #endregion

        #region Helper

        static void RunCode(string input)
        {
            switch (input)
            {
                case "1":
                    StrategyPatternRun();
                    break;
                case "2":
                    ObserverPatternRun();
                    break;
            }
        }
        static string GetInput()
        {
            string result;
            Console.Write("Pattern : ");
            try
            {
                result = Console.ReadLine();
            }
            catch (System.IO.IOException)
            {
                result = string.Empty;
            }
            if (!string.IsNullOrEmpty(result))
                result = result.Trim();
            return result;
        }
        #endregion
    }
}
