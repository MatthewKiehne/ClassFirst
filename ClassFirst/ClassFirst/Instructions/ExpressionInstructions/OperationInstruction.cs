using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions.ExpressionInstructions {
    class OperationInstruction : ExpressionInstruction {

        public RuleContext _context;
        public ExpressionInstruction Left { get; private set; }
        public ExpressionInstruction Right { get; private set; }
        public Operator Operator { get; private set; }

        public OperationInstruction (RuleContext context, ExpressionInstruction left, ExpressionInstruction right, Operator op) {
            Left = left;
            Right = right;
            Operator = op;
            _context = context;
        }

        public Result<Value> Execute() {
            
            Result<Value> first = Left.Execute();
            if(first.HasErrors()) {
                return first.AddContext(_context);
            }
            
            Result<Value> second = Right.Execute();
            if(second.HasErrors()) {
                return second.AddContext(_context);
            }

            return Operate(first.Resource, second.Resource, Operator);
        }

        private Result<Value> Operate(Value fistValue, Value secondValue, Operator op) {

            Result<Value> result = new Result<Value>();

            if (!(fistValue.Object is Class) || !(secondValue.Object is Class)) {
                return result.AddError("both values have to have an object value of Class", _context);
            }

            Class firstClass = (Class)fistValue.Object;
            Class secondClass = (Class)secondValue.Object;

            if (firstClass.ClassCast == null || secondClass.ClassCast == null) {
                return result.AddError("Both objects must have a class cast type", _context);
            }

            if (!firstClass.ClassCast.IsPrimitive || !secondClass.ClassCast.IsPrimitive) {
                return result.AddError("Both objects musht have a type that is primitive", _context);
            }

            if (firstClass.ClassCast != secondClass.ClassCast) {
                return result.AddError("Both classes must have the same class cast type", _context);
            }

            Result<bool> validOperation = ValidOperatorForType(firstClass.ClassCast, op);
            if (validOperation.HasErrors() || validOperation.Resource == false) {
                return result.AddError("operator is not valid for the given type", _context);
            }

            return OperateOnType(firstClass, secondClass, op);
        }

        private Result<Value> OperateOnType(Class first, Class second, Operator op) {

            Result<Value> result = new Result<Value>();

            if (first.ClassCast == Primitive.IntType) {
                int afterOperation = OperateOnPrimitive<int>(first, second, op);

                return new IntInstruction(_context, afterOperation).Execute();
            }

            throw new Exception("");
        }

        private Result<bool> ValidOperatorForType(Type type, Operator op) {
            Result<bool> result = new Result<bool>();
            
            if (type == Primitive.IntType) {
                bool found = Primitive.ValidIntOperators.Contains(op);
                result.SetResource(found);
                return result;
            }

            result.AddError("valid operator not implemented yet", _context);
            return result;
        }

        private T OperateOnPrimitive<T>(Class first, Class second, Operator op) {
            switch (op) {
                case Operator.Add:
                    return Add<T>(first, second);
                case Operator.Subtract:
                    return Subtract<T>(first, second);
            }
            throw new Exception("Operation not supported yet");
        }

        private T Add<T>(Class firstClass, Class secondClass) {
            dynamic firstValue = (T)firstClass.GetDefaultValue().Object;
            dynamic secondValue = (T)secondClass.GetDefaultValue().Object;
            return firstValue + secondValue;
        }

        private T Subtract<T>(Class firstClass, Class secondClass) {
            dynamic firstValue = (T)firstClass.GetDefaultValue().Object;
            dynamic secondValue = (T)secondClass.GetDefaultValue().Object;
            return firstValue - secondValue;
        }

        public RuleContext GetContext() {
            return _context;
        }
    }
}
