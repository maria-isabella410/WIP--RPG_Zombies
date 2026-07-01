using System.Diagnostics.Metrics;
using rpgItem;
using rpgTipoArma;

namespace rpgArma;

public class Arma : Item
{
    private int Dano {get; set;}
    private int Durabilidade {get; set;}
    private TipoArma Tipo {get; set;}
    private int CapacidadeMunicao {get; set;}
    private int Municao {get; set;}

    public Arma(String nome, String descricao, int dano, int durabilidade, TipoArma tipo, int capacidademunicao, int municao) : base(nome, descricao)
    {
        this.Dano = dano;
        this.Durabilidade = durabilidade;
        this.Tipo = tipo;
        this.CapacidadeMunicao = capacidademunicao;
        this.Municao = municao;
    }
}