using rpgTipoChave;
using rpgPorta;
using rpgSalasDoJogo;
using rpgSala;
using rpgMapa;

namespace rpgPortasDoJogo;

public class PortasDoJogo
{
    public static Porta CriarPortaSalaDeArmas(Mapa mapa)
    {
        return new Porta(SalasDoJogo.criarSalaDeArmas(mapa), TipoChave.SalaDeArmas);
    }
    public static Porta CriarPortaSalaDeAula(Mapa mapa)
    {
        return new Porta(SalasDoJogo.criarSalaDeAula(mapa), TipoChave.SalaDeAula);
    }
    public static Porta CriarPortaSalaBiblioteca(Mapa mapa)
    {
        return new Porta(SalasDoJogo.criarSalaBiblioteca(mapa), TipoChave.SalaBiblioteca);
    }
    public static Porta CriarPortaArmarioHospital(Mapa mapa)
    {
        return new Porta(SalasDoJogo.criarSalaArmarioHospital(mapa), TipoChave.ArmarioHospital);
    }
    public static Porta CriarPortaLaboratorio(Mapa mapa)
    {
        return new Porta(SalasDoJogo.criarSalaLaboratorio(mapa), TipoChave.Laboratorio);
    }

}