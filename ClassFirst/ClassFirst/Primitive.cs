using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public static class Primitive {

        public static readonly string DefaultVariableName = "def";

        public static readonly string NullTypeName = "null";

        public static string IntClassName = "int";
        public static string IntPrimitiveName = "intPrimitive";

        public static readonly string DefaultParameterName = "initParam";
        public static readonly string DefaultVariableType = "defaultVariableType";

        public static readonly Type IntType = typeof(int);

        public static readonly HashSet<Operator> ValidIntOperators = new HashSet<Operator> { 
            Operator.Add,
            Operator.Subtract
        };
    }
}
