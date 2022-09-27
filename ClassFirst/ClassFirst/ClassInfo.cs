using ClassFirst.Instructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public class ClassInfo {

        public string ClassName;
        public ClassType ClassType;
        public List<FunctionInfo> Constructors { get; private set; }
        public List<FieldInstruction> FieldInstructions { get; private set; }
        public Type Type { get; private set; }

        public ClassInfo(string className) {
            ClassName = className;
            ClassType = ClassType.External;
            Constructors = new List<FunctionInfo>();
            FieldInstructions = new List<FieldInstruction>();
        }

        public ClassInfo(Type type) {
            Type = type;
            ClassName = type.Name;
            ClassType = ClassType.Reference;
            Constructors = new List<FunctionInfo>();
            FieldInstructions = new List<FieldInstruction>();
        }

        public FunctionInfo GetConstructor(Value[] values) {
            FunctionInfo result = Constructors.Find(constructor => constructor.ParameterDeclaration.MatchParameters(values));
            if(result == null) {
                throw new Exception("Unable to find constructor");
            }
            return result;
        }
    }
}
