using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterMatch
{
    public class ContextExpression
    {
        public Dictionary<string, double> map = new Dictionary<string, double>();
        public double Lookup(string name)
        {
            return (map[name]);
        }

        public void Assign(IVariable variable, double value)
        {
            map.Add(variable.Name, value);
        }
    }
}
