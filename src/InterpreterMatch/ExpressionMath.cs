using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterMatch
{
    public abstract class ExpressionMath
    {
        public abstract double Interpret(ContextExpression context);
    }
}
