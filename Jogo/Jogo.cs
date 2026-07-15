using rpgItem;
using rpgJogador;
using rpgLocal;
using rpgInventario;
using System.Security.Cryptography.X509Certificates;
using rpgCombate;
using rpgMapa;
using System.Runtime.ConstrainedExecution;

namespace rpgJogo;

public class Jogo
{
    private Jogador Jogador {get; set;}
    private Local LocalAtual {get; set;}
    private Boolean emExecucao {get; set;}
    private Mapa Mapa {get; set;}
    private Random random {get; set;}

    public Jogo(Jogador jogador, Local localatual)
    {
        this.Jogador = jogador;
        this.LocalAtual = localatual;
    }
    public static void DivisaoDeLinha()
    {
        Console.WriteLine("-----------------------");
    }
    public void Iniciar()
    {
        emExecucao = true;

        Mapa mapa = new Mapa(random);

        Console.WriteLine("Qual será seu nome?");
        Console.Write("--> ");

        String nomeJogador = Console.ReadLine();

        Jogador jogador = new Jogador(100, 100, 30, 20, 25, nomeJogador, Mapa.ruaPrincipal);

        //contexto inicial
        DivisaoDeLinha();
        
        Console.WriteLine("O mundo como conhecíamos acabou...");
        Console.WriteLine("Mortos-vivos tomaram as ruas da cidade, devorando todos as pessoas que encontravam!");
        Console.WriteLine("Algumas pessoas conseguiram escapar e se esconderam em abrigos improvisados, mas os recursos são escassos e as ruas são perigosas...");
        Console.WriteLine($"Você, {Jogador.Nome}, é uma dessas pessoas. Você sobreviveu até aqui, porém, mais do que sobreviver, você quer descobrir o que causou tudo isso e como resolver!");
        Console.WriteLine("Busque recursos, ajude outros sobreviventes, encontre respostas e claro, sobreviva.");
        
        DivisaoDeLinha();

        Console.WriteLine("Atualmente, você está em: ");
        Local.DescreverLocal(Mapa.ruaPrincipal);

        while (emExecucao)
        {
            MenuPrincipal();

            int opcao = Convert.ToInt32(Console.ReadLine());
        
            opcoesMenu escolha = (opcoesMenu)opcao;

            switch (escolha)
            {
                case opcoesMenu.Explorar:
                
                    break;
                case opcoesMenu.AbrirMapa:
                
                    break;
                case opcoesMenu.AbrirInventario:
                    List<Item> itens = Jogador.Inventario.ListarItens();

                    for(int i = 0; i < itens.Count; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {itens[i].Nome}");
                    }

                    MenuInventario();

                    int opcaoInventario = Convert.ToInt32(Console.ReadLine());
        
                    opcoesInventario escolhaInventario = (opcoesInventario)opcaoInventario;

                    switch (escolhaInventario)
                    {
                        case opcoesInventario.InspecionarItem:
                            Console.WriteLine("Qual item deseja inspecionar?");

                            Jogador.Inventario.ListarItens();
                            
                            Console.Write("--> ");

                            int idInspecao = Convert.ToInt32(Console.ReadLine());

                            Jogador.Inventario.InspecionarItem(itens[idInspecao - 1]);

                            break;
                        case opcoesInventario.ConsumirItem:
                            
                            break;
                        case opcoesInventario.UsarChave:

                            break;
                        case opcoesInventario.DescartarItem:
                            Console.WriteLine("Qual item deseja descartar?");

                            Jogador.Inventario.ListarItens();
                            
                            Console.Write("--> ");

                            int idDescarte = Convert.ToInt32(Console.ReadLine());

                            Jogador.Inventario.DescartarItem(itens[idDescarte - 1]);

                            Console.WriteLine($"O item {itens[idDescarte - 1].Nome} foi descartado!");

                            break;
                    }

                    break;
                case opcoesMenu.VerificarStatus:
                    MostrarStatus();
                    break;
                default:
                    Console.WriteLine("Entrada inválida!");
                    break;
            }
        }

        Encerrar();
    }
    public void MenuPrincipal()
    {
        DivisaoDeLinha();
        Console.WriteLine("O que quer fazer?");
        Console.WriteLine("[1] Explorar");
        Console.WriteLine("[2] Abrir mapa");
        Console.WriteLine("[3] Abrir inventário");
        Console.WriteLine("[4] Verificar status");
        Console.Write("--> ");
        DivisaoDeLinha();
    }
    private enum opcoesMenu
    {
        Explorar = 1,
        AbrirMapa = 2,
        AbrirInventario = 3,
        VerificarStatus = 4
    }
    private void MenuInventario()
    {
        DivisaoDeLinha();
        Console.WriteLine("O que quer fazer?");
        Console.WriteLine("[1] Inspecionar item");
        Console.WriteLine("[2] Usar uma chave");
        Console.WriteLine("[3] Consumir um item");
        Console.WriteLine("[4] Descartar item");
        Console.WriteLine("[0] Voltar");
        Console.Write("--> ");
        DivisaoDeLinha();
    }
    private enum opcoesInventario
    {
        InspecionarItem = 1,
        UsarChave = 2,
        ConsumirItem = 3,
        DescartarItem = 4
    }
    public void Explorar()
    {
        
    }
    public void MostrarStatus()
    {
        DivisaoDeLinha();
        Console.WriteLine("Jogador: " + Jogador.Nome);
        Console.WriteLine($"HP: [{Jogador.Vida} / {Jogador.VidaMaxima}]");
        Console.WriteLine("Ataque: " + Jogador.Ataque);
        Console.WriteLine("Defesa: " + Jogador.Defesa);
        Console.WriteLine("Agilidade: " + Jogador.Agilidade);

        if(Jogador.MissaoAtual != null)
        {
            Console.WriteLine("Missão atual: " + Jogador.MissaoAtual);
        }
        DivisaoDeLinha();
    }
    public void AbrirInventario()
    {
        
    }
    public void ConversarComNpc()
    {
        
    }
    public void ColetarItem()
    {
        
    }
    public void EscolherDirecao()
    {
        
    }
    public void AtualizarMissao()
    {
        
    }
    public void Encerrar()
    {
        
    }
}