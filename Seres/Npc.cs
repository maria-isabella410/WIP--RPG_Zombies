using System.Collections.Generic;
using rpgInventario;
using rpgPessoa;
using rpgItem;

namespace rpgNpc;

public class Npc : Pessoa
{
    private Inventario Inventario {get; set;}
    private String? Missao {get; set;}

    public Npc( String nome, String? missao, int vidamaxima, int vida, int ataque, int defesa) : base(vidamaxima, vida, ataque, defesa, nome)
    {
        this.Inventario = new Inventario(10);
        this.Missao = missao;
    }

    private void CriaNpc()
    {
        Npc cientista = new Npc("Freddie", null, 100, 100, 0, 20);
        Npc policial = new Npc("Ethan", null, 120, 120, 0, 40);
        Npc enfermeira = new Npc("Grace", null, 100, 100, 0, 10);
        Npc padre = new Npc("John", null, 100, 100, 0, 10);
        Npc professora = new Npc("Sarah", null, 100, 100, 0, 20);
        Npc crianca = new Npc("Mary", null, 60, 60, 0, 10);
        Npc cachorro = new Npc("Billy", null, 40, 40, 0, 10);
    }
}