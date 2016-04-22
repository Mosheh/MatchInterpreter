using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterMatch
{
    public class Variable : ExpressionMath, IVariable
    {
        public string Name { get;  set; }

        public Variable(string name)
        {
            Name = name;
        }
        public override double Interpret(ContextExpression context)
        {
            return context.Lookup(Name);
        }
    }
}
