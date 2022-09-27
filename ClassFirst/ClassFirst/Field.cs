using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public class Field {

        public Modifier Modifier { get; private set; }
        public Variable Variable { get; private set; }

        public Field(Modifier modifier, Variable variable) {
            Modifier = modifier;
            Variable = variable;
        }

        public string GetName() {
            return Variable.Name;
        }
    }
}
