using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace typeReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var type = typeof(MyClass);
            //var type=Type.GetType("typeReflection.MyClass")
            var obj = new MyClass(1);
            var type = obj.GetType();
            //PrintTypeInfo(type);
            //type=typeof(string)

            obj.PublicProperty = 5;
            obj.PublicField = -2;
            var result = obj.MyMethod(3);
                Console.WriteLine(result);
            

            type=typeof(MyClass);
            var obj2 = type
                .GetConstructor(new Type[] { typeof(int) })
                .Invoke(new object[] {1});
            type.GetProperty("PublicProperty")
                .SetValue(obj2, 5);


            type.GetField("PublicField")

               .SetValue(obj2, -2);
            type.GetField("privateFields",System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Instance)
                .SetValue (obj2, 10);

            var val = type("privateFields", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .GetValue(obj2);
            Console.WriteLine(val);

            result =type
                .GetMethod("MyMethod")
                .Invoke(obj2, new object[] {3});

            Console.WriteLine(result);//вернет 13, то есть уже к определенному значению 10 прибавляет 3
               




            Console.ReadKey();

        }
        static void PrintTypeInfo(Type type)
        {
            Console.WriteLine("=====ТИП=====");
            Console.WriteLine(type.FullName);

            Console.WriteLine("====ПОЛЯ====");
            PrintNames(type
                .GetFields();
                .Select(f => f.Name));
           
            Console.WriteLine(" ===Свойства====");
            var propertyNames = type
             .GetProperties()
            .Select(x => x.Name);
            foreach (var name in propertyNames)
                Console.WriteLine($"->{name}");
            
            Console.WriteLine(" ===Методы====");
            var MethodsNames = type
             .GetProperties()
             .Select(y => y.Name);
            foreach (var name in MethodsNames)
                Console.WriteLine($"->{name}");
                

            Console.WriteLine(" ===Интерфейсы====");
            var IfaceNames = type
             .GetInterfaces()
             .Select(y => y.Name);
            foreach (var name in MethodsNames)
            
                Console.WriteLine($"->{name} ");

            Console.WriteLine(" =Закрытые поля====");
            PrintNames(type
               .GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                .Select(f => f.Name));
            var IfaceNames = type
             .GetInterfaces()
             .Select(y => y.Name);
            foreach (var name in MethodsNames)

                Console.WriteLine($"->{name} ");
            Console.WriteLine(" =Статические поля====");

                Console.WriteLine( "==АТРИБУТЫ КЛАССА==");
            PrintNames(type
                .GetCustomAttributes()
                .Select(x => x.));
            var description = type.GetCustomAttributes<DescriptionAttribute>();
            if (descriptions.Count() > 0) {
                Console.WriteLine(  "=====Атрибуты дескрипшн");
                PrintNames(descriptions.Select(x => x.text));
            }
            Console.WriteLine("==атрибты дескрипшн полей");
            var fields = type.GetFields();
            foreach (var field in fields)
            {
                var attr = field.GetCustomAttribute<DescriptionAttribute>();
                Console.WriteLine(  $"->{attr.text});
            }
                
                PrintNames(type.GetFields().SelectMany(x => x.GetCustomAttributes >));
        }
        static void PrintNames(IEnumerable<string> names)
        {
            foreach (var name in names)
                Console.WriteLine( $"->{name}");
        }



        

    }       
                
}


