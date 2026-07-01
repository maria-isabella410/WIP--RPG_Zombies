using System.Diagnostics.Metrics;
using rpgItem;
using rpgTipoArma;

namespace rpgArma;

public class Arma : Item
{
    private int Dano {get; set;}
    private TipoArma Tipo {get; set;}
    private int? CapacidadeMunicao {get; set;} = null;
    private int? Municao {get; set;} = null;

    public Arma(String nome, String descricao, int dano, TipoArma tipo, int? capacidademunicao, int? municao) : base(nome, descricao)
    {
        this.Dano = dano;
        this.Tipo = tipo;
        this.CapacidadeMunicao = capacidademunicao;
        this.Municao = municao;
    }
}