using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterMatch
{
    public class OperationSum: ExpressionMath
    {
        ExpressionMath expression1;
        ExpressionMath expression2;

        public OperationSum(ExpressionMath exp1, ExpressionMath exp2)
        {
            expression1 = exp1;
            expression2 = exp2;
        }

        public override double Interpret(ContextExpression context)
        {
            return expression1.Interpret(context) + expression2.Interpret(context);
        }
       
    }
}
