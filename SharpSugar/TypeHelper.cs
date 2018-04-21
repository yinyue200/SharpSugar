using System;

namespace Yinyue200.SharpSugar
{
    public static class TypeHelper
    {
        public static T StaticCastTo<T>(this object obj)
        {
            return (T)obj;
        }
        public static T DynamicCastTo<T>(this object obj) where T:class
        {
            return obj as T;
        }
    }
}
