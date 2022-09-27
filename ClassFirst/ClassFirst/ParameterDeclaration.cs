using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public class ParameterDeclaration {

        public KeyValuePair<string, string>[] Parameters;

        public ParameterDeclaration(KeyValuePair<string, string>[] parameters) {
            Parameters = parameters;
        }

        public bool MatchParameters(Value[] values) {

            if (values.Length != Parameters.Length) {
                return false;
            }

            for (int i = 0; i < values.Length; i++) {
                if (!values[i].TypeName.Equals(Parameters[i].Key)) {
                    return false;
                }
            }

            return true;
        }
    }
}
