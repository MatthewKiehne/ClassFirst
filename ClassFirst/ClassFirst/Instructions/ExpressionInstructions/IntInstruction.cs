using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    class IntInstruction : ExpressionInstruction {

        private RuleContext _context { get; set; }
        public int Value { get; private set; }
        public IntInstruction(RuleContext context, int value) {
            Value = value;
            _context = context;
        }
        public Result<Value> Execute() {
            // clone the int class from the class container instead of this
            List<ExpressionInstruction> expressionInstructions = new List<ExpressionInstruction>();
            expressionInstructions.Add(new IntPrimitiveInstruction(_context, Value));
            ClassInstruction intInstruction = new ClassInstruction(_context, Primitive.IntClassName, ClassType.PrimitiveClass, expressionInstructions);
            return intInstruction.Execute();
        }

        public RuleContext GetContext() {
            return _context;
        }
    }
}
