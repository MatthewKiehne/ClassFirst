using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    public class BlockInstruction : StatementInstruction {

        public StatementInstruction[] Instructions { get; private set; }
        public BlockInstruction(StatementInstruction[] instructions) {
            Instructions = instructions;
        }

        public Empty Execute() {
            Scope scope = new Scope(ScopeType.Other);
            ScopeContainer.AddScope(scope);

            foreach(StatementInstruction instruction in Instructions) {
                instruction.Execute();
            }

            Scope returnScope = ScopeContainer.Top();
            if (!returnScope.Equals(scope)) {
                throw new Exception("exit scope is different than one inserted");
            }

            ScopeContainer.RemoveTopScope();
            return new Empty();
        }
    }
}
