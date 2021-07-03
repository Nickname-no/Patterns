using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Interpreter
{
    class МanyTabs : AbstractExpression
    {

        public МanyTabs(int one) : base(one)
        { }

        public override void interpret(ref String context)
        {
            context = (new Regex("( \t)+")).Replace(context, "\t");
            context = (new Regex("(\t )+")).Replace(context, "\t");
            context = (new Regex("\t+")).Replace(context, "\t");
            context = (new Regex("[ \t]+\n+")).Replace(context, "\n");
        }
    }
}
