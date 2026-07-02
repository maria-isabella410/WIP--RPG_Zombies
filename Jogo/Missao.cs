using System.Collections.Generic;
using rpgArma;
using rpgItem;
using rpgItensDoJogo;
using rpgTipoArma;

namespace rpgMissao;

public class Missao
{
    private String NomeDaMissao {get; set;}
    private String Descricao {get; set;}
    private Item Recompensa {get; set;}

    public Missao(String nomedamissao, String descricao, Item recompensa)
    {
        this.NomeDaMissao = nomedamissao;
        this.Descricao = descricao;
        this.Recompensa = recompensa;
    }
    private void CriaMissao()
    {
        Missao missaoPolicial = new Missao("Encontrar a chave da sala de armas", "Você deve encontrar a chave da sala de armas. Provavelmente está na sala dos armários. Encontre a chave, traga-a para o policial Ethan e você ganhará uma arma como agradecimento. (Recompensa: Shotgun).", ItensDoJogo.CriarShotgun());
    }
}