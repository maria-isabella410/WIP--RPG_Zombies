namespace rpgItem;

public class Item{
    public String Nome {get; private set;}
    public String Descricao {get; private set;}

    public Item(String nome, String descricao)
    {
        this.Nome = nome;
        this.Descricao = descricao;
    }
}