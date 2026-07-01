using System.Collections.Generic;
using rpgItem;

namespace rpgInventario;

public class Inventario
{
    private List<Item>? Itens {get; set;}
    private int Capacidade {get; set;}

    public Inventario(List<Item>? itens, int capacidade)
    {
        this.Itens = itens;
        this.Capacidade = capacidade;
    }
}