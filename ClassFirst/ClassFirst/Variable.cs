using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public class Variable {

        public string Name {
            get;
            private set;
        }

        public string ValueType { get; private set; }

        public Value Value { get; set; }

        public Variable(string name, string valueType, Value value) {
            Name = name;
            Value = value;
            ValueType = valueType;
        }
    }
}
