using System.Collections.Generic;
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