using rpgItem;
using rpgTipoMunicao;

namespace rpgMunicao;

public class Municao : Item
{
    public TipoMunicao TipoMunicao {get; private set;}
    public int Quantidade {get; private set;}

    public Municao(String nome, String descricao, TipoMunicao tipomunicao, int quantidade) : base(nome, descricao)
    {
        this.TipoMunicao = tipomunicao;
        this.Quantidade = quantidade;
    }
}