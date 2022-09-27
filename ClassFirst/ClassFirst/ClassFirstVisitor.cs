using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using ClassFirst.Instructions;
using System;
using System.Collections.Generic;
using System.Text;
using static ClassFirst.ClassFirstParser;

namespace ClassFirst {
    public class ClassFirstVisitor : ClassFirstBaseVisitor<Instruction<Class>> {
        
        public ClassFirstVisitor() {
        }
    }
}
