using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    public class VariableInstruction : Instruction<Variable> {

        public string Name { get; private set; }
        public string ValueType { get; private set; }
        public ExpressionInstruction ExpressionInstruction { get; private set; }
        private RuleContext _context;

        public VariableInstruction(RuleContext context, string name, string valueType, ExpressionInstruction expressionInstruction) {
            Name = name;
            ValueType = valueType;
            ExpressionInstruction = expressionInstruction;
            _context = context;
        }

        public Result<Variable> Execute() {
            Result<Variable> result = new Result<Variable>();

            Result<Value> value = ExpressionInstruction.Execute();
            if(value.HasErrors()) {
                return result.AddErrorsFrom(value).AddContext(_context);
            }
            
            Variable variable = new Variable(Name, ValueType, value.Resource);
            return result.SetResource(variable);
        }

        public RuleContext GetContext() {
            return _context;
        }
    }
}
