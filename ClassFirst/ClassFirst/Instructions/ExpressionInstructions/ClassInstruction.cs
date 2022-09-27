using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Instructions {
    public class ClassInstruction : ExpressionInstruction {

        private RuleContext _context;
        public string ClassName { get; private set; }
        public ClassType ClassType { get; private set; }

        // these are the variables used to create this class
        public List<ExpressionInstruction> ConstructorExpressions;

        public ClassInstruction(RuleContext context, string className, ClassType classType, List<ExpressionInstruction> constructorExpressions) {
            ClassName = className;
            ClassType = classType;
            ConstructorExpressions = constructorExpressions;
        }

        public RuleContext GetContext() {
            return _context;
        }

        public Result<Value> Execute() {

            Result<Value> result = new Result<Value>();

            // this gets called when a class gets constructed at runtime

            ClassInfo classInfo = ClassLookup.GetClassInfo(ClassName);
            Class c = new Class(classInfo.ClassName);
            if(classInfo.Type != null) {
                c = new Class(classInfo.Type);
            }

            Scope classScope = new Scope(c);
            ScopeContainer.AddScope(classScope);

            foreach(FieldInstruction fi in classInfo.FieldInstructions) {
                Field field = fi.Execute();
                c.Fields.Add(field.GetName(), field);
            }

            // Get the parametes for the constructor
            List<Value> constructorParameters = new List<Value>();
            foreach(ExpressionInstruction constructorExpression in ConstructorExpressions) {
                
                Result<Value> par = constructorExpression.Execute();
                
                if(par.HasErrors()) {
                    par.AddContext(_context);
                    return par;
                
                }
                constructorParameters.Add(par.Obj);
            }

            // find the constructor
            FunctionInfo constructorInfo = classInfo.GetConstructor(constructorParameters.ToArray());

            // run the constructor
            Scope testingScope = ScopeContainer.Top();
            constructorInfo.AddParametesToCurrentScope(constructorParameters.ToArray());
            constructorInfo.RunInstruction();

            // remove the scope
            Scope topScope = ScopeContainer.Top();
            if(!topScope.Equals(classScope)) {
                throw new Exception("Top level scope does not match one added");
            }

            return new Value(ClassName, c);
        }
    }
}
