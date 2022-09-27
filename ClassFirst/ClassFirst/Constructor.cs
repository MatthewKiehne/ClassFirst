using ClassFirst.Instructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public class Constructor {

        // fist string is the typeName and the second is the name of the variable
        public KeyValuePair<string, string>[] Parameters { get; private set; }
        public StatementInstruction[] Instructions;

        public Constructor(KeyValuePair<string, string>[] parameters, StatementInstruction[] instructions) {
            Parameters = parameters;
            Instructions = instructions;
        }
    }
}
