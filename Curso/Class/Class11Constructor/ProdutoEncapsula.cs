using System.Globalization;

namespace Curso.Class.Class11Constructor;

internal class ProdutoEncapsula {
    private string _nome;
    public double Preco { get; private set; }
    private int _quantidade;

    public ProdutoEncapsula() {
        _quantidade = 10;
    }

    //sobrecarga do construtor e referencia ao construtor vazio
    public ProdutoEncapsula(string nome, double preco) : this() {
        _nome = nome;
        Preco = preco;
    }

    //PROPRIEDADES PARA ACESSAR ATRIBUTOS PRIVADOS de maneira amigável
    public string Nome { 
        get { return _nome; }
        set {
            if (value != null && value.Length > 1) {
                _nome = value;
            }
        }
    }

    // GET PARA ACESSAR ATRIBUTOS PRIVADOS
    public int GetQuantidade() {
        return _quantidade;
    }

    // SET PARA MODIFICAR ATRIBUTOS PRIVADOS
    public void SetQuantidade(int quantidade) {
        if (quantidade != null && quantidade > -1) {
            _quantidade = quantidade;
        }
    }

    public double ValorTotalEmEstoque() {
        return Preco * _quantidade;
    }

    public void AdicionarProduto(int qtd) {
        _quantidade += qtd;
    }

    public void RemoverProduto(int qtd) {
        _quantidade -= qtd;
    }

    public override string ToString() {
        return _nome
            + ", R$ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: R$ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}
