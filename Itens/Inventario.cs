using System.Collections.Generic;
using System.Data;
using rpgArma;
using rpgItem;

namespace rpgInventario;

public class Inventario
{
    private List<Item> Itens {get; set;}
    private int Capacidade {get; set;}

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

    public void GuardarItem(Item item)
    {
        Itens.Add(item);
    }
    public void DescartarItem(Item item)
    {
        Itens.Remove(item); 
    }
}