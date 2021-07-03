using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interpreter
{
    class HyphenDash : AbstractExpression
    {

        public HyphenDash(int one) : base(one)
        { }

        public override void interpret(ref String context)
        {
            context = (new Regex("( - )+")).Replace(context, " — ");
        }
    }
}
