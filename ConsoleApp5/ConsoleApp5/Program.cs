using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "Введите имя текстового файла");
            var fileName=Console.ReadLine();
            if (!File.Exists(fileName))
            {
                Console.WriteLine(  "Такого файла нет");
                Console.ReadKey();

                return;
            }

            var text = File.ReadAllLines(fileName);
            var words = text
                .SelectMany(s => s.Split(new char[] {' ', '.', ',', '!', '?', ';', '"', '-', ':' },
                    StringSplitOptions.RemoveEmptyEntries))
                .Where(w => char.IsLetter(w[0]))
                .Select(w => w.ToLower())
                
                .Distinct()
                .OrderBy(w=>w)
                .ToList();
            PrintWords(words);
            Console.ReadKey();

            //task6
            words = words
                .OrderBy(w => w.Length)
                .ThenBy(w => w)
                .ToList();
            PrintWords(words);
            Console.ReadKey();
            //task7 c упорядочением 
            //Console.WriteLine(  );
            //Console.WriteLine(words.OrderByDescending(w=> w.Length).ThenBy(w=>w).FirstOrDefault());

            //task7 without ordering
            Console.WriteLine(  words
                .Select(w =>(-w.Length, w))C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\PresentationFramework.Aero.dll
                .Min()
                .Item2
                
                );;
        }
        static void PrintWords(IEnumerable<string> words)
        {
            foreach (var word in words)
            {
                Console.WriteLine( word );
            }
        }
        

    }
}
