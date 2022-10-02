using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    public class ParameterBlock : StatementInstruction {

        // fist string is the typeName and the second is the name of the variable
        public KeyValuePair<string, string>[] Parameters { get; private set; }
        public StatementInstruction[] Instructions { get; private set; }
        public ScopeType ScopeType { get; private set; }
        private RuleContext _context;

        public ParameterBlock(RuleContext context, KeyValuePair<string, string>[] parameters, StatementInstruction[] instructions, ScopeType scopeType) {
            Parameters = parameters;
            Instructions = instructions;
            ScopeType = scopeType;
            _context = context;

            if(scopeType == ScopeType.Class) {
                throw new Exception("this class is not ment to be used by the class");
            }
        }

        public Empty Execute() {

            Scope scope = new Scope(ScopeType);
            ScopeContainer.AddScope(scope);

            // add all the parameters to the scope

            foreach(StatementInstruction instruction in Instructions) {
                instruction.Execute();
            }

            Scope removeScope = ScopeContainer.Top();
            if(!scope.Equals(removeScope)) {
                throw new Exception("scope removed is not the expected scope");
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
