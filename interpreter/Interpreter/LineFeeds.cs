using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Interpreter
{
    class LineFeeds : AbstractExpression
    {

        public LineFeeds(int one) : base(one)
        { }

        public override void interpret(ref String context)
        { 
            context = (new Regex("(\r\n)+")).Replace(context, "\r\n");
        }
    }
}
