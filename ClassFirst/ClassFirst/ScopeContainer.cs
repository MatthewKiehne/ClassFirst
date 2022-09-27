using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public static class ScopeContainer {

        private static LinkedList<Scope> scopeList = new LinkedList<Scope>();

        public static void AddScope(Scope scope) {
            scopeList.AddFirst(scope);
        }

        public static Variable FindVariableInScope(string variableName) {
            
            Variable result = null;
            LinkedListNode<Scope> currentScope = scopeList.First;

            while(result == null && currentScope != null) {

                result = currentScope.Value.GetVariable(variableName);

                if(result == null) {
                    if(currentScope.Value.ScopeType == ScopeType.Class) {
                        currentScope = null;
                    } else {
                        currentScope = currentScope.Next;
                    }
                }
            }

            return result;
        }

        public static Scope Top() {
            LinkedListNode<Scope> topNode = scopeList.First;
            if(topNode != null) {
                return topNode.Value;
            }
            return null;
        }

        public static void RemoveTopScope() {
            scopeList.RemoveFirst();
        }
    }
}
