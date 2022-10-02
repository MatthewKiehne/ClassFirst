using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    public class BlockInstruction : StatementInstruction {

        public StatementInstruction[] Instructions { get; private set; }
        private RuleContext _context;
        public BlockInstruction(RuleContext context, StatementInstruction[] instructions) {
            Instructions = instructions;
            _context = context;
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

        Result<Empty> Instruction<Empty>.Execute() {
            throw new NotImplementedException();
        }

        public RuleContext GetContext() {
            return _context;
        }
    }
}
