using System.Diagnostics.Metrics;
using rpgItem;
using rpgTipoArma;
using rpgTipoMunicao;

namespace rpgArma;

public class Arma : Item
{
    private int Dano {get; set;}
    private TipoArma Tipo {get; set;}
    private TipoMunicao? TipoMunicao {get; set;}
    private int? CapacidadeMunicao {get; set;} = null;
    private int? Municao {get; set;} = null;

    public Arma(String nome, String descricao, int dano, TipoArma tipo, TipoMunicao? tipomunicao, int? capacidademunicao, int? municao) : base(nome, descricao)
    {
        this.Dano = dano;
        this.Tipo = tipo;
        this.TipoMunicao = tipomunicao;
        this.CapacidadeMunicao = capacidademunicao;
        this.Municao = municao;
    }

    public Boolean TemMunicao()
    {
        if(Municao == 0) return false;
        else return true;
    }
    public void GastarMunicao()
    {
        Municao -= 1;
    }
    public void Recarregar()
    {
        if(Municao == CapacidadeMunicao)
        {
            Console.WriteLine("Sua arma já está cheia!");
            return;
        }
        while(Municao != CapacidadeMunicao)
        {
            Municao++;   
        }
        Console.WriteLine("Sua arma foi recarregada!");
        
    }
}