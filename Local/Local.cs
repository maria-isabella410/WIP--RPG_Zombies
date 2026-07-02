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
        private List<Npc> Npcs {get; set;}
    private List<Zombie> Zombies {get; set;}

    public Local(String nome, String descricao)
    {
        this.Nome = nome;
        this.Descricao = descricao;
        
        Itens = new List<Item>();
        Npcs = new List<Npc>();
        Zombies = new List<Zombie>();
    }

    public void AdicionarItens(Item item)
    {
        Itens.Add(item);
    }
    public void AdicionarNpc(Npc npc)
    {
        Npcs.Add(npc);
    }  
    public void AdicionarZombie(Zombie zombie)
    {
        Zombies.Add(zombie);
    }
}