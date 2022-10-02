using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    public class FieldInstruction : Instruction<Field> {

        public VariableInstruction VariableInstruction { get; private set; }
        public Modifier Modifier { get; private set; }
        private RuleContext _context;

        public FieldInstruction(RuleContext context, Modifier modifier, VariableInstruction variableInstruction) {
            Modifier = modifier;
            VariableInstruction = variableInstruction;
            _context = context;
        }

        public Result<Field> Execute() {
            Result<Field> result = new Result<Field>();

            Result<Variable> variable = VariableInstruction.Execute();
            if(variable.HasErrors()) {
                return result.AddErrorsFrom(variable).AddContext(_context);
            }

            Field field = new Field(Modifier, variable.Resource);
            return result.SetResource(field);
        }

        public RuleContext GetContext() {
            return _context;
        }
    }
}
