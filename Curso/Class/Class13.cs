using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Class {
    internal class Class13 {
        public static void Executar() {
            //configurando variaveis para receber null 
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X nulo");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y nulo");

            double? w = x ?? 6;
            double? z = y ?? 6;

            Console.WriteLine(w);
            Console.WriteLine(z);
        }
    }
}
