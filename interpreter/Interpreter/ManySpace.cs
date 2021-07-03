using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Interpreter
{
    class ManySpace : AbstractExpression
    {

        public ManySpace(int one) : base(one)
        { }

        public override void interpret(ref String context)
        { 
            context = (new Regex("[ ]+")).Replace(context, " ");
            context = (new Regex("^[ ]")).Replace(context, "");
        }
    }
}
