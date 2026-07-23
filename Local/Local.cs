using rpgItem;
using rpgNpc;
using rpgPorta;
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
    public Porta? Porta {get; set;}
    public List<Item> Itens {get; private set;}
    public List<Npc> Npcs {get; private set;}
    public List<Zombie> Zombies {get; private set;}

    public Local(String nome, String descricao, Porta? porta)
    {
        this.Nome = nome;
        this.Descricao = descricao;
        this.Porta = porta;
        
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