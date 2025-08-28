using System.Globalization;

namespace Curso.Class.Class11Constructor;

internal class Produto {
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto() {
        Quantidade = 10;
    }

    //sobrecarga do construtor e referencia ao construtor vazio
    public Produto(string nome, double preco) : this() {
        Nome = nome;
        Preco = preco;
    }

    public double ValorTotalEmEstoque() {
        return Preco * Quantidade;
    }

    public void AdicionarProduto(int qtd) {
        Quantidade += qtd;
    }

    public void RemoverProduto(int qtd) {
        Quantidade -= qtd;
    }

    public override string ToString() {
        return Nome
            + ", R$ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: R$ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}
