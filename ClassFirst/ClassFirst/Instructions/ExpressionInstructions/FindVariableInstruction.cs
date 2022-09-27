using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions.ExpressionInstructions {
    public class FindVariableInstruction : ExpressionInstruction {

        public string FindVariableName { get; private set; }
        public FindVariableInstruction(string variableName) {
            FindVariableName = variableName;
        }

        public Value Execute() {
            Variable foundVariable = ScopeContainer.FindVariableInScope(FindVariableName);
            if(foundVariable == null) {
                throw new Exception("Failed to find variable");
            }
            return foundVariable.Value;
        }
    }
}
