using rpgArma;
using rpgConsumivel;
using rpgTipoArma;

namespace rpgItensDoJogo;

public class ItensDoJogo
{
    public static Arma CriarPistola()
    {
        return new Arma("Pistola", "Uma arma eficiente contra inimigos. (Causa 25 de dano)", 25, TipoArma.Pistola, 12, 12);
    }
    public static Arma CriarShotgun()
    {
        return new Arma("Shotgun", "Uma arma poderosa que faz um bom estrago. (Causa 50 de dano)", 50, TipoArma.Shotgun, 8, 8);
    }
    public static Arma CriarFaca()
    {
        return new Arma("Faca", "Uma arma pequena, mas eficiente. (Causa 10 de dano)", 10, TipoArma.Faca, null, null);
    }
    public static Consumivel CriarBandagem()
    {
        return new Consumivel("Bandagem", "Recupera um pouco da sua vida. (Cura 20)", 20);
    }
    public static Consumivel CriarKitMed()
    {
        return new Consumivel("Kit Médico", "Recupera grande parte da sua vida. (Cura 70)", 70);
    }
    public static Consumivel CriarSpray()
    {
        return new Consumivel("Spray", "Recupera boa parte sua vida. (Cura 40)", 40);
    }
    public static Consumivel CriarAgua()
    {
        return new Consumivel("Garrafa de Água", "Mata sua sede. (Cura 15)", 15);
    }
    public static Consumivel CriarComidaEnlatada()
    {
        return new Consumivel("Comida enlatada", "Uma comida feita para durar bastante. (Cura 15)", 15);
    }
    public static Consumivel CriarAntidoto()
    {
        return new Consumivel("Antídoto", "A esperança da humanidade.", 100);
    }    
}