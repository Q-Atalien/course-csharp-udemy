using System.Globalization;


namespace Curso.Class {
    class Classe1 {
        public static void Executar() {

            sbyte x = 100;

            Console.WriteLine(x);

            double saldo = 15.9933;
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

            int idades = 32;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idades, saldo);

            Console.WriteLine($"{nome} tem {idades} anos e tem saldo igual a {saldo:F2} reais.");

            Console.WriteLine(nome + " tem " + idades + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais.");

            Console.WriteLine("");
            Console.WriteLine("Exercicio 1");

            string p1 = "Computador";
            string p2 = "Mesa de Escritório";

            byte idade = 23;
            int codigo = 2342;
            char genero = 'F';

            double pc1 = 2100.00;
            double pc2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("");
            Console.WriteLine("Produtos:");
            Console.WriteLine("");
            Console.WriteLine($"{p1}, cujo o preço é R${pc1:F2}");
            Console.WriteLine($"{p2}, cujo o preço é R${pc2:F2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genero {genero}.");
            Console.WriteLine("");
            Console.WriteLine($"Medida com oito casas decimais {medida:F8}");
            Console.WriteLine($"Arredondado (Três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("");

        }
    }
}
