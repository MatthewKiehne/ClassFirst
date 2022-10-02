using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    class IntegerInstruction : Instruction<int> {

        public int Value { get; private set; }
        private RuleContext _context;

        public IntegerInstruction (RuleContext context, int value) {
            Value = value;
            _context = context;
        }
        public Result<int> Execute() {

            /* Class c = new Class("int", ContainerType.Primitive);
             c.Fields.Add(new Field(new Variable("def", "int")))*/
            
            return new Result<int>().SetResource(0);
        }

        public RuleContext GetContext() {
            return _context;
        }
    }
}
