using System;

namespace SelfBasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the Number A:");
            Double strNumberA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the Number B:");
            Double strNumberB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please choose a operation: + - * /");
            String operation = Console.ReadLine();

            Double result = Operation.GetResult(strNumberA, strNumberB, operation);
            Console.WriteLine(result.ToString());
        }
    }
}


//大写Double和小写double之间没有做过转化，程序运转正常。
//static声明静态方法可以直接调用