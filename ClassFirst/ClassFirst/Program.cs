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
            IntInstruction firstInstruction = new IntInstruction(24);
            IntInstruction secondInstruction = new IntInstruction(11);

            OperationInstruction opInstsruction = new OperationInstruction(firstInstruction, secondInstruction, Operator.Add);
            Value added = opInstsruction.Execute();
            Value defaultValue = ((Class)added.Object).GetDefaultValue();
            Console.WriteLine(defaultValue);
        }
    }
}
