using rpgItem;

namespace rpgConsumivel;

public class Consumivel : Item
{
    public int QtdVidaRecuperada {get; private set;}

    public Consumivel(String nome, String descricao, int qtdvidarecuperada) : base(nome, descricao)
    {
        this.QtdVidaRecuperada = qtdvidarecuperada;
    }
}