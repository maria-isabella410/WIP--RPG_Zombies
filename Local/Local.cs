using rpgItem;
using rpgNpc;
using rpgZombie;

namespace rpgLocal;

public class Local
{
    private String Nome {get; set;}
    private String Descricao {get; set;}
    private List<Item> Itens {get; set;}
    private List<Zombie> Zombies {get; set;}
    private List<Npc> Npcs {get; set;}

    public Local(String nome, String descricao, List<Item> itens, List<Zombie> zombies, List<Npc> npcs)
    {
        this.Nome = nome;
        this.Descricao = descricao;
        this.Itens = itens;
        this.Zombies = zombies;
        this.Npcs = npcs;
    }  
}