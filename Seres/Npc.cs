using rpgInventario;
using rpgPessoa;
using rpgMissao;

namespace rpgNpc;

public class Npc : Pessoa
{
    private Inventario Inventario {get; set;}
    private Missao? Missao {get; set;}

    public Npc(String nome, int vidamaxima, int vida, int ataque, int defesa, int agilidade, Missao? missao) : base(vidamaxima, vida, ataque, defesa, agilidade, nome)
    {
        this.Inventario = new Inventario(10);
        this.Missao = missao;
    }
}