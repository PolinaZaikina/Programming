using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var group1 = new Group()
            {
                Students = new List<string> { "Николай", "ПЕтр", "Иван", "Наталья", "Елена" }
            };
            var group2 = new Group()
            {
                Students = new List<string> { "Софья", "Андрей" }
            };
             var group3 = new Group()
             {
                 Students = new List<string>()
             };
             var group4 = new Group()
             {
                 Students = new List<string> { "Алексей" }

             };
             var groups = new List<Group>() { group1, group2, group3, group4 };
            var allStudents = GetAllStudents(groups);
            foreach(var student in allStudents)
                Console.WriteLine(  student);

            Console.ReadKey();

        }
        static List<string> GetAllStudents (List<Group>groups) => groups
            .SelectMany(group=>group.Students)
            .OrderBy(x => x)
            .ToList();
    }
}
