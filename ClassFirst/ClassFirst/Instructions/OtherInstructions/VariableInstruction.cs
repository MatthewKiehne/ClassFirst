using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    public class VariableInstruction : Instruction<Variable> {

        public string Name { get; private set; }
        public string ValueType { get; private set; }
        public ExpressionInstruction ExpressionInstruction { get; private set; }

        public Variable Execute() {
            Value value = ExpressionInstruction.Execute();
            return new Variable(Name, ValueType, value);
        }

        public VariableInstruction(string name, string valueType, ExpressionInstruction expressionInstruction) {
            Name = name;
            ValueType = valueType;
            ExpressionInstruction = expressionInstruction;
        }
    }
}
