using ClassFirst.Instructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassFirst {
    public static class ClassLookup {

        private static Dictionary<string, ClassInfo> classes = new Dictionary<string, ClassInfo>();
        private static Dictionary<string, string> LookupName = new Dictionary<string, string>();

        public static void RegisterClass(string className) {
            classes.Add(className, new ClassInfo(className));
        }

        public static void RegisterClass(Type type, string lookupName) {
            if(ContainsClassInfo(lookupName)) {
                throw new Exception("look up name already in use");
            }
            if(classes.ContainsKey(type.Name)) {
                throw new Exception("type already in classes");
            }

            classes.Add(type.Name, new ClassInfo(type));
            LookupName.Add(lookupName, type.Name);
        }

        public static void RegisterClass(Type type) {
            classes.Add(type.Name, new ClassInfo(type));
        }

        public static ClassInfo GetClassInfo(string lookupName) {

            if (!ContainsClassInfo(lookupName)) {
                throw new Exception("lookup name not found");
            }
            string className = GetClassName(lookupName);

            return classes[className];
        }

        public static bool ContainsClassInfo(string lookupName) {
            string className = GetClassName(lookupName);
            return classes.ContainsKey(className);
        }

        private static string GetClassName(string lookupName) {
            string result = lookupName;
            if(LookupName.ContainsKey(lookupName)) {
                result = LookupName[lookupName];
            }
            return result;
        }
    }
}
