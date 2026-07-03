using rpgItem;
using rpgTipoChave;

namespace rpgChave;

public class Chave : Item
{
    private TipoChave Tipo {get; set;}

    public Chave(String nome, String descricao, TipoChave tipo) : base(nome, descricao)
    {
        this.Tipo = tipo;
    }
}