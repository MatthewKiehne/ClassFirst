using ClassFirst.Instructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public class Class {
        public string ClassName { get; private set; }
        public ClassType ClassType { get; private set; }
        public Dictionary<string,Field> Fields { get; private set; }

        // this holds what the class should be cast into, if it is null then the class is not from another class..... confusing
        public Type ClassCast { get; private set; } = null;

        public Class(string className) {
            Fields = new Dictionary<string, Field>();
            ClassName = className;
            ClassType = ClassType.External;
        }

        public Class(Type type) {
            Fields = new Dictionary<string, Field>();
            ClassName = type.Name;
            ClassCast = type;
            if(type.IsPrimitive) {
                ClassType = ClassType.PrimitiveClass;
            } else {
                ClassType = ClassType.Reference;
            }
        }

        public Value GetDefaultValue() {
            if(ClassType == ClassType.External) {
                throw new Exception("Can not get defualt value of external class");
            }

            return Fields[Primitive.DefaultVariableName].Variable.Value;
        }
    }
}
