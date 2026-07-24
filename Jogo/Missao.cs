using System.Collections.Generic;
using rpgItem;

namespace rpgMissao;

public class Missao
{
    private String NomeDaMissao {get; set;}
    private String Descricao {get; set;}
    private Item Recompensa {get; set;}
    private bool Concluida {get; set;} = false;

    public Missao(String nomedamissao, String descricao, Item recompensa)
    {
        this.NomeDaMissao = nomedamissao;
        this.Descricao = descricao;
        this.Recompensa = recompensa;
    }
}