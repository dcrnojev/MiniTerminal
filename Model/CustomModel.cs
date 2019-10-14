using System;

namespace Zadatak_1
{
    public class CustomModel
    {
        public string Prop1 { get; set; }
        public int Prop2 { get; set; }
        public CustomModelInner Prop3 { get; set; }
        public CustomModel ResursiveProperty { get; set; }
    }

    public class CustomModelInner
    {
    }
}
