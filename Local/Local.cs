using rpgItem;
using rpgNpc;
using rpgZombie;

namespace rpgLocal;

public class Local
{
    public String Nome {get; private set;}
    public String Descricao {get; private set;}
    public Local? Norte {get; set;}
    public Local? Sul {get; set;}
    public Local? Leste {get; set;}
    public Local? Oeste {get; set;}
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
    public static void DescreverLocal(Local local)
    {
        Console.WriteLine("Local: " + local.Nome);
        Console.WriteLine("Descrição: " + local.Descricao);
    }
}