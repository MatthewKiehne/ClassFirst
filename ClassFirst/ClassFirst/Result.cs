using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public class Result<T> {

        public T Resource { get; private set; }
        public string ErrorMessage { get; set; }
        public List<RuleContext> ErrorContexts { get; private set; }

        public Result() {
            ErrorContexts = new List<RuleContext>();
        }

        public Result<T> AddContext(RuleContext context) {
            ErrorContexts.Add(context);
            return this;
        }

        public Result<T> SetResource(T obj) {
            Resource = obj;
            return this;
        }

        public bool HasErrors() {
            return ErrorMessage != null && ErrorContexts.Count != 0;
        }

        public Result<T> AddError(string message, RuleContext context) {
            ErrorMessage = message;
            ErrorContexts.Add(context);
            return this;
        }

        public Result<T> AddErrorsFrom<B>(Result<B> result) {
            ErrorMessage = result.ErrorMessage;
            ErrorContexts.AddRange(result.ErrorContexts);
            return this;
        }
    }
}
