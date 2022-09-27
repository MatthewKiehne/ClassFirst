using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    public interface Instruction<T> {

        public Result<T> Execute();
        public RuleContext GetContext();
    }
}
