using rpgItem;
using rpgNpc;
using rpgZombie;

namespace rpgLocal;

public class Local
{
    private String Nome {get; set;}
    private String Descricao {get; set;}
    private Local? Norte {get; set;}
    private Local? Sul {get; set;}
    private Local? Leste {get; set;}
    private Local? Oeste {get; set;}
    private List<Item> Itens {get; set;}
    private List<Zombie> Zombies {get; set;}
    private List<Npc> Npcs {get; set;}

    public Local(String nome, String descricao)
    {
        this.Nome = nome;
        this.Descricao = descricao;
        
        Itens = new List<Item>();
        Zombies = new List<Zombie>();
        Npcs = new List<Npc>();
    }  
}