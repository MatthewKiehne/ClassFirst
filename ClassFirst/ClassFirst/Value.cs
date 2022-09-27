using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public class Value {

        // this is used for lookup
        public string TypeName {
            get;
            private set;
        }

        public Object Object {
            get;
            private set;
        }

        public Value(string typeName, Object obj) {
            TypeName = typeName;
            Object = obj;

            if(obj == null) {
                typeName = Primitive.NullTypeName;
            }
        }
    }
}
