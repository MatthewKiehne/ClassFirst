using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    class AssignmentInstruction : StatementInstruction {

        public string VariableName { get; private set; }
        public ExpressionInstruction ExpressionInstruction { get; private set; }
        private RuleContext _context;

        public AssignmentInstruction(RuleContext context, string variableName, ExpressionInstruction expressionInstruction) {
            VariableName = variableName;
            ExpressionInstruction = expressionInstruction;
            _context = context;
        }

        public Result<Empty> Execute() {
            Result<Empty> result = new Result<Empty>();

            Variable variable = ScopeContainer.FindVariableInScope(VariableName);
            if(variable == null) {
                return result.AddError("Failed to find variable " + VariableName, _context);
            }
            
            Result<Value> value = ExpressionInstruction.Execute();
            if (!value.Resource.TypeName.Equals(variable.ValueType)) {
                return result.AddError("can not assign value with type of " + value.GetType() + " to variable with type of " + variable.GetType(), _context);
            }

            variable.Value = value.Resource;
            return result.SetResource(new Empty());
        }

        public RuleContext GetContext() {
            return _context;
        }
    }
}
