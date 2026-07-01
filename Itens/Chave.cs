using rpgItem;
using rpgLocal;

namespace rpgChave;

public class Chave : Item
{
    private Local LocalDesbloqueado {get; set;}

    public Chave(String nome, String descricao, Local localdesbloqueado) : base(nome, descricao)
    {
        this.LocalDesbloqueado = localdesbloqueado;
    }
}