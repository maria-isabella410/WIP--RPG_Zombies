using System.Collections.Generic;
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
}