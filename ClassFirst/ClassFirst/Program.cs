using ClassFirst.Instructions;
using ClassFirst.Instructions.ExpressionInstructions;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ClassFirst {
    class Program {
        static void Main(string[] args) {



            ReferenceFactor.AddReference(typeof(int));

            // create an int
            IntInstruction firstInstruction = new IntInstruction(null, 24);
            IntInstruction secondInstruction = new IntInstruction(null, 11);

            OperationInstruction opInstsruction = new OperationInstruction(null, firstInstruction, secondInstruction, Operator.Add);
            Result<Value> added = opInstsruction.Execute();
            Value defaultValue = ((Class)added.Resource.Object).GetDefaultValue();
            Console.WriteLine(defaultValue);
        }
    }
}
