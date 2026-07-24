namespace rpgDialogo;

public class Dialogo
{
    public String Saudacao {get; set;}
    public String Cumprimento {get; set;}
    public String? Introducao {get; set;}
    public String Historia {get; set;}
    public String? HistoriaContinuacao {get; set;}
    public String? Missao {get; set;}
    public String? DespedidaMissaoAceitada {get; set;}
    public String? DespedidaMissaoRecusada {get; set;}
    public String? MissaoConcluida {get; set;}

    public Dialogo(String saudacao, String cumprimento, String? introducao, String historia, String? historiacontinuacao, String? missao, String? despedidamissaoaceitada, String? despedidamissaorecusada, String? missaoconcluida)
    {
        this.Saudacao = saudacao;
        this.Cumprimento = cumprimento;
        this.Introducao = introducao;
        this.Historia = historia;
        this.HistoriaContinuacao = historiacontinuacao;
        this.Missao = missao;
        this.DespedidaMissaoAceitada= despedidamissaoaceitada;
        this.DespedidaMissaoRecusada = despedidamissaorecusada;
        this.MissaoConcluida = missaoconcluida;
    }
}