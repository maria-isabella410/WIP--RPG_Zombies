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
    public static Missao MissaoPolicial()
    {
        return new Missao("- Abra a sala de armas -", "Você deve encontrar a chave da sala de armas. Provavelmente está na sala dos armários. Encontre a chave, traga-a para o policial Ethan e você ganhará uma arma como agradecimento. (Recompensa: Shotgun)", ItensDoJogo.CriarShotgun());
    }
    public static Missao MissaoEnfermeira()
    {
        return new Missao("- Traga-me bandagens -", "Você deve entregar 3 bandagens para a enfermeira Grace, assim ela poderá tratar seus ferimentos. (Recompensa: Cura completa)", null);
    }
    public static Missao MissaoCientista()
    {
        return new Missao("- Enontre documentos perdidos -", "Você deve ir até a biblioteca e encontrar uma pasta de documentos deixada pelo cientista Freddie. Se trouxer o que ele precisa, ele poderá finalizar a criação do antídoto. (Recompensa: Imunidade ao vírus - Final bom)", ItensDoJogo.CriarAntidoto());
    }
    public static Missao MissaoPadre()
    {
        return new Missao("- Billy está desaparecido -", "Você deve ir até a floresta e encontrar Billy, o cachorrinho do padre John. Se conseguir trazê-lo bem, será recompensado com suprimentos que o padre tem guardados. (Recompensa: 2 Comidas enlatadas e 1 Garrafa de água)", ItensDoJogo.CriarComidaEnlatada());
    }
    public static Missao MissaoProfessora()
    {
        return new Missao("- Mary está sozinha -", "Você deve buscar na escola a aluna Mary, que se perdeu durante o surto. Ela está trancada em uma sala, mas a professora Sarah não consegue ir até lá porque há muitos zombies no caminho. Traga Mary bem e será recompensado com um kit médico. (Recompensa: Kit médico)", ItensDoJogo.CriarKitMed());
    }
}