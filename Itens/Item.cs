namespace rpgItem;

public class Item{
    private String Nome {get; set;}
    private String Descricao {get; set;}

    public Item(String nome, String descricao)
    {
        this.Nome = nome;
        this.Descricao = descricao;
    }
}