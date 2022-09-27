using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public enum ContainerType {
        Primitive,  // int, double...
        PrimitiveClass, // a class that holds the primitive value
        Reference,  // class, interface...
        Value       // string, object...
    }
}
