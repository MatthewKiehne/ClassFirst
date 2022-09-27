using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using ClassFirst.Instructions;
using System;
using System.Collections.Generic;
using System.Text;
using static ClassFirst.ClassFirstParser;

namespace ClassFirst.Visitors {
    public class ClassListener : ClassFirstBaseVisitor<ClassInstruction> {

        private ClassInstruction workingClassInstructions = null;

        public ClassListener() {

        }

        public override ClassInstruction VisitClassBlock([NotNull] ClassFirstParser.ClassBlockContext context) {
            foreach (ClassMemberContext classMember in context.classMember()) {
                Visit(classMember);
            }
            return base.VisitClassBlock(context);
        }

        public override ClassInstruction VisitClassConstructorDeclaration([NotNull] ClassConstructorDeclarationContext context) {

            

            return null;
        }

        public override ClassInstruction VisitClassDeclaration([NotNull] ClassFirstParser.ClassDeclarationContext context) {
/*            string classType = context.Identifier().GetText();
            workingClassInstructions = new ClassInstruction(classType, ContainerType.Reference);
            Visit(context.classBlock());*/
            return null;
        }

        public override ClassInstruction VisitClassMember([NotNull] ClassMemberContext context) {
            return base.VisitClassMember(context);
        }

        public override ClassInstruction VisitFieldDeclaration([NotNull] ClassFirstParser.FieldDeclarationContext context) {
            string modifier = context.Modifier().GetText();
            Modifier mod = (Modifier)Enum.Parse(typeof(Modifier), modifier);
            
            string typeName = context.variableDeclaration().TypeName().GetText();
            string variableName = context.variableDeclaration().Identifier().GetText();

            ExpressionVisitor expressionVisitor = new ExpressionVisitor();
            ExpressionInstruction expressionInstruction = expressionVisitor.Visit(context.exception.Context);

            VariableInstruction variableInstruction = new VariableInstruction(variableName, typeName, expressionInstruction);
            FieldInstruction fieldInstruction = new FieldInstruction(mod, variableInstruction);
            //workingClassInstructions.FieldInstructions.Add(fieldInstruction);

            return workingClassInstructions;
        }

        public override ClassInstruction VisitIntExpression([NotNull] ClassFirstParser.IntExpressionContext context) {
            return base.VisitIntExpression(context);
        }

        public override ClassInstruction VisitParse([NotNull] ClassFirstParser.ParseContext context) {
            Visit(context.classDeclaration());
            return workingClassInstructions;
        }

        public override ClassInstruction VisitStatement([NotNull] StatementContext context) {
            return base.VisitStatement(context);
        }
    }
}
