using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using ClassFirst.Instructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst.Visitors {
    class FieldVisitor : ClassFirstBaseVisitor<FieldInstruction> {
        protected override FieldInstruction DefaultResult => base.DefaultResult;

        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override string ToString() {
            return base.ToString();
        }

        public override FieldInstruction Visit(IParseTree tree) {
            return base.Visit(tree);
        }

        public override FieldInstruction VisitAssignment([NotNull] ClassFirstParser.AssignmentContext context) {
            return base.VisitAssignment(context);
        }

        public override FieldInstruction VisitBlock([NotNull] ClassFirstParser.BlockContext context) {
            return base.VisitBlock(context);
        }

        public override FieldInstruction VisitChildren(IRuleNode node) {
            return base.VisitChildren(node);
        }

        public override FieldInstruction VisitClassBlock([NotNull] ClassFirstParser.ClassBlockContext context) {
            return base.VisitClassBlock(context);
        }

        public override FieldInstruction VisitClassDeclaration([NotNull] ClassFirstParser.ClassDeclarationContext context) {
            return base.VisitClassDeclaration(context);
        }

        public override FieldInstruction VisitErrorNode(IErrorNode node) {
            return base.VisitErrorNode(node);
        }

        public override FieldInstruction VisitIntExpression([NotNull] ClassFirstParser.IntExpressionContext context) {
            return base.VisitIntExpression(context);
        }

        public override FieldInstruction VisitParse([NotNull] ClassFirstParser.ParseContext context) {
            return base.VisitParse(context);
        }

        public override FieldInstruction VisitStatement([NotNull] ClassFirstParser.StatementContext context) {
            return base.VisitStatement(context);
        }

        public override FieldInstruction VisitTerminal(ITerminalNode node) {
            return base.VisitTerminal(node);
        }

        protected override FieldInstruction AggregateResult(FieldInstruction aggregate, FieldInstruction nextResult) {
            return base.AggregateResult(aggregate, nextResult);
        }

        protected override bool ShouldVisitNextChild(IRuleNode node, FieldInstruction currentResult) {
            return base.ShouldVisitNextChild(node, currentResult);
        }
    }
}
