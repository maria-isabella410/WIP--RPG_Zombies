using rpgPorta;
using rpgLocal;

namespace rpgSala;

public class Sala
{
    public String Nome;
    public Local LocalPertencente;
    public Porta Porta;

    public Sala(String nome, Local localpertencente, Porta porta)
    {
        this.Nome = nome;
        this.LocalPertencente = localpertencente;
        this.Porta = porta;
    }
}