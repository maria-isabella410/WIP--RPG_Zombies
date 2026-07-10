using rpgItem;
using rpgTipoChave;

namespace rpgChave;

public class Chave : Item
{
    public TipoChave Tipo {get; private set;}

    public Chave(String nome, String descricao, TipoChave tipo) : base(nome, descricao)
    {
        this.Tipo = tipo;
    }
}