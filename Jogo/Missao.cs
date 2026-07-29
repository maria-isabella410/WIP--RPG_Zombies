using System.Collections.Generic;
using rpgItem;

namespace rpgMissao;

public class Missao
{
    public String NomeDaMissao {get; set;}
    public String Descricao {get; set;}
    public Item Recompensa {get; set;}
    public bool Concluida {get; set;} = false;

    public Missao(String nomedamissao, String descricao, Item recompensa)
    {
        this.NomeDaMissao = nomedamissao;
        this.Descricao = descricao;
        this.Recompensa = recompensa;
    }
}