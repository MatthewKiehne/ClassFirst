using ClassFirst.Instructions.ExpressionInstructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    public static class ReferenceFactor {

        public static void AddReference(Type type) {
            if (ClassLookup.ContainsClassInfo(type.Name)) {
                throw new Exception("type: " + type.Name + " already exists in lookup");
            }

            if (type.IsPrimitive) {
                AddPrimitiveType(type);
            } else {
                AddReferenceType(type);
            }
        }

        private static void AddReferenceType(Type type) {
            throw new Exception("not made yet");
        }

        private static ExpressionInstruction GetPrimitiveInstruction(Type type) {
            if(type.Equals(Primitive.IntType)) {
                return new IntPrimitiveInstruction(null, 0);
            }
            throw new Exception("primitive type not found");
        }

        private static void AddPrimitiveType(Type type) {

            ExpressionInstruction primitiveInstruction = GetPrimitiveInstruction(type);

            // create the field
            VariableInstruction variableInstruction = new VariableInstruction(null, Primitive.DefaultVariableName, Primitive.DefaultVariableType, primitiveInstruction);
            FieldInstruction fieldInstruction = new FieldInstruction(null, Modifier.Public, variableInstruction);

            // create the constructor params
            KeyValuePair<string, string>[] intParams = new KeyValuePair<string, string>[1];
            intParams[0] = new KeyValuePair<string, string>(Primitive.DefaultVariableType, Primitive.DefaultParameterName);
            ParameterDeclaration parameterDeclaration = new ParameterDeclaration(intParams);

            // create the constructor logic
            List<StatementInstruction> statementInstructions = new List<StatementInstruction>();
            FindVariableInstruction findVariable = new FindVariableInstruction(null, Primitive.DefaultParameterName);
            AssignmentInstruction assignmentInstruction = new AssignmentInstruction(null, Primitive.DefaultVariableName, findVariable);
            statementInstructions.Add(assignmentInstruction);
            FunctionInfo constructorInfo = new FunctionInfo(parameterDeclaration, statementInstructions);

            // create the class info and add info into it
            ClassLookup.RegisterClass(type, Primitive.IntClassName);
            ClassInfo intClassInfo = ClassLookup.GetClassInfo(Primitive.IntClassName);
            intClassInfo.FieldInstructions.Add(fieldInstruction);
            intClassInfo.Constructors.Add(constructorInfo);

        }
    }
}
