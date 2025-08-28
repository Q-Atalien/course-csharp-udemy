using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Class {
    internal class Class16 {
        public static void Executar() {

            List<string> lista = new List<string>();

            lista.Add("Amanda");
            lista.Add("Bob");
            lista.Add("Kilder");
            lista.Add("Atauine");
            lista.Add("Nais");
            lista.Add("Gumball");
            lista.Add("Darwin");
            lista.Add("Pearl");

            lista.Insert(1, "Lucas");

            foreach (string s in lista) {

                Console.WriteLine(s);
            }

            string s1 = lista.Find(x => x[0] == 'L');
            Console.WriteLine("Começa com L " + s1);

            string s2 = lista.FindLast(x => x[0] == 'B');
            Console.WriteLine("Termina com B " + s2);

            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição: " + pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição: " + pos2);

            List<string> listb = lista.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------");
            foreach (string s in listb) {
                Console.WriteLine(s);
            }

            lista.Remove("Kilder");
            Console.WriteLine("--------------");
            foreach (string s in lista) {
                Console.WriteLine(s);
            }

            lista.RemoveAll(x => x[0] == 'A');
            Console.WriteLine("--------------");
            foreach (string s in lista) {
                Console.WriteLine(s);
            }

            lista.RemoveAt(0);
            Console.WriteLine("--------------");
            foreach (string s in lista) {
                Console.WriteLine(s);
            }

            
            lista.RemoveRange(0, 2);
            Console.WriteLine("--------------");
            foreach (string s in lista) {
                Console.WriteLine(s);
            }
        }
    }
}
