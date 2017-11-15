using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a operation: + - * /");
            String operation = Console.ReadLine();

            Operation oper;

            oper = OperationFactory.CreateOperate(operation);

            Console.WriteLine("Please input the Number A:");
            oper.NumA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the Number B:");
            oper.NumB = Convert.ToDouble(Console.ReadLine());


            double result = oper.GetResult();
            Console.WriteLine("The result is :"+result.ToString());
        }
    }
}
