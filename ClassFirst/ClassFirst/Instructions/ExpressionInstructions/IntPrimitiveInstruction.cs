using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    class IntPrimitiveInstruction : ExpressionInstruction {

        private RuleContext _context;
        public int Value { get; private set; }
        public IntPrimitiveInstruction(RuleContext context, int value) {
            _context = context;
            Value = value;
        }
        public Result<Value> Execute() {
            Result<Value> result = new Result<Value>();
            Value v = new Value(Primitive.DefaultVariableType, Value);
            return result.SetResource(v);
        }

        public RuleContext GetContext() {
            return _context;
        }
    }
}
