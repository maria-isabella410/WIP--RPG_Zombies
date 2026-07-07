using rpgItem;
using rpgTipoMunicao;

namespace rpgMunicao;

public class Municao : Item
{
    private TipoMunicao TipoMunicao {get; set;}
    private int Quantidade {get; set;}

    public Municao(String nome, String descricao, TipoMunicao tipomunicao, int quantidade) : base(nome, descricao)
    {
        this.TipoMunicao = tipomunicao;
        this.Quantidade = quantidade;
    }
}