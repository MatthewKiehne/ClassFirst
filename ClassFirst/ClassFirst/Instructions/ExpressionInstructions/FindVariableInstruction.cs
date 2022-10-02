using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions.ExpressionInstructions {
    public class FindVariableInstruction : ExpressionInstruction {

        private RuleContext _context;
        public string FindVariableName { get; private set; }
        public FindVariableInstruction(RuleContext context, string variableName) {
            FindVariableName = variableName;
            _context = context;
        }

        public Result<Value> Execute() {
            Result<Value> result = new Result<Value>();
            
            Variable foundVariable = ScopeContainer.FindVariableInScope(FindVariableName);
            if(foundVariable == null) {
                return result.AddError("Failed to find variable", _context);
            }

            return result.SetResource(foundVariable.Value);
        }

        public RuleContext GetContext() {
            return _context;
        }
    }
}
