using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace typeReflection
{
    [Serializable]
    [Description("Класс для примера рефлексии типов")]
    
    internal class MyClass: IComparable 
    {
        static string Remark="";
        [Description("Пример открытого свойства")]
        public int PublicProperty { get; set; }
        Description("Пример открытого поля")
        public int PublicField;
        private int PrivateField;
        public int AnotherPublicField;
        public MyClass(int x)
        { PrivateField = x; }
        public int MyMethod(int x)=> x+ PrivateField;
        public object Clone() => MemberwiseClone();
    }
    
}
