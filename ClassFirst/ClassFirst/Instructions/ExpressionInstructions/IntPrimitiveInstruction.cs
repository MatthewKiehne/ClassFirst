using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    class IntPrimitiveInstruction : ExpressionInstruction {

        public int Value { get; private set; }
        public IntPrimitiveInstruction( int value) {
            Value = value;
        }
        public Value Execute() {
            return new Value(Primitive.DefaultVariableType, Value);
        }
    }
}
