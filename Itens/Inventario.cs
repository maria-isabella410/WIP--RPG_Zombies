using System.Collections.Generic;
using System.Data;
using rpgArma;
using rpgConsumivel;
using rpgItem;
using rpgChave;

namespace rpgInventario;

public class Inventario
{
    private List<Item> Itens {get; set;}
    public int Capacidade {get; set;} = 10;

    public Inventario(int capacidade)
    {
        Itens = new List<Item>();
        this.Capacidade = capacidade;
    }
    public List<Item> ListarItens()
    {
        List<Item> itens = new List<Item>();
        
        return Itens;
    }
    public void InspecionarItem(Item item)
    {
        Console.WriteLine($"{item.Nome} - {item.Descricao}");
    }

    public List<Arma> ListarArmas()
    {
        List<Arma> armas = new List<Arma>();
        
        foreach(Item item in Itens)
        {
            if(item is Arma arma)
            {
                armas.Add(arma);
            }
        }

        return armas;   
    }
    public List<Consumivel> ListarConsumiveis()
    {
        List<Consumivel> consumiveis = new List<Consumivel>();

        foreach(Item item in Itens)
        {
            if(item is Consumivel consumivel)
            {
                consumiveis.Add(consumivel);
            }
        }

        return consumiveis;
    }
    public List<Chave> ListarChaves()
    {
        List<Chave> chaves = new List<Chave>();

        foreach(Item item in Itens)
        {
            if(item is Chave chave)
            {
                chaves.Add(chave);
            }
        }

        return chaves;
    }
    public void GuardarItem(Item item)
    {
        Itens.Add(item);
    }
    public void DescartarItem(Item item)
    {
        Itens.Remove(item); 
    }
}