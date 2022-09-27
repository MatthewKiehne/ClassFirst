using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    class IntegerInstruction : Instruction<int> {

        public int Value { get; private set; }
        public IntegerInstruction (int value) {
            Value = value;
        }
        public int Execute() {

           /* Class c = new Class("int", ContainerType.Primitive);
            c.Fields.Add(new Field(new Variable("def", "int")))*/
            return 0;
        }
    }
}
