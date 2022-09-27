using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    class IntInstruction : ExpressionInstruction {

        public int Value { get; private set; }
        public IntInstruction(int value) {
            Value = value;
        }
        public Value Execute() {
            // clone the int class from the class container instead of this
            List<ExpressionInstruction> expressionInstructions = new List<ExpressionInstruction>();
            expressionInstructions.Add(new IntPrimitiveInstruction(Value));
            ClassInstruction intInstruction = new ClassInstruction(Primitive.IntClassName, ClassType.PrimitiveClass, expressionInstructions);
            return intInstruction.Execute();
        }
    }
}
