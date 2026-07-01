using rpgItem;

namespace rpgConsumivel;

public class Consumivel : Item
{
    private int QtdVidaRecuperada {get; set;}

    public Consumivel(String nome, String descricao, int qtdvidarecuperada) : base(nome, descricao)
    {
        this.QtdVidaRecuperada = qtdvidarecuperada;
    }
}