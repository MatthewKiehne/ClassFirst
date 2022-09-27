using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using ClassFirst.Instructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Visitors {
    class ExpressionVisitor : ClassFirstBaseVisitor<ExpressionInstruction> {

        public override ExpressionInstruction VisitIntExpression([NotNull] ClassFirstParser.IntExpressionContext context) {
            string intValue = context.Int().GetText();
            int value = int.Parse(intValue);
            IntInstruction intInstruction = new IntInstruction(value);
            return intInstruction;
        }
    }
}
