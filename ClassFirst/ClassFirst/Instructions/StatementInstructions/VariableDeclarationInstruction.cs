using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions.StatementInstructions {
    class VariableDeclarationInstruction : StatementInstruction {

        public RuleContext GetContext() {
            throw new NotImplementedException();
        }

        Result<Empty> Instruction<Empty>.Execute() {
            throw new NotImplementedException();
        }
    }
}
