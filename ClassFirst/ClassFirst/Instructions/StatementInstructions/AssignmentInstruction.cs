using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    class AssignmentInstruction : StatementInstruction {

        public string VariableName { get; private set; }
        public ExpressionInstruction ExpressionInstruction { get; private set; }

        public AssignmentInstruction(string variableName, ExpressionInstruction expressionInstruction) {
            VariableName = variableName;
            ExpressionInstruction = expressionInstruction;
        }

        public Empty Execute() {

            Variable variable = ScopeContainer.FindVariableInScope(VariableName);
            if(variable == null) {
                throw new Exception("Failed to find variable " + VariableName);
            }
            
            Value value = ExpressionInstruction.Execute();

            if (!value.TypeName.Equals(variable.ValueType)) {
                throw new Exception("can not assign value with type of " + value.GetType() + " to variable with type of " + variable.GetType());
            }

            variable.Value = value;

            return new Empty();
        }
    }
}
