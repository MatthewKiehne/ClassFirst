using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public class Result<T> {

        public T Obj { get; private set; }
        public string ErrorMessage { get; set; }
        public List<RuleContext> ErrorContexts { get; private set; }

        public Result() {
            ErrorContexts = new List<RuleContext>();
        }

        public void AddContext(RuleContext context) {
            ErrorContexts.Add(context);
        }

        public void SetObj(T obj) {
            Obj = obj;
        }

        public bool HasErrors() {
            return ErrorMessage != null && ErrorContexts.Count != 0;
        }

        public void AddError(string message, RuleContext context) {
            ErrorMessage = message;
            ErrorContexts.Add(context);
        }

        public void AddErrorsFrom(Result<object> result) {
            ErrorMessage = result.ErrorMessage;
            ErrorContexts.AddRange(result.ErrorContexts);
        }
    }
}
