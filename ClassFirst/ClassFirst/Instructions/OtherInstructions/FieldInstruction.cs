using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    public class FieldInstruction : Instruction<Field> {

        public VariableInstruction VariableInstruction { get; private set; }
        public Modifier Modifier { get; private set; }

        public FieldInstruction(Modifier modifier, VariableInstruction variableInstruction) {
            Modifier = modifier;
            VariableInstruction = variableInstruction;
        }


        public Field Execute() {
            Variable variable = VariableInstruction.Execute();
            return new Field(Modifier, variable);
        }
    }
}
