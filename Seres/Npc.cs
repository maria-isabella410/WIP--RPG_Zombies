using rpgInventario;
using rpgPessoa;

namespace rpgNpc;

public class Npc : Pessoa
{
    private Inventario Inventario {get; set;}

    public Npc(int vidamaxima, int vida, int ataque, int defesa, String nome, Inventario inventario) : base(vidamaxima, vida, ataque, defesa, nome)
    {
        this.Inventario = inventario;
    }
}