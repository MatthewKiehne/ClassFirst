using ClassFirst.Instructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public class FunctionInfo {

        public ParameterDeclaration ParameterDeclaration;
        private List<StatementInstruction> _instructions;

        public FunctionInfo(ParameterDeclaration parameterDeclaration, List<StatementInstruction> instructions) {
            ParameterDeclaration = parameterDeclaration;
            _instructions = instructions;
        }

        public void AddParametesToCurrentScope(Value[] values) {

            if(!ParameterDeclaration.MatchParameters(values)) {
                throw new Exception("Can not add parameters to scope because of types do not match");
            }
            
            for(int i = 0; i < values.Length; i++) {
                Value v = values[i];
                KeyValuePair<string, string> param = ParameterDeclaration.Parameters[i];

                ScopeContainer.Top().AddVariable(new Variable(param.Value, param.Key, v));
            }
        }

        public void RunInstruction() {
            foreach(StatementInstruction instruction in _instructions) {
                instruction.Execute();
            }
        }
    }
}
