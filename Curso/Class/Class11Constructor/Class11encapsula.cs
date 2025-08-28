using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Class.Class11Constructor {
    internal class Class11encapsula {
        public static void Executar() {
            ProdutoEncapsula p = new ProdutoEncapsula("TV", 900.00);

            p.SetQuantidade(5);
            Console.WriteLine(p.GetQuantidade());

            p.Nome = "TV 4K Ultra HD";
            Console.WriteLine(p.Nome);
        }
    }
}
