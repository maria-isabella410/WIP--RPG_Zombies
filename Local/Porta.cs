using rpgChave;
using rpgTipoChave;

namespace rpgPorta;

public class Porta
{
    public String Nome {get; private set;}
    public TipoChave ChaveNecessaria {get; set;}
    public Boolean Aberta {get; private set;}

    public Porta(String nome, TipoChave chavenecessaria)
    {
        this.Nome = nome;
        this.ChaveNecessaria = chavenecessaria;
    }
    
    public void Abrir(Chave chave)
    {
        if(chave.Tipo == ChaveNecessaria)
        {
            this.Aberta = true;
            Console.WriteLine("Você abriu a porta!");
        }
        else
        {
            Console.WriteLine("Você não tem a chave necessária para abrir essa porta!");
        }
    }
}