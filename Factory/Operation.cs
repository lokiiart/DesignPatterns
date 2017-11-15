using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Operation
    {
        public double NumA { get; set; } = 0.0d;
        public double NumB { get; set; } = 0.0d;

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumA + NumB;
            return result;
        }
    }

    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumA - NumB;
            return result;
        }
    }

    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumA * NumB;
            return result;
        }
    }

    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumB == 0) throw new Exception("除数不能为0");
            result = NumA / NumB;
            return result;

        }
    }

}
