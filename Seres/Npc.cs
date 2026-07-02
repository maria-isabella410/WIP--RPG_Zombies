using rpgInventario;
using rpgPessoa;
using rpgMissao;

namespace rpgNpc;

public class Npc : Pessoa
{
    private Inventario Inventario {get; set;}
    private Missao? Missao {get; set;}

    public Npc( String nome, Missao? missao, int vidamaxima, int vida, int ataque, int defesa) : base(vidamaxima, vida, ataque, defesa, nome)
    {
        this.Inventario = new Inventario(10);
        this.Missao = missao;
    }
}