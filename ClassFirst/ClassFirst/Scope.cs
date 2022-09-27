using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ClassFirst {


    public class Scope {

        public ScopeType ScopeType { get; private set; }

        public Class Class { get; private set; }

        private Dictionary<string, Variable> _variables = new Dictionary<string, Variable>();

        public Scope(ScopeType scopeType) {
            ScopeType = scopeType;
            if (ScopeType == ScopeType.Class) {
                throw new Exception("Should use Scope's class constructor.");
            }
        }

        public Scope(Class c) {
            ScopeType = ScopeType.Class;
            Class = c;
            if (Class == null) {
                throw new Exception("Class can not be null");
            }
        }

        public Variable GetVariable(string variableName) {

            if (ScopeType == ScopeType.Class && Class.Fields.ContainsKey(variableName)) {
                return Class.Fields[variableName].Variable;
            } else if (_variables.ContainsKey(variableName)) {
                return _variables[variableName];
            }
            return null;
        }

        public void AddVariable(Variable variable) {
            if(GetVariable(variable.Name) != null) {
                throw new Exception("Variable with name already exists");
            }

            _variables.Add(variable.Name, variable);
        }
    }
}
